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
    public partial class OSM_Orders_Form : UserControl
    {
        //父窗口
        private FormOSM_Main main_form;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_Orders_Form()
        {
            InitializeComponent();

            dateTimePicker_OrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string whereString = "where PID = 2 ";
            SJZDController.setZD_ComboBox(whereString, comboBox_OrderState);

            //查询订单视图返回结果
            queryFromOrderSheetV(dataGridView_Order);
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
            comboBox_OrderState.SelectedIndex = -1;
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
            string whereString = "where 1=1 ";

            if (!string.IsNullOrWhiteSpace(dateTimePicker_OrderDate.Text))
            {
                whereString += " and ORDER_DATE = #" + dateTimePicker_OrderDate.Text + "# ";
            }

            if (comboBox_OrderState.SelectedIndex != -1)
            {
                KeyValuePair<string,string> kv = (KeyValuePair<string,string>)comboBox_OrderState.SelectedItem;
                whereString += " and ORDER_STATE = '" + kv.Key + "'";
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
                //MessageBox.Show(order_id);
                //FormOSM_Order_View orderView = new FormOSM_Order_View();
                //orderView.ShowDialog();
                viewOrderSheet(order_id);
            }

            if (dataGridView_Order.Columns[e.ColumnIndex].Name == "viewOfferBtn")
            {
                string offersheet_code = dataGridView_Order.Rows[e.RowIndex].Cells["OFFERSHEET_CODE"].Value.ToString();
                //MessageBox.Show(offersheet_code);
                viewOfferSheet(offersheet_code);
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
                hashtable.Add("ID", dr.ItemArray[0]);
                hashtable.Add("OFFERSHEET_ID", dr.ItemArray[1]);
                hashtable.Add("ORDER_STATE", dr.ItemArray[2]);
                hashtable.Add("ORDER_DATE", dr.ItemArray[3]);
                hashtable.Add("PAY_MODE", dr.ItemArray[4]);
                hashtable.Add("PAY_STATE", dr.ItemArray[5]);
                hashtable.Add("ALREADY_PAYMENT", dr.ItemArray[6]);
                hashtable.Add("PRE_PAYMENT", dr.ItemArray[7]);
                hashtable.Add("REQUIRE_PAYMENT", dr.ItemArray[8]);
                hashtable.Add("OFFERSHEET_CODE", dr.ItemArray[9]);
            }
            
            FormOSM_Order_View orderView = new FormOSM_Order_View();
            orderView.setOrderID(order_id);
            //设置窗口状态为查看
            orderView.setViewState(0);
            orderView.viewOrderSheet(hashtable);
            orderView.ShowDialog();
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
    }
}
