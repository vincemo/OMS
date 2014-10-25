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
    public partial class FormOSM_OfferSheet_AuditBox : Form
    {
        //报价单ID
        private string offerSheetID;
        //报价单编号
        private string offerSheetCode;
        //父窗口
        private FormOSM_Main main_form;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_OfferSheet_AuditBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置父窗口
        /// </summary>
        /// <param name="mainForm"></param>
        public void setMainForm(FormOSM_Main mainForm)
        {
            main_form = mainForm;
        }

        /// <summary>
        /// 设置报价单ID
        /// </summary>
        /// <param name="offersheetid"></param>
        public void setOfferSheetID(string offersheetid)
        {
            offerSheetID = offersheetid;
        }

        /// <summary>
        /// 设置报价单编号
        /// </summary>
        /// <param name="offersheetcode"></param>
        public void setOfferSheetCode(string offersheetcode)
        {
            offerSheetCode = offersheetcode;
        }
        

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 通过按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_pass_Click(object sender, EventArgs e)
        {
            string sql = "update OSM_OFFER_SHEET set OFFERSHEET_STATE = '2' where ID = " + offerSheetID;

            AccessDB adb = new AccessDB();
            if (adb.SQLExecute(sql))
            {
                string query = "select sum(HW_TOTALPRICE) from OSM_HW where OFFERSHEET_CODE = '" + offerSheetCode + "'";
                DataTable dt = adb.SQLTableQuery(query);
                DataRow dr = dt.Rows[0];
                double require_payment = double.Parse(dr[0].ToString());

                //生成订单存入数据库
                string insertSQL = "insert into OSM_ORDER_SHEET(OFFERSHEET_ID,ORDER_STATE,REQUIRE_PAYMENT,ORDER_DATE,PAY_STATE) values ('" + offerSheetID + "','1'," + require_payment + ",#" + DateTime.Now.ToString("yyyy-MM-dd") + "#,'1')";
                if (adb.SQLExecute(insertSQL))
                {
                    MessageBox.Show("已将审核通过的报价单生成订单","消息");
                }
                main_form.TSMItem_offer_aduit_Refresh();
                this.Close();
                this.Dispose();
            }
        }

        /// <summary>
        /// 不通过按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_unpass_Click(object sender, EventArgs e)
        {
            string sql = "update OSM_OFFER_SHEET set OFFERSHEET_STATE = '3' where ID = " + offerSheetID;

            AccessDB adb = new AccessDB();
            if (adb.SQLExecute(sql))
            {
                main_form.TSMItem_offer_aduit_Refresh();
                this.Close();
                this.Dispose();
            }
        }
    }
}
