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
    public partial class OSM_Offer_Audit_Form : UserControl
    {
        //父窗口
        private FormOSM_Main main_form;

        //付款方式
        private string pay_mode;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_Offer_Audit_Form()
        {
            InitializeComponent();

            dateTimePicker_OfferSheet_Audit.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string  whereString = "where PID = 10";
            SJZDController.setZD_ComboBox(whereString, comboBox_OfferSheet_Audit);

            refreshOfferSheetList(dataGridView_OfferSheet_Audit, "where OFFERSHEET_STATE = '1'");
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
        /// 设置付款方式
        /// </summary>
        /// <param name="pmode"></param>
        public void setPayMode(string pmode)
        {
            pay_mode = pmode;
        }

        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_OfferSheet_Audit.SelectedIndex = -1;
            dateTimePicker_OfferSheet_Audit.CustomFormat = " ";
        }

        /// <summary>
        /// 日期控件下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_OfferSheet_Audit_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_OfferSheet_Audit.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Query_Click(object sender, EventArgs e)
        {
            string whereString = "where OFFERSHEET_STATE = '1' ";
            if (!string.IsNullOrWhiteSpace(dateTimePicker_OfferSheet_Audit.Text))
            {
                whereString += " and OFFERSHEET_DATE = #" + dateTimePicker_OfferSheet_Audit.Text + "# ";
            }

            if (comboBox_OfferSheet_Audit.SelectedIndex != -1)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_OfferSheet_Audit.SelectedItem;
                whereString += " and OFFERSHEET_TYPE = '" + kv.Key + "' ";
            }

            refreshOfferSheetList(dataGridView_OfferSheet_Audit, whereString);
        }

        private void refreshOfferSheetList(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_OFFER_SHEET_V ";


            OSM_Pager_OfferSheet_Audit.setDataGridView(dgv);
            OSM_Pager_OfferSheet_Audit.setQueryString(sql);
            OSM_Pager_OfferSheet_Audit.setKey("OFFERSHEET_CODE");
            OSM_Pager_OfferSheet_Audit.setWhereString(whereString);
            OSM_Pager_OfferSheet_Audit.setOrderString("OFFERSHEET_CODE DESC");
            OSM_Pager_OfferSheet_Audit.setPageIndex(1);
            OSM_Pager_OfferSheet_Audit.setPageSize(10);
            OSM_Pager_OfferSheet_Audit.refreshDataGirdViewBySQL(dgv);
        }

        /// <summary>
        /// dataGridView单元按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_OfferSheet_Audit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_OfferSheet_Audit.Columns[e.ColumnIndex].Name == "viewBtn")
            {
                //MessageBox.Show(dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString());
                string offersheet_id = dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                viewOfferSheet(offersheet_id);
            }

            if (dataGridView_OfferSheet_Audit.Columns[e.ColumnIndex].Name == "auditBtn")
            {
                //MessageBox.Show(dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                string offersheet_id = dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string offersheet_code = dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();
                FormOSM_OfferSheet_AuditBox offerSheetAuditBox = new FormOSM_OfferSheet_AuditBox();
                offerSheetAuditBox.setOfferSheetID(offersheet_id);
                offerSheetAuditBox.setOfferSheetCode(offersheet_code);
                offerSheetAuditBox.setMainForm(main_form);
                offerSheetAuditBox.StartPosition = FormStartPosition.CenterParent;
                offerSheetAuditBox.ShowDialog();
            }

            if (dataGridView_OfferSheet_Audit.Columns[e.ColumnIndex].Name == "passBtn")
            {
                DialogResult result = MessageBox.Show("确定通过审核？", "提醒", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string offersheet_id = dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    string offersheet_code = dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();

                    PassOfferSheet(offersheet_id, offersheet_code);
                }
            }

            if (dataGridView_OfferSheet_Audit.Columns[e.ColumnIndex].Name == "failBtn")
            {
                DialogResult result = MessageBox.Show("确定审核不通过？", "提醒", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string offersheet_id = dataGridView_OfferSheet_Audit.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    FailOfferSheet(offersheet_id);
                }
            }
        }

        /// <summary>
        /// 对应报价单审核通过
        /// </summary>
        /// <param name="offerSheetID">报价单ID</param>
        /// <param name="offerSheetCode">报价单编号</param>
        private void PassOfferSheet(string offerSheetID, string offerSheetCode)
        {
            AccessDB adb = new AccessDB();

            string query = "select sum(HW_TOTALPRICE) as REQUIRE_PAYMENT from OSM_HW where OFFERSHEET_CODE = '" + offerSheetCode + "'";
            DataTable dt = adb.SQLTableQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                double require_payment = 0;
                try
                {
                    require_payment = double.Parse(dr["REQUIRE_PAYMENT"].ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("该报价单没有对应的货物列表，无法通过审核！" + exception.ToString(), "警告");
                    return;
                }

                FormOSM_PayMode_Select fps = new FormOSM_PayMode_Select();
                fps.setOfferForm(this);
                fps.StartPosition = FormStartPosition.CenterParent;
                fps.ShowDialog();

                if (!string.IsNullOrWhiteSpace(pay_mode))
                {
                    //生成订单存入数据库
                    string insertSQL = "insert into OSM_ORDER_SHEET(OFFERSHEET_ID,ORDER_STATE,REQUIRE_PAYMENT,ORDER_DATE,PAY_STATE,PAY_MODE) values ('";
                    insertSQL += offerSheetID + "','1'," + require_payment + ",#" + DateTime.Now.ToString("yyyy-MM-dd") + "#,'1','" + pay_mode + "')";
                    if (adb.SQLExecute(insertSQL))
                    {
                        MessageBox.Show("已将审核通过的报价单生成订单", "消息");

                        string sql = "update OSM_OFFER_SHEET set OFFERSHEET_STATE = '2' where ID = " + offerSheetID;
                        if (adb.SQLExecute(sql))
                        {
                            main_form.TSMItem_offer_aduit_Refresh();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请确定付款方式！", "警告");
                }
            }
            else
            {
                MessageBox.Show("该报价单没有对应的货物列表，无法通过审核！", "警告");
            }
        }

        /// <summary>
        /// 对应报价单审核不通过
        /// </summary>
        /// <param name="offerSheetID">报价单ID</param>
        private void FailOfferSheet(string offerSheetID)
        {
            string sql = "update OSM_OFFER_SHEET set OFFERSHEET_STATE = '3' where ID = " + offerSheetID;

            AccessDB adb = new AccessDB();
            if (adb.SQLExecute(sql))
            {
                main_form.TSMItem_offer_aduit_Refresh();
            }
        }

        /// <summary>
        /// 查看报价单详情
        /// </summary>
        /// <param name="offersheet_code"></param>
        private void viewOfferSheet(string offersheet_id)
        {
            string sql = "select * from OSM_OFFER_SHEET ";
            sql += "where ID = " + offersheet_id + " ";

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(sql);
            Hashtable hashtable = new Hashtable();

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                hashtable.Add("ID", dr["ID"]);
                hashtable.Add("OFFERSHEET_CODE", dr["OFFERSHEET_CODE"]);
                hashtable.Add("GMF_ID", dr["GMF_ID"]);
                hashtable.Add("BJF_ID", dr["BJF_ID"]);
                hashtable.Add("OFFERSHEET_TYPE", dr["OFFERSHEET_TYPE"]);
                hashtable.Add("OFFERSHEET_DATE", dr["OFFERSHEET_DATE"]);
                hashtable.Add("OFFERSHEET_STATE", dr["OFFERSHEET_STATE"]);
                hashtable.Add("OFFERSHEET_REGION", dr["OFFERSHEET_REGION"]);
                hashtable.Add("CONFIRM_DATE", dr["CONFIRM_DATE"]);
            }

            FormOSM_Offers_Add form_add_offers = new FormOSM_Offers_Add();
            form_add_offers.dataGridView_viewBtn_click_reaction(hashtable);
            form_add_offers.setViewState(1);
            form_add_offers.StartPosition = FormStartPosition.CenterParent;
            form_add_offers.ShowDialog();
        }
    }
}
