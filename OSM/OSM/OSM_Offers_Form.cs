using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DBClass;

namespace OSM
{
    public partial class OSM_Offers_Form : UserControl
    {
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

            //初始化状态下拉列表
            Dictionary<string, string> osDic = new Dictionary<string, string>();
            osDic.Add("1", "待审核");
            osDic.Add("2", "需要修改");
            osDic.Add("3", "成交");
            osDic.Add("4", "已关闭");

            BindingSource bs = new BindingSource();
            bs.DataSource = osDic;
            comboBox_OfferSheet.DataSource = bs;
            comboBox_OfferSheet.ValueMember = "Key";
            comboBox_OfferSheet.DisplayMember = "Value";
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
            OSM_Pager_offerSheet.setPageSize(1);
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

        private void dateTimePicker_OfferSheet_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_OfferSheet.CustomFormat = "yyyy-MM-dd";
        }
    }
}
