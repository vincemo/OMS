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
    public partial class FormOSM_Buyer_Add : Form
    {
        /** 
         * 购买方新增页面实现
         **/
 
        //购买方
        private Buyer buyer;
        //记录父窗口
        private FormOSM_Offers_Add offerForm;

        public FormOSM_Buyer_Add()
        {
            InitializeComponent();
            buyer = new Buyer();
        }

        /// <summary>
        /// 设置父窗口函数
        /// </summary>
        /// <param name="parentOfferForm"></param>
        public void setOfferForm(FormOSM_Offers_Add parentOfferForm)
        {
            offerForm = parentOfferForm;
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_COM_NAME_BUYER.Text))
            {
                MessageBox.Show("名称不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_COM_CODE_BUYER.Text))
            {
                MessageBox.Show("公司代码不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_ADDR_BUYER.Text))
            {
                MessageBox.Show("地址不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_CONTACT_BUYER.Text))
            {
                MessageBox.Show("联系人不应为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_PHONE_BUYER.Text))
            {
                MessageBox.Show("联系电话不应为空！", "警告");
                return;
            }

            createBuyer(buyer);
            if (addBuyer(buyer))
            {
                offerForm.refresh_buyer_comboBox();
                this.Close();
            }
        }

        /// <summary>
        /// 输入窗口内容构造购买方对象
        /// </summary>
        /// <param name="buyer"></param>
        private void createBuyer(Buyer buyer)
        {
            buyer.setCOM_NAME(textBox_COM_NAME_BUYER.Text);
            buyer.setCOM_CODE(textBox_COM_CODE_BUYER.Text);
            buyer.setADDR(textBox_ADDR_BUYER.Text);
            buyer.setCONTACT(textBox_CONTACT_BUYER.Text);
            buyer.setPHONE(textBox_PHONE_BUYER.Text);
            buyer.setZIP_CODE(textBox_ZIPCODE_BUYER.Text);
            buyer.setEMAIL(textBox_EMAIL_BUYER.Text);
            buyer.setFAX(textBox_FAX_BUYER.Text);
            buyer.setCOMMENT(textBox_COMMENT_BUYER.Text);
        }

        /// <summary>
        /// 实现数据库插入购买方数据
        /// </summary>
        /// <param name="buyer"></param>
        /// <returns></returns>
        private bool addBuyer(Buyer buyer)
        {
            string sql = "insert into OSM_GMF(COM_NAME,COM_CODE,ADDR,CONTACT,PHONE,ZIP_CODE,FAX,EMAIL,COMMENT) ";
            sql += "values ('" + buyer.getCOM_NAME() + "','" + buyer.getCOM_CODE() + "','";
            sql += buyer.getADDR() + "','" + buyer.getCONTACT() + "','";
            sql += buyer.getPHONE() + "','" + buyer.getZIP_CODE() + "','";
            sql += buyer.getFAX() + "','" + buyer.getEMAIL() + "','" + buyer.getCOMMENT() + "')";

            AccessDB adb = new AccessDB();
            bool isExecuteSucc = adb.SQLExecute(sql);
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
