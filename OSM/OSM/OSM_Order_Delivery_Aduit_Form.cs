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
    public partial class OSM_Order_Delivery_Aduit_Form : UserControl
    {
        //父窗口
        private FormOSM_Main main_form;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_Order_Delivery_Aduit_Form()
        {
            InitializeComponent();

            dateTimePicker_OrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string whereString = "where PID = 2 order by ID";
            SJZDController.setZD_ComboBox(whereString, comboBox_OrderState);
            comboBox_OrderState.SelectedIndex = 2;
            comboBox_OrderState.Enabled = false;

            whereString = "where PID = 24 order by ID";
            SJZDController.setZD_ComboBox(whereString, comboBox_PayState);

            //查询订单视图返回结果
            queryFromOrderSheetV(dataGridView_Order, "where ORDER_STATE = '3' ");
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
        /// 查询订单视图返回结果给DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="whereString"></param>
        private void queryFromOrderSheetV(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_ORDER_SHEET_V ";

            OSM_Pager_Order.setDataGridView(dataGridView_Order);
            OSM_Pager_Order.setQueryString(sql);
            OSM_Pager_Order.setKey("ID");
            OSM_Pager_Order.setWhereString(whereString);
            OSM_Pager_Order.setOrderString("ID DESC");
            OSM_Pager_Order.setPageIndex(1);
            OSM_Pager_Order.setPageSize(10);
            OSM_Pager_Order.refreshDataGirdViewBySQL(dataGridView_Order);
        }

        /// <summary>
        /// 重置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_OrderState.SelectedIndex = 2;
            comboBox_PayState.SelectedIndex = -1;
            dateTimePicker_OrderDate.CustomFormat = " ";
        }

        /// <summary>
        /// 日期控件下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_OrderDate_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_OrderDate.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Query_Click(object sender, EventArgs e)
        {
            string whereString = "where ORDER_STATE = '3' ";

            if (!string.IsNullOrWhiteSpace(dateTimePicker_OrderDate.Text))
            {
                whereString += " and ORDER_DATE = #" + dateTimePicker_OrderDate.Text + "# ";
            }

            //if (comboBox_OrderState.SelectedIndex != -1)
            //{
            //    KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_OrderState.SelectedItem;
            //    whereString += " and ORDER_STATE = '" + kv.Key + "'";
            //}

            if (comboBox_PayState.SelectedIndex != -1)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_PayState.SelectedItem;
                whereString += " and PAY_STATE = '" + kv.Key + "' ";
            }

            queryFromOrderSheetV(dataGridView_Order, whereString);
        }


        /// <summary>
        /// DataGridView单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Order.Columns[e.ColumnIndex].Name == "viewOrderBtn")
            {
                string order_id = dataGridView_Order.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                viewOrderSheet(order_id);
            }

            if (dataGridView_Order.Columns[e.ColumnIndex].Name == "auditBtn")
            {
                string order_id = dataGridView_Order.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string offersheet_code = dataGridView_Order.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();

                //checkOfferHW(order_id, offersheet_code);
                checkDelivery(order_id);
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

        /// <summary>
        /// 检查是否可以发货
        /// </summary>
        /// <param name="order_id"></param>
        private void checkDelivery(string order_id)
        {
            string sql = "select PAY_MODE,PAY_STATE,ALREADY_PAYMENT,PRE_PAYMENT,REQUIRE_PAYMENT from OSM_ORDER_SHEET where ID = " + order_id;

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(sql);

            Hashtable hashtable = new Hashtable();

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                string pay_mode = dr["PAY_MODE"].ToString();
                string pay_state = dr["PAY_STATE"].ToString();
                double already_payment = double.Parse(dr["ALREADY_PAYMENT"].ToString());
                double pre_payment = double.Parse(dr["PRE_PAYMENT"].ToString());
                double require_payment = double.Parse(dr["REQUIRE_PAYMENT"].ToString());
                //hashtable.Add("PAY_MODE", dr["PAY_MODE"]);
                //hashtable.Add("PAY_STATE", dr["PAY_STATE"]);
                //hashtable.Add("ALREADY_PAYMENT", dr["ALREADY_PAYMENT"]);
                //hashtable.Add("PRE_PAYMENT", dr["PRE_PAYMENT"]);
                //hashtable.Add("REQUIRE_PAYMENT", dr["REQUIRE_PAYMENT"]);
                
                switch (pay_mode)
                {
                    case "1":
                        if (pay_state == "2")
                        {
                            orderDeliver(order_id);
                        }
                        else
                        {
                            MessageBox.Show("未付全款，无法发货！", "警告");
                        }
                        break;
                    case "2":
                        if (pay_state == "1")
                        {
                            orderDeliver(order_id);
                        }
                        break;
                    case "3":
                        if (pay_state == "3")
                        {
                            orderDeliver(order_id);
                        }
                        else
                        {
                            MessageBox.Show("未预付部分款，无法发货！", "警告");
                        }
                        break;
                }

                string checkPayListSQL = "select ID from OSM_PAYMENTREMINDER_SHEET where ORDER_ID = " + order_id;
                DataTable dataT = adb.SQLTableQuery(checkPayListSQL);
                if (dataT.Rows.Count == 0)
                {
                    createPaySheet(order_id);
                }
            }
        }

        /// <summary>
        /// 生成发货单
        /// </summary>
        /// <param name="order_id"></param>
        private void orderDeliver(string order_id)
        {
            AccessDB adb = new AccessDB();

            string insertSQL = "insert into OSM_DILIVERY_SHEET(ORDER_ID,DILIVERY_STATE) values(" + order_id + ",'1')";

            if (adb.SQLExecute(insertSQL))
            {
                string updateSQL = "update OSM_ORDER_SHEET set ORDER_STATE = '4' where ID = " + order_id;
                if (adb.SQLExecute(updateSQL))
                {
                    MessageBox.Show("该订单可以发货，已生成发货单！", "消息");
                    queryFromOrderSheetV(dataGridView_Order, "where ORDER_STATE = '3' ");
                }
            }
        }

        /// <summary>
        /// 生成收款单
        /// </summary>
        /// <param name="order_id">订单ID</param>
        private void createPaySheet(string order_id)
        {
            AccessDB adb = new AccessDB();

            string payListSQL = "insert into OSM_PAYMENTREMINDER_SHEET(ORDER_ID,GEN_DATE) values (" + order_id + ",#" + DateTime.Now.ToString("yyyy-MM-dd") + "#)";

            if (adb.SQLExecute(payListSQL))
            {
                MessageBox.Show("已生成对应收款单！", "消息");
            }
            else
            {
                MessageBox.Show("生成收款单遇到错误！", "错误");
            }
        }
    }
}
