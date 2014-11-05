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
    public partial class OSM_Purchase_Complete : UserControl
    {
        //父窗口
        private FormOSM_Main main_form;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_Purchase_Complete()
        {
            InitializeComponent();

            dateTimePicker_InitDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string whereString = "where PID = 30";
            SJZDController.setZD_ComboBox(whereString, comboBox_PurchaseState);

            for (int i = 0; i < comboBox_PurchaseState.Items.Count; i++)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_PurchaseState.Items[i];
                if (kv.Key == "1")
                {
                    comboBox_PurchaseState.SelectedIndex = i;
                    comboBox_PurchaseState.Enabled = false;
                    break;
                }
            }

                whereString = "where PID = 43";
            SJZDController.setZD_ComboBox(whereString, comboBox_HWType);

            //查询未到货采购单视图
            queryFromPurchaseSheetV(dataGridView_Purchase_Complete, " where PURCHASE_STATE = '1' ");
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
        private void queryFromPurchaseSheetV(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_PURCHASE_SHEET_V ";

            OSM_Pager_Purchase_Complete.setDataGridView(dataGridView_Purchase_Complete);
            OSM_Pager_Purchase_Complete.setQueryString(sql);
            OSM_Pager_Purchase_Complete.setKey("ID");
            OSM_Pager_Purchase_Complete.setWhereString(whereString);
            OSM_Pager_Purchase_Complete.setOrderString("ID DESC");
            OSM_Pager_Purchase_Complete.setPageIndex(1);
            OSM_Pager_Purchase_Complete.setPageSize(10);
            OSM_Pager_Purchase_Complete.refreshDataGirdViewBySQL(dataGridView_Purchase_Complete);
        }

        /// <summary>
        /// 重置按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            dateTimePicker_InitDate.CustomFormat = " ";
            comboBox_HWType.SelectedIndex = -1;
            //comboBox_PurchaseState.SelectedIndex = -1;
        }

        /// <summary>
        /// 日期控件下拉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_InitDate_DropDown(object sender, EventArgs e)
        {
            dateTimePicker_InitDate.CustomFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Query_Click(object sender, EventArgs e)
        {
            string whereString = " where 1 = 1 ";

            if (!string.IsNullOrWhiteSpace(dateTimePicker_InitDate.Text))
            {
                whereString += " and INIT_DATE = #" + dateTimePicker_InitDate.Text + "# ";
            }

            if (comboBox_HWType.SelectedIndex != -1)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_HWType.SelectedItem;
                whereString += " and HW_TYPE = '" + kv.Key + "'";
            }

            queryFromPurchaseSheetV(dataGridView_Purchase_Complete, whereString);
        }

        /// <summary>
        /// DataGridView单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Purchase_Complete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Purchase_Complete.Columns[e.ColumnIndex].Name == "viewOrderBtn")
            {
                string order_id = dataGridView_Purchase_Complete.Rows[e.RowIndex].Cells["ORDER_ID"].Value.ToString();

                viewOrderSheet(order_id);
            }

            if (dataGridView_Purchase_Complete.Columns[e.ColumnIndex].Name == "confirmBtn")
            {
                string purchase_id = dataGridView_Purchase_Complete.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                confirmPurchase(purchase_id);
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
        /// 采购到货确认
        /// </summary>
        /// <param name="purchase_id">采购记录编号</param>
        private void confirmPurchase(string purchase_id)
        {
            //TO-DO:
            MessageBox.Show(purchase_id);
        }
    }
}
