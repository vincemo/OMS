﻿using System;
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
        /// 订单发货点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_order_delivery_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("订单发货审核");
            panel_Main.Controls.Clear();
            OSM_Order_Delivery_Form orderAuditForm = new OSM_Order_Delivery_Form();
            orderAuditForm.setMainForm(this);
            panel_Main.Controls.Add(orderAuditForm);
        }

        /// <summary>
        /// 采购单查询点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_purchase_query_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_Purchase_Form purchaseForm = new OSM_Purchase_Form();
            purchaseForm.setMainForm(this);
            panel_Main.Controls.Add(purchaseForm);
        }

        /// <summary>
        /// 采购到货点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_purchase_arrive_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_Purchase_Complete purchaseCompleteForm = new OSM_Purchase_Complete();
            purchaseCompleteForm.setMainForm(this);
            panel_Main.Controls.Add(purchaseCompleteForm);
        }

        /// <summary>
        /// 发货单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_deliver_query_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("发货单查询");
            panel_Main.Controls.Clear();
            OSM_DeliverySheet_Form deliverySheetForm = new OSM_DeliverySheet_Form();
            deliverySheetForm.setMainForm(this);
            panel_Main.Controls.Add(deliverySheetForm);
        }

        /// <summary>
        /// 发货收款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_deliver_pay_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("发货收款");
            panel_Main.Controls.Clear();
            OSM_Delivery_Audit_Form deliveryAuditForm = new OSM_Delivery_Audit_Form();
            deliveryAuditForm.setMainForm(this);
            panel_Main.Controls.Add(deliveryAuditForm);
        }

        /// <summary>
        /// 订单发货审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMItem_OrderDelivery_Audit_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_Order_Delivery_Aduit_Form odaf = new OSM_Order_Delivery_Aduit_Form();
            odaf.setMainForm(this);
            panel_Main.Controls.Add(odaf);
        }

        private void TSMItem_Delivery_Arrive_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_Delivery_Arrive_Form daf = new OSM_Delivery_Arrive_Form();
            daf.setMainForm(this);
            panel_Main.Controls.Add(daf);
        }

        private void TSMItem_PayList_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_PayList_Form plf = new OSM_PayList_Form();
            plf.setMainForm(this);
            panel_Main.Controls.Add(plf);
        }

        private void TSMItem_PayList_Pay_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            OSM_PayList_Confirm_Form plcf = new OSM_PayList_Confirm_Form();
            plcf.setMainForm(this);
            panel_Main.Controls.Add(plcf);
        }
    }
}
