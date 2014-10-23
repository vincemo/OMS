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

            Dictionary<string, string> typeDict = new Dictionary<string, string>();
            typeDict.Add("1", "类型1");
            typeDict.Add("2", "类型2");
            typeDict.Add("3", "类型3");
            typeDict.Add("4", "类型4");

            BindingSource bs = new BindingSource();
            bs.DataSource = typeDict;
            comboBox_OfferSheet_Audit.DataSource = bs;
            comboBox_OfferSheet_Audit.ValueMember = "Key";
            comboBox_OfferSheet_Audit.DisplayMember = "Value";

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
                hashtable.Add("ID", dr.ItemArray[0]);
                hashtable.Add("OFFERSHEET_CODE", dr.ItemArray[1]);
                hashtable.Add("GMF_ID", dr.ItemArray[2]);
                hashtable.Add("BJF_ID", dr.ItemArray[3]);
                hashtable.Add("OFFERSHEET_TYPE", dr.ItemArray[4]);
                hashtable.Add("OFFERSHEET_DATE", dr.ItemArray[5]);
                hashtable.Add("OFFERSHEET_STATE", dr.ItemArray[6]);
            }

            FormOSM_Offers_Add form_add_offers = new FormOSM_Offers_Add();
            form_add_offers.dataGridView_viewBtn_click_reaction(hashtable);
            form_add_offers.setViewState(1);
            form_add_offers.ShowDialog();
        }
    }
}
