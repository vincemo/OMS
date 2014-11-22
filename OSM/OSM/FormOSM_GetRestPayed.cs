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
    public partial class FormOSM_GetRestPayed : Form
    {
        //付款单ID
        private string p_id;
        //订单ID
        private string order_id;
        //需付款
        private string need_to_pay;
        //需预付款
        private string need_to_pre_pay;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_GetRestPayed()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="oid">订单ID</param>
        /// <param name="pid">付款单ID</param>
        /// <param name="requirepay">需付款总额</param>
        /// <param name="prepay">已付款额</param>
        public void setRestPayedParam(string oid, string pid, string requirepay, string alreadypay)
        {
            order_id = oid;
            p_id = pid;
            need_to_pay = requirepay;
            need_to_pre_pay = alreadypay;
            double restpay = double.Parse(requirepay) - double.Parse(alreadypay);
            textBox_RequirePayment.Text = requirepay;
            textBox_PrePayment.Text = alreadypay;
            textBox_RestPayment.Text = restpay.ToString();
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

            double alreadyPay = double.Parse(textBox_PrePayment.Text);
            double restPay = double.Parse(textBox_RestPayment.Text);
            double actualPay = double.Parse(textBox_Payment.Text);

            if (actualPay - restPay >= 0)
            {
                restPayOrder(alreadyPay, actualPay);
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("实际付款小于需付剩余款金额，无法执行付款！", "错误");
            }
        }

        /// <summary>
        /// 付款操作
        /// </summary>
        /// <param name="rest_pay">预付款阶段已付款</param>
        /// <param name="actual_pay">实际付款</param>
        private void restPayOrder(double already_pay, double actual_pay)
        {
            AccessDB adb = new AccessDB();

            double payment = already_pay + actual_pay;
            string PaySheetUpdateSQL = "update OSM_PAYMENTREMINDER_SHEET set ACHIEVE_DATE = #" + DateTime.Now.ToString("yyyy-MM-dd") + "# where ID = " + p_id;
            string OrderSheetUpdateSQL = "update OSM_ORDER_SHEET set PAY_STATE = '2',ALREADY_PAYMENT = " + payment + " where ID = " + order_id;

            if (adb.SQLExecute(OrderSheetUpdateSQL))
            {
                if (adb.SQLExecute(PaySheetUpdateSQL))
                {
                    MessageBox.Show("已付清全款！", "消息");
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
