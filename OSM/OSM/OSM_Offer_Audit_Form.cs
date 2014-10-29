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
