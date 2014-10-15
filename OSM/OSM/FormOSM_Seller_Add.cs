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
    public partial class FormOSM_Seller_Add : Form
    {
        private Seller seller;
        private FormOSM_Offers_Add offerForm;

        public FormOSM_Seller_Add()
        {
            InitializeComponent();
            seller = new Seller();
            //offerForm = this.Parent as FormOSM_Offers_Add;
            //textBox_COM_NAME_SELLER.Validating += new CancelEventHandler(textBox_notNull_Validating);
        }

        public void setOfferForm(FormOSM_Offers_Add parentOfferForm)
        {
            offerForm = parentOfferForm;
        }
        ///<summary>
        ///功能不输入则光标不会离开目标textBox
        ///<para>示例:textBox.Validating += new CancelEventHandler(textBox_notNull_Validating);</para>
        ///</summary>
        private void textBox_notNull_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            e.Cancel = string.IsNullOrEmpty(tb.Text);
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //bool flag;
            //flag = (textBox_COM_NAME_SELLER.Text == "") ? false : true;
            if (string.IsNullOrEmpty(textBox_COM_NAME_SELLER.Text))
            {
                MessageBox.Show("名称不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_ADDR_SELLER.Text))
            {
                MessageBox.Show("地址不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_CONTACT_SELLER.Text))
            {
                MessageBox.Show("联系人不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_PHONE_SELLER.Text))
            {
                MessageBox.Show("联系电话不应为空！", "警告");
                return;
            }

            createSeller(seller);
            
            if (addSeller(seller))
            {
                offerForm.refresh_seller_comboBox();
                this.Close();
            }
        }

        private void createSeller(Seller seller)
        {
            seller.setCOM_NAME(textBox_COM_NAME_SELLER.Text);
            seller.setADDR(textBox_ADDR_SELLER.Text);
            seller.setCONTACT(textBox_CONTACT_SELLER.Text);
            seller.setPHONE(textBox_PHONE_SELLER.Text);
            seller.setZIP_CODE(textBox_ZIPCODE_SELLER.Text);
            seller.setFAX(textBox_FAX_SELLER.Text);
            seller.setEMAIL(textBox_EMAIL_SELLER.Text);
            seller.setCOMMENT(textBox_COMMENT_SELLER.Text);
        }

        private bool addSeller(Seller seller)
        {
            string sql = "insert into OSM_BJF(COM_NAME,ADDR,CONTACT,PHONE,ZIP_CODE,FAX,EMAIL,COMMENT) ";
            sql += " values('" + seller.getCOM_NAME() + "','" + seller.getADDR() + "','";
            sql += seller.getCONTACT() + "','" + seller.getPHONE() + "','" + seller.getZIP_CODE();
            sql += "','" + seller.getFAX() + "','" + seller.getEMAIL() + "','" + seller.getCOMMENT() + "')";
            
            AccessDB adb = new AccessDB();
            bool isExecuteSucc = adb.SQLExecute(adb.getConnection(), sql);
            if (isExecuteSucc)
            {
                MessageBox.Show("添加成功！", "消息");
            }
            else
            {
                MessageBox.Show("添加失败！", "消息");
            }
            return isExecuteSucc;
        }
    }
}
