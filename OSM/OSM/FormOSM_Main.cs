using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DBClass;
using System.Collections;

namespace OSM
{
    public partial class FormOSM_Main : Form
    {
        //用户ID
        public string uuid = "";
        //用户CODE
        public string uid = "";
        //用户名
        public string uname = "";

        /// <summary>
        /// 构造函数,登录
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="username"></param>
        public FormOSM_Main(string id,string userid, string username)
        {
            InitializeComponent();
            //label_username.Text = username;
            uuid = id;
            uid = userid;
            uname = username;
            toolStripStatusLabel_username.Text = "欢迎您," + username;
            toolStripStatusLabel_date.Text = DateTime.Today.Year.ToString() + "年" + DateTime.Today.Month.ToString() + "月" + DateTime.Today.Day.ToString() + "日";

            OSM_Offers_Form offer_form = new OSM_Offers_Form();
            offer_form.setMainForm(this);
            panel_Main.Controls.Add(offer_form);
        }

        /// <summary>
        /// 退出菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 关于菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TStMItem_about_Click(object sender, EventArgs e)
        {
            AboutBox_OSM about = new AboutBox_OSM();
            about.ShowDialog();
        }

        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_change_pwd_Click(object sender, EventArgs e)
        {
            //MDIParent_Main mdi_main = new MDIParent_Main();
            //mdi_main.ShowDialog();
            FormOSM_password Form_pwd = new FormOSM_password();
            Form_pwd.uid = uid;
            Form_pwd.uname = uname;
            Form_pwd.StartPosition = FormStartPosition.CenterParent;
            Form_pwd.ShowDialog();
        }

        /// <summary>
        /// 查询报价单菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_offer_query_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_Offers_Form offer_form = new OSM_Offers_Form();
            offer_form.setMainForm(this);
            panel_Main.Controls.Add(offer_form);
        }

        /// <summary>
        /// 报价单刷新
        /// </summary>
        public void TSMItem_offer_query_Refresh()
        {
            panel_Main.Controls.Clear();
            OSM_Offers_Form offer_form = new OSM_Offers_Form();
            offer_form.setMainForm(this);
            panel_Main.Controls.Add(offer_form);
        }

        /// <summary>
        /// 新增报价单菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_offer_add_Click(object sender, EventArgs e)
        {
            //panel_Main.Controls.Clear();
            FormOSM_Offers_Add form_offers_add = new FormOSM_Offers_Add(uuid);
            form_offers_add.setMainForm(this);
            //form_offers_add.setUid(uid);
            form_offers_add.StartPosition = FormStartPosition.CenterParent;
            form_offers_add.ShowDialog();
        }

        /// <summary>
        /// 报价单审核点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_offer_aduit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("报价单审核");
            //FormOSM_Offers_Audit offersheet_audit = new FormOSM_Offers_Audit();
            //offersheet_audit.ShowDialog();
            panel_Main.Controls.Clear();
            OSM_Offer_Audit_Form offerAuditForm = new OSM_Offer_Audit_Form();
            offerAuditForm.setMainForm(this);
            panel_Main.Controls.Add(offerAuditForm);
        }

        /// <summary>
        /// 报价单审核界面刷新
        /// </summary>
        public void TSMItem_offer_aduit_Refresh()
        {
            panel_Main.Controls.Clear();
            OSM_Offer_Audit_Form offerAuditForm = new OSM_Offer_Audit_Form();
            offerAuditForm.setMainForm(this);
            panel_Main.Controls.Add(offerAuditForm);
        }

        /// <summary>
        /// 订单查询菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_order_query_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("订单查询");
            panel_Main.Controls.Clear();
            OSM_Orders_Form orderForm = new OSM_Orders_Form();
            orderForm.setMainForm(this);
            panel_Main.Controls.Add(orderForm);
        }

        /// <summary>
        /// 新增订单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_order_delivery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("订单发货");
        }
    }
}
