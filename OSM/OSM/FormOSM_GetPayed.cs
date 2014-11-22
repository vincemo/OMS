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
    public partial class FormOSM_GetPayed : Form
    {
        //付款单ID
        private string p_id;
        //订单ID
        private string order_id;
        //需付款
        private string need_to_pay;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_GetPayed()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="pid">付款单ID</param>
        /// <param name="oid">订单ID</param>
        /// <param name="rp">需付款</param>
        public void setRequirePaymentParam(string oid, string pid, string rp)
        {
            p_id = pid;
            order_id = oid;
            need_to_pay = rp;
            textBox_RequirePayment.Text = rp;
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Payment.Text))
            {
                MessageBox.Show("付款金额为空,请重新输入！", "警告");
                return;
            }

            double need_pay = double.Parse(need_to_pay);
            double actual_pay = double.Parse(textBox_Payment.Text);

            if (actual_pay - need_pay >= 0)
            {
                payOrder(actual_pay);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("实际付款小于需付款金额，无法执行付款！", "错误");
            }
        }

        /// <summary>
        /// 对应订单付全款
        /// </summary>
        /// <param name="actual_pay"></param>
        private void payOrder(double actual_pay)
        {
            AccessDB adb = new AccessDB();

            string PaySheetUpdateSQL = "update OSM_PAYMENTREMINDER_SHEET set ACHIEVE_DATE = #" + DateTime.Now.ToString("yyyy-MM-dd") + "# where ID = " + p_id;
            string OrderSheetUpdateSQL = "update OSM_ORDER_SHEET set PAY_STATE = '2',ALREADY_PAYMENT = " + actual_pay + " where ID = " + order_id;

            if (adb.SQLExecute(OrderSheetUpdateSQL))
            {
                if (adb.SQLExecute(PaySheetUpdateSQL))
                {
                    MessageBox.Show("付款成功", "消息");
                }
            }
        }

        /// <summary>
        /// 输入控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入双精度数字
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 46) && (e.KeyChar != 8))
                e.Handled = true;
        }
    }
}
