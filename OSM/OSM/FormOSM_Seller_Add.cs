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
        //报价方对象
        private Seller seller;
        //父窗口对象
        private FormOSM_Offers_Add offerForm;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_Seller_Add()
        {
            InitializeComponent();
            seller = new Seller();
        }

        /// <summary>
        /// 获取父窗口对象
        /// </summary>
        /// <param name="parentOfferForm"></param>
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

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// 输入窗口内容构造报价方对象
        /// </summary>
        /// <param name="seller"></param>
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

        /// <summary>
        /// 实现数据库插入报价方数据
        /// </summary>
        /// <param name="seller"></param>
        /// <returns></returns>
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
