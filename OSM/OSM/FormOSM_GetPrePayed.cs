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
    public partial class FormOSM_GetPrePayed : Form
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
        public FormOSM_GetPrePayed()
        {
            InitializeComponent();
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
        /// 设置参数
        /// </summary>
        /// <param name="oid">订单ID</param>
        /// <param name="pid">付款单ID</param>
        /// <param name="rp">需付款</param>
        public void setPrePayParam(string oid, string pid, string rp)
        {
            p_id = pid;
            order_id = oid;
            need_to_pay = rp;
            textBox_RequirePayment.Text = rp;
            double prePay = double.Parse(rp) * 0.1;
            textBox_PrePayment.Text = prePay.ToString();
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
            double pre_pay = double.Parse(textBox_PrePayment.Text);
            double actual_pay = double.Parse(textBox_Payment.Text);

            if (actual_pay - pre_pay >= 0)
            {
                prePayOrder(pre_pay, actual_pay);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("实际付款小于需预付款金额，无法执行付款！", "错误");
            }
        }

        /// <summary>
        /// 付款操作
        /// </summary>
        /// <param name="pre_pay">预付款金额</param>
        /// <param name="actual_pay">实际付款</param>
        private void prePayOrder(double pre_pay, double actual_pay)
        {
            AccessDB adb = new AccessDB();

            string PaySheetUpdateSQL = "update OSM_PAYMENTREMINDER_SHEET set ACHIEVE_DATE = #" + DateTime.Now.ToString("yyyy-MM-dd") + "# where ID = " + p_id;
            string OrderSheetUpdateSQL = "update OSM_ORDER_SHEET set PAY_STATE = '3',PRE_PAYMENT = " + pre_pay + ",ALREADY_PAYMENT = " + actual_pay + " where ID = " + order_id;

            if (adb.SQLExecute(OrderSheetUpdateSQL))
            {
                if (adb.SQLExecute(PaySheetUpdateSQL))
                {
                    MessageBox.Show("预付部分款成功", "消息");
                }
            }
        }

        /// <summary>
        /// 预付款输入控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_PrePayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入双精度数字
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 46) && (e.KeyChar != 8))
                e.Handled = true;
        }

        /// <summary>
        /// 实际付款输入控制
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
