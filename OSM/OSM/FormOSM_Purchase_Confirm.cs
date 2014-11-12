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
    public partial class FormOSM_Purchase_Confirm : Form
    {
        //父窗口
        private OSM_Purchase_Complete fWindow;
        //采购单记录ID
        private string purchase_id;
        //库存产品ID
        private string product_id;
        //订单ID
        private string order_id;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_Purchase_Confirm()
        {
            InitializeComponent();

            string where = "where PID = 43";
            SJZDController.setZD_ComboBox(where, comboBox_HWType);
        }

        /// <summary>
        /// 设置父窗口
        /// </summary>
        /// <param name="opc"></param>
        public void Set_fWindow(OSM_Purchase_Complete opc)
        {
            fWindow = opc;
        }

        /// <summary>
        /// 查看采购记录数据接收接口
        /// </summary>
        /// <param name="ht"></param>
        public void viewProduct(Hashtable ht)
        {
            purchase_id = ht["ID"].ToString();
            product_id = ht["PRODUCT_ID"].ToString();
            order_id = ht["ORDER_ID"].ToString();

            textBox_HWCode.Text = ht["HW_CODE"].ToString();
            textBox_HWName.Text = ht["HW_NAME"].ToString();
            textBox_PurchaseNumber.Text = ht["PURCHASE_NUMBER"].ToString();
            textBox_HWNumber.Text = ht["PURCHASE_NUMBER"].ToString();

            for (int i = 0; i < comboBox_HWType.Items.Count; i++)
            {
                KeyValuePair<string,string> kv  = (KeyValuePair<string,string>)comboBox_HWType.Items[i];
                if (kv.Key == ht["HW_TYPE"].ToString())
                {
                    comboBox_HWType.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 到货确认按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(purchase_id) && !string.IsNullOrWhiteSpace(product_id) && !string.IsNullOrWhiteSpace(order_id))
            {
                if (string.IsNullOrWhiteSpace(textBox_HWNumber.Text))
                {
                    MessageBox.Show("请填写到货数量,谢谢！", "警告");
                    return;
                }

                int number_want = int.Parse(textBox_PurchaseNumber.Text);
                int number_real = int.Parse(textBox_HWNumber.Text);

                if (number_want > number_real)
                {
                    //需采购数量大于到货数量，不能确认
                    MessageBox.Show("到货数量小于需求数量，无法确认到货！", "警告");
                    return;
                }
                else
                {
                    //到货数量大于等于需采购数量,改变采购记录状态，改变库存数量
                    AccessDB adb = new AccessDB();
                    string sql = "select HW_NUMBER,REAL_NUMBER from OSM_STORAGE where ID = " + product_id;
                    DataTable dt = adb.SQLTableQuery(sql);
                    DataRow dr = dt.Rows[0];
                    int hw_number = int.Parse(dr["HW_NUMBER"].ToString());
                    int real_number = int.Parse(dr["REAL_NUMBER"].ToString());
                    real_number += number_real;
                    hw_number += number_real - number_want;

                    string updateSQL = "update OSM_STORAGE set HW_NUMBER = " + hw_number + ", REAL_NUMBER = " + real_number + " where ID = " + product_id;

                    if (adb.SQLExecute(updateSQL))
                    {
                        updateSQL = "update OSM_PURCHASE_SHEET set PURCHASE_STATE = '2' where ID = " + purchase_id;
                        if (adb.SQLExecute(updateSQL))
                        {
                            MessageBox.Show("到货确认成功！", "消息");
                            fWindow.refresh_dataGridView();

                            checkOrder(order_id);
                            
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("UNEXCEPTED ERROR!", "ERROR");
            }
        }

        /// <summary>
        /// 数字校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_HWNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入整数数字
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) 
                e.Handled = true;
        }

        /// <summary>
        /// 检查订单是否可以发货
        /// </summary>
        /// <param name="order_id"></param>
        private void checkOrder(string order_id)
        {
            bool flag = true;
            AccessDB adb = new AccessDB();

            string sql = "select PURCHASE_STATE from OSM_PURCHASE_SHEET where ORDER_ID = " + order_id;

            DataTable dt = adb.SQLTableQuery(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if ("1" == dr["PURCHASE_STATE"].ToString())
                {
                    flag = false;
                }
            }

            if (flag)
            {
                string updateSQL = "update OSM_ORDER_SHEET set ORDER_STATE = '3' where ID = " + order_id;
                if (adb.SQLExecute(updateSQL))
                {
                    string insertSQL = "insert into OSM_DILIVERY_SHEET(ORDER_ID,DILIVERY_STATE) values(" + order_id + ",'1')";
                    if (adb.SQLExecute(insertSQL))
                    {
                        MessageBox.Show("对应订单已可以发货,已生成发货单！", "消息");
                    }
                }
            }
        }
    }
}
