using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DBClass;

namespace OSM
{
    public partial class FormOSM_Delivery_DatePicker : Form
    {
        //初始化状态 0发货时间 1到货时间
        private int state = 0;
        //发货单编号
        private int deliverySheetID;
        //订单编号
        private int orderID;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_Delivery_DatePicker()
        {
            InitializeComponent();
            dateTimePicker_Delivery.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 设置状态为发货时间还是到货时间
        /// </summary>
        /// <param name="st"></param>
        public void setState(int st)
        {
            state = st;
        }

        /// <summary>
        /// 设置发货单编号
        /// </summary>
        /// <param name="id"></param>
        public void setDeliverySheetID(int d_id)
        {
            deliverySheetID = d_id;
        }

        /// <summary>
        /// 设置订单编号
        /// </summary>
        /// <param name="id"></param>
        public void setOrderID(int o_id)
        {
            orderID = o_id;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            AccessDB adb = new AccessDB();

            string updateSQL = "update OSM_DILIVERY_SHEET set ";
            string orderUpdateSQL = "update OSM_ORDER_SHEET set ORDER_STATE = ";

            if (state == 0)
            {
                //发货时间
                updateSQL += " DILIVERY_DATE = #" + dateTimePicker_Delivery.Text + "#,DILIVERY_STATE='2' where ID = " + deliverySheetID;
                orderUpdateSQL += " '5' where ID = " + orderID;
            }
            else
            {
                //到货时间
                updateSQL += " ARRIVE_DATE = #" + dateTimePicker_Delivery.Text + "#,DILIVERY_STATE='3' where ID = " + deliverySheetID;
                orderUpdateSQL += " '6' where ID = " + orderID;
            }

            if (adb.SQLExecute(updateSQL))
            {
                if (adb.SQLExecute(orderUpdateSQL))
                {
                    MessageBox.Show("确认成功！", "消息");
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("更新订单列表出错！", "错误");
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("更新发货单列表出错！", "错误");
                this.Close();
                this.Dispose();
            }
        }
    }
}
