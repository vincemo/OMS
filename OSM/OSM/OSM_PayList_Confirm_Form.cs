using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using OSM.DBClass;

namespace OSM
{
    public partial class OSM_PayList_Confirm_Form : UserControl
    {
        //父窗口
        private FormOSM_Main main_form;

        public OSM_PayList_Confirm_Form()
        {
            InitializeComponent();

            dateTimePicker_GenDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string whereString = "where PID = 20 order by ID";
            SJZDController.setZD_ComboBox(whereString, comboBox_PayMode);

            whereString = "where PID = 24 and C_CODE in ('1','3') order by ID";
            SJZDController.setZD_ComboBox(whereString, comboBox_PayState);

            queryFormPayListView(dataGridView_PayList, " where PAY_STATE in ('1','3') ");
        }

        /// <summary>
        /// 设置父窗口
        /// </summary>
        /// <param name="main_form"></param>
        public void setMainForm(FormOSM_Main mainForm)
        {
            main_form = mainForm;
        }

        /// <summary>
        /// 查询收款单视图返回结果给DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="whereString"></param>
        private void queryFormPayListView(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_PAYMENTREMINDER_SHEET_V ";

            OSM_Pager_PayList.setDataGridView(dgv);
            OSM_Pager_PayList.setQueryString(sql);
            OSM_Pager_PayList.setKey("ID");
            OSM_Pager_PayList.setWhereString(whereString);
            OSM_Pager_PayList.setOrderString("ID DESC");
            OSM_Pager_PayList.setPageIndex(1);
            OSM_Pager_PayList.setPageSize(10);
            OSM_Pager_PayList.refreshDataGirdViewBySQL(dgv);
        }

        /// <summary>
        /// 重置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            dateTimePicker_GenDate.CustomFormat = " ";
            comboBox_PayMode.SelectedIndex = -1;
            comboBox_PayState.SelectedIndex = -1;
        }

        /// <summary>
        /// 日期控件下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_GenDate_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_GenDate.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Query_Click(object sender, EventArgs e)
        {
            string whereString = " where PAY_STATE in ('1','3') ";

            if (!string.IsNullOrWhiteSpace(dateTimePicker_GenDate.Text))
            {
                whereString += " and GEN_DATE = #" + dateTimePicker_GenDate.Text + "#";
            }

            if (comboBox_PayMode.SelectedIndex != -1)
            {
                KeyValuePair<string,string> kv = (KeyValuePair<string,string>)comboBox_PayMode.SelectedItem;
                whereString += " and PAY_MODE = '" + kv.Key + "' ";
            }

            if (comboBox_PayState.SelectedIndex != -1)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_PayState.SelectedItem;
                whereString += " and PAY_STATE = '" + kv.Key + "' ";
            }

            queryFormPayListView(dataGridView_PayList, whereString);
        }

        /// <summary>
        /// DataGridView单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_PayList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_PayList.Columns[e.ColumnIndex].Name == "viewOrderBtn")
            {
                string order_id = dataGridView_PayList.Rows[e.RowIndex].Cells["ORDER_ID"].Value.ToString();

                viewOrderSheet(order_id);
            }

            if (dataGridView_PayList.Columns[e.ColumnIndex].Name == "PayBtn")
            {
                AccessDB adb = new AccessDB();

                string p_id = dataGridView_PayList.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string order_id = dataGridView_PayList.Rows[e.RowIndex].Cells["ORDER_ID"].Value.ToString();
                string payMode = dataGridView_PayList.Rows[e.RowIndex].Cells["PAY_MODE"].Value.ToString();
                string payState = dataGridView_PayList.Rows[e.RowIndex].Cells["PAY_STATE"].Value.ToString();
                string need_to_pay = dataGridView_PayList.Rows[e.RowIndex].Cells["REQUIRE_PAYMENT"].Value.ToString();
                string pre_pay = dataGridView_PayList.Rows[e.RowIndex].Cells["PRE_PAYMENT"].Value.ToString();
                string already_pay = dataGridView_PayList.Rows[e.RowIndex].Cells["ALREADY_PAYMENT"].Value.ToString();

                switch (payMode)
                {
                    case "1":
                        if (payState == "1")
                        {
                            getPayed(order_id, p_id, need_to_pay);
                        }
                        else
                        {
                            MessageBox.Show("该订单已付款！", "消息");
                            return;
                        }
                        break;
                    case "2":
                        if (payState == "1")
                        {
                            string sql = "select ORDER_STATE from OSM_ORDER_SHEET where ID = " + order_id;
                            DataTable dt = adb.SQLTableQuery(sql);
                            DataRow dr = dt.Rows[0];
                            string order_state = dr["ORDER_STATE"].ToString();

                            if (order_state == "6")
                            {
                                getPayed(order_id, p_id, need_to_pay);
                            }
                            else
                            {
                                MessageBox.Show("该订单为货到付款，现订单状态非已到货,无法提前付款！", "警告");
                            }
                        }
                        else
                        {
                            MessageBox.Show("该订单已付款！", "消息");
                            return;
                        }
                        break;
                    case "3":
                        if (payState == "1")
                        {
                            getPrePayed(order_id, p_id, need_to_pay);
                        }
                        else if (payState == "3")
                        {
                            string sql = "select ORDER_STATE from OSM_ORDER_SHEET where ID = " + order_id;
                            DataTable dt = adb.SQLTableQuery(sql);
                            DataRow dr = dt.Rows[0];
                            string order_state = dr["ORDER_STATE"].ToString();

                            if (order_state == "6")
                            {
                                getRestPayed(order_id, p_id, need_to_pay, already_pay);
                            }
                            else
                            {
                                MessageBox.Show("该订单已预付部分款，现订单状态非已到货,无法提前付剩余款！", "警告");
                            }
                        }
                        else
                        {
                            MessageBox.Show("该订单已付款！", "消息");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("付款方式出错！", "错误");
                        break;
                }
            }
        }

        /// <summary>
        /// 查看订单按钮
        /// </summary>
        /// <param name="order_id"></param>
        private void viewOrderSheet(string order_id)
        {
            string sql = "select OSM_ORDER_SHEET.ID,OFFERSHEET_ID,ORDER_STATE,ORDER_DATE,PAY_MODE,PAY_STATE,ALREADY_PAYMENT,PRE_PAYMENT,REQUIRE_PAYMENT,OFFERSHEET_CODE ";
            sql += " from (OSM_ORDER_SHEET inner join OSM_OFFER_SHEET on OSM_ORDER_SHEET.OFFERSHEET_ID = OSM_OFFER_SHEET.ID) ";
            sql += " where OSM_ORDER_SHEET.ID = " + order_id + " ";

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(sql);

            Hashtable hashtable = new Hashtable();

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                hashtable.Add("ID", dr["ID"]);
                hashtable.Add("OFFERSHEET_ID", dr["OFFERSHEET_ID"]);
                hashtable.Add("ORDER_STATE", dr["ORDER_STATE"]);
                hashtable.Add("ORDER_DATE", dr["ORDER_DATE"]);
                hashtable.Add("PAY_MODE", dr["PAY_MODE"]);
                hashtable.Add("PAY_STATE", dr["PAY_STATE"]);
                hashtable.Add("ALREADY_PAYMENT", dr["ALREADY_PAYMENT"]);
                hashtable.Add("PRE_PAYMENT", dr["PRE_PAYMENT"]);
                hashtable.Add("REQUIRE_PAYMENT", dr["REQUIRE_PAYMENT"]);
                hashtable.Add("OFFERSHEET_CODE", dr["OFFERSHEET_CODE"]);
            }

            FormOSM_Order_View orderView = new FormOSM_Order_View();
            orderView.setOrderID(order_id);
            //设置窗口状态为查看
            orderView.setViewState(0);
            orderView.viewOrderSheet(hashtable);
            orderView.StartPosition = FormStartPosition.CenterParent;
            orderView.ShowDialog();
        }

        private void getPayed(string order_id, string p_id, string need_to_pay)
        {
            FormOSM_GetPayed gp = new FormOSM_GetPayed();
            gp.setRequirePaymentParam(order_id, p_id, need_to_pay);
            gp.ShowDialog();
            queryFormPayListView(dataGridView_PayList, " where PAY_STATE in ('1','3') ");
        }

        private void getPrePayed(string order_id, string p_id, string need_to_pay)
        {
            FormOSM_GetPrePayed gpp = new FormOSM_GetPrePayed();
            gpp.setPrePayParam(order_id, p_id, need_to_pay);
            gpp.ShowDialog();
            queryFormPayListView(dataGridView_PayList, " where PAY_STATE in ('1','3') ");
        }

        private void getRestPayed(string order_id, string p_id, string need_to_pay, string already_pay)
        {
            FormOSM_GetRestPayed grp = new FormOSM_GetRestPayed();
            grp.setRestPayedParam(order_id, p_id, need_to_pay, already_pay);
            grp.ShowDialog();
            queryFormPayListView(dataGridView_PayList, " where PAY_STATE in ('1','3') ");
        }
    }
}
