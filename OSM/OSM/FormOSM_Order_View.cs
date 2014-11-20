using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using OSM.DBClass;

namespace OSM
{
    public partial class FormOSM_Order_View : Form
    {
        //订单ID
        private string orderID = "";

        //窗口state 
        private int viewState = 0;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_Order_View()
        {
            InitializeComponent();

            string whereString = "where PID = 2";
            SJZDController.setZD_ComboBox(whereString, comboBox_OrderState);

            whereString = "where PID = 20";
            SJZDController.setZD_ComboBox(whereString, comboBox_PayMode);

            whereString = "where PID = 24";
            SJZDController.setZD_ComboBox(whereString, comboBox_PayState);

            textBox_OfferSheetCode.ReadOnly = true;
            label_PrePayment.Visible = false;
            textBox_PrePayment.Visible = false;
        }

        /// <summary>
        /// 设置订单ID
        /// </summary>
        /// <param name="order_id"></param>
        public void setOrderID(string order_id)
        {
            orderID = order_id;
        }

        /// <summary>
        /// 设置窗口状态
        /// </summary>
        /// <param name="vstate">状态值:整型</param>
        public void setViewState(int vstate)
        {
            viewState = vstate;
        }
        /// <summary>
        /// 打开订单窗口可触发动作，显示读取到的数据
        /// </summary>
        /// <param name="ht"></param>
        public void viewOrderSheet(Hashtable ht)
        {
            if (viewState == 0)
            {
                textBox_AlreadyPayment.ReadOnly = true;
                textBox_PrePayment.ReadOnly = true;
                textBox_RequirePayment.ReadOnly = true;
                //textBox_AlreadyPayment.Enabled = false;
                //textBox_PrePayment.Enabled = false;
                //textBox_RequirePayment.Enabled = false;
                comboBox_OrderState.Enabled = false;
                comboBox_PayMode.Enabled = false;
                comboBox_PayState.Enabled = false;
                dateTimePicker_OrderDate.Enabled = false;
            }

            if (viewState == 1)
            {
                textBox_RequirePayment.ReadOnly = true;
                comboBox_OrderState.Enabled = false;
                comboBox_PayState.Enabled = false;
                dateTimePicker_OrderDate.Enabled = false;
            }

            textBox_OfferSheetCode.Text = ht["OFFERSHEET_CODE"].ToString();
            textBox_AlreadyPayment.Text = ht["ALREADY_PAYMENT"].ToString();
            textBox_PrePayment.Text = ht["PRE_PAYMENT"].ToString();
            textBox_RequirePayment.Text = ht["REQUIRE_PAYMENT"].ToString();
            dateTimePicker_OrderDate.Text = ((DateTime)ht["ORDER_DATE"]).ToString("yyyy-MM-dd");
            
            for (int i = 0; i < comboBox_OrderState.Items.Count; i++)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_OrderState.Items[i];
                if (ht["ORDER_STATE"].ToString() == kv.Key)
                {
                    comboBox_OrderState.SelectedIndex = i;
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(ht["PAY_MODE"].ToString()))
            {
                comboBox_PayMode.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < comboBox_PayMode.Items.Count; i++)
                {
                    KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_PayMode.Items[i];
                    if (ht["PAY_MODE"].ToString() == kv.Key)
                    {
                        comboBox_PayMode.SelectedIndex = i;
                        break;
                    }
                }
            }
            

            for (int i = 0; i < comboBox_PayState.Items.Count; i++)
            {
                KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_PayState.Items[i];
                if (ht["PAY_STATE"].ToString() == kv.Key)
                {
                    comboBox_PayState.SelectedIndex = i;
                    break;
                }
            }

            string sql = "select * from OSM_HW_LIST_V where OFFERSHEET_CODE = '" + ht["OFFERSHEET_CODE"].ToString() + "'";
            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(sql);
            dataGridView_HW.AutoGenerateColumns = false;
            dataGridView_HW.DataSource = dt;
        }

        /// <summary>
        /// 关闭按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 付款方式选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_PayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_PayMode.SelectedItem == null)
            {
                return;
            }

            KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_PayMode.SelectedItem;
            if (kv.Key == "3")
            {
                label_PrePayment.Visible = true;
                textBox_PrePayment.Visible = true;
            }
            else
            {
                label_PrePayment.Visible = false;
                textBox_PrePayment.Visible = false;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (viewState == 0)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
