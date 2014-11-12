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
    public partial class OSM_DeliverySheet_Form : UserControl
    {
        //父窗口
        private FormOSM_Main main_form;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_DeliverySheet_Form()
        {
            InitializeComponent();

            dateTimePicker_DeliverDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dateTimePicker_ArrDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string whereString = "where PID = 53 order by ID";
            SJZDController.setZD_ComboBox(whereString, comboBox_DeliveryState);

            queryFromDiliverySheetV(dataGridView_Delivery);
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
        /// 查询发货单视图返回结果给DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="whereString"></param>
        private void queryFromDiliverySheetV(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_DILIVERY_SHEET_V ";

            OSM_Pager_Delivery.setDataGridView(dataGridView_Delivery);
            OSM_Pager_Delivery.setQueryString(sql);
            OSM_Pager_Delivery.setKey("ID");
            OSM_Pager_Delivery.setWhereString(whereString);
            OSM_Pager_Delivery.setOrderString("ID DESC");
            OSM_Pager_Delivery.setPageIndex(1);
            OSM_Pager_Delivery.setPageSize(10);
            OSM_Pager_Delivery.refreshDataGirdViewBySQL(dataGridView_Delivery);
        }

        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_DeliveryState.SelectedIndex = -1;
            dateTimePicker_DeliverDate.CustomFormat = " ";
            dateTimePicker_ArrDate.CustomFormat = " ";
        }
        /// <summary>
        /// 发货日期下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_DeliverDate_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_DeliverDate.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// 到货日期下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_ArrDate_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_ArrDate.CustomFormat = "yyyy-MM-dd";
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            string whereString = "where 1=1 ";

            if (!string.IsNullOrWhiteSpace(dateTimePicker_DeliverDate.Text))
            {
                whereString += " and DILIVERY_DATE = #" + dateTimePicker_DeliverDate.Text + "# ";
            }

            if (!string.IsNullOrWhiteSpace(dateTimePicker_ArrDate.Text))
            {
                whereString += " and ARRIVE_DATE = #" + dateTimePicker_ArrDate.Text + "# ";
            }

            if (comboBox_DeliveryState.SelectedIndex != -1)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_DeliveryState.SelectedItem;
                whereString += " and DILIVERY_STATE = '" + kv.Key + "' ";
            }

            queryFromDiliverySheetV(dataGridView_Delivery, whereString);
        }

        /// <summary>
        /// DataGridView单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Delivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Delivery.Columns[e.ColumnIndex].Name == "viewOrderBtn")
            {
                string order_id = dataGridView_Delivery.Rows[e.RowIndex].Cells["ORDER_ID"].Value.ToString();

                viewOrderSheet(order_id);
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
    }
}
