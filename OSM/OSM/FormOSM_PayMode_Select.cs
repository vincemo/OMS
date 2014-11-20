using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSM
{
    public partial class FormOSM_PayMode_Select : Form
    {
        //父窗口
        OSM_Offer_Audit_Form offer_aduit;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_PayMode_Select()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (radioButton_firstPay.Checked)
            {
                offer_aduit.setPayMode("1");
                this.Close();
                this.Dispose();
            }
            else if (radioButton_lastPay.Checked)
            {
                offer_aduit.setPayMode("2");
                this.Close();
                this.Dispose();
            }
            else if (radioButton_prePay.Checked)
            {
                offer_aduit.setPayMode("3");
                this.Close();
                this.Dispose();
            }
        }

        /// <summary>
        /// 设置父窗口
        /// </summary>
        /// <param name="oaf"></param>
        public void setOfferForm(OSM_Offer_Audit_Form oaf)
        {
            offer_aduit = oaf;
        }
    }
}
