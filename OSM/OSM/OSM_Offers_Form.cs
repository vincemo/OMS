using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DBClass;
using System.Collections;

namespace OSM
{
    public partial class OSM_Offers_Form : UserControl
    {
        //父对象
        FormOSM_Main main_form;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_Offers_Form()
        {
            InitializeComponent();

            dateTimePicker_OfferSheet.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //查询报价单视图返回结果
            queryFromOfferSheetV(dataGridView_OfferSheet);
            //设置页码控件控制的datagridview
            //osM_Pager_offerSheet.setDataGridView(dataGridView_OfferSheet);

            string whereString = "where PID = 1";
            SJZDController.setZD_ComboBox(whereString, comboBox_OfferSheet);
        }

        /// <summary>
        /// 设置MainForm对象
        /// </summary>
        /// <param name="formOSM_main"></param>
        public void setMainForm(FormOSM_Main formOSM_main)
        {
            main_form = formOSM_main;
        }

        /// <summary>
        /// SQL带where子句查询报价单视图
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="whereString"></param>
        private void queryFromOfferSheetV(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_OFFER_SHEET_V ";
            //sql += whereString;

            OSM_Pager_offerSheet.setDataGridView(dgv);
            OSM_Pager_offerSheet.setQueryString(sql);
            OSM_Pager_offerSheet.setKey("OFFERSHEET_CODE");
            OSM_Pager_offerSheet.setWhereString(whereString);
            OSM_Pager_offerSheet.setOrderString("OFFERSHEET_CODE DESC");
            OSM_Pager_offerSheet.setPageIndex(1);
            OSM_Pager_offerSheet.setPageSize(10);
            OSM_Pager_offerSheet.refreshDataGirdViewBySQL(dgv);

            //AccessDB adb = new AccessDB();
            //DataSet ds = adb.SQLQuery(sql);
            //dgv.AutoGenerateColumns = false;
            //dgv.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Query_Click(object sender, EventArgs e)
        {
            string whereString = "where 1=1 ";
            
            if (!string.IsNullOrWhiteSpace(dateTimePicker_OfferSheet.Text))
            {
                whereString += " and OFFERSHEET_DATE = #" + dateTimePicker_OfferSheet.Text + "#";
            }

            if (comboBox_OfferSheet.SelectedIndex != -1)
            {
                KeyValuePair<string,string> kv = (KeyValuePair<string,string>)comboBox_OfferSheet.SelectedItem;
                string offersheet_state = kv.Key;
                whereString += " and OFFERSHEET_STATE = '" + offersheet_state + "'";
            }

            queryFromOfferSheetV(dataGridView_OfferSheet, whereString);
        }

        /// <summary>
        /// 重置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            dateTimePicker_OfferSheet.CustomFormat = " ";
            comboBox_OfferSheet.SelectedIndex = -1;
        }

        /// <summary>
        /// 日期控件下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_OfferSheet_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_OfferSheet.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// dataGridView单元按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_OfferSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_OfferSheet.Columns[e.ColumnIndex].Name == "viewBtn")
            {
                //MessageBox.Show(dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString());
                string offersheet_code = dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();
                viewOfferSheet(offersheet_code);
            }

            if (dataGridView_OfferSheet.Columns[e.ColumnIndex].Name == "editBtn")
            {
                //MessageBox.Show(dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString());
                string offersheet_code = dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();
                editOfferSheet(offersheet_code);
            }


            if (dataGridView_OfferSheet.Columns[e.ColumnIndex].Name == "delBtn")
            {
                //MessageBox.Show(dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString());
                string offersheet_code = dataGridView_OfferSheet.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();
                DialogResult result =  MessageBox.Show("确认删除该条记录?", "消息", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(dataGridView_OfferSheet.Rows[e.RowIndex].Cells["ORDERSHEET_GEN"].Value.ToString()))
                    {
                        MessageBox.Show("该记录已生成订单,无法删除!", "警告");
                    }
                    else
                    {
                        delOfferSheet(offersheet_code);
                    }
                }
            }
        }

        /// <summary>
        /// 编辑报价单按钮
        /// </summary>
        /// <param name="offersheet_code"></param>
        private void editOfferSheet(string offersheet_code)
        {
            string sql = "select * from OSM_OFFER_SHEET ";
            sql += "where OFFERSHEET_CODE = '" + offersheet_code + "'";

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
            form_add_offers.dataGridView_editBtn_click_reaction(hashtable);
            form_add_offers.setMainForm(main_form);
            form_add_offers.setViewState(2);
            form_add_offers.ShowDialog();
        }

        /// <summary>
        /// 查看报价单按钮
        /// </summary>
        /// <param name="offersheet_code"></param>
        private void viewOfferSheet(string offersheet_code)
        {
            string sql = "select * from OSM_OFFER_SHEET ";
            sql += "where OFFERSHEET_CODE = '" + offersheet_code + "'";

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
            form_add_offers.setMainForm(main_form);
            form_add_offers.setViewState(1);
            form_add_offers.ShowDialog();
        }

        /// <summary>
        /// 删除报价单按钮
        /// </summary>
        /// <param name="offersheet_code"></param>
        private void delOfferSheet(string offersheet_code)
        {
            AccessDB adb = new AccessDB();

            string whereString = " where OFFERSHEET_CODE = '" + offersheet_code + "'";

            if (adb.SQLTableDelete("OSM_HW", whereString) >= 0)
            {
                if (adb.SQLTableDelete("OSM_OFFER_SHEET", whereString) == 1)
                {
                    MessageBox.Show("删除成功！", "消息");
                    queryFromOfferSheetV(dataGridView_OfferSheet);
                }
            }
        }
    }
}
