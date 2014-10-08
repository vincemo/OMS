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
        public string uid = "";
        public string uname = "";
        public FormOSM_Main(string userid, string username)
        {
            InitializeComponent();
            //label_username.Text = username;
            uid = userid;
            uname = username;
            toolStripStatusLabel_username.Text = "欢迎您," + username;
            toolStripStatusLabel_date.Text = DateTime.Today.Year.ToString() + "年" + DateTime.Today.Month.ToString() + "月" + DateTime.Today.Day.ToString() + "日";
        }

        private void TSMItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TStMItem_about_Click(object sender, EventArgs e)
        {
            AboutBox_OSM about = new AboutBox_OSM();
            about.ShowDialog();
        }

        private void TSMItem_change_pwd_Click(object sender, EventArgs e)
        {
            //MDIParent_Main mdi_main = new MDIParent_Main();
            //mdi_main.ShowDialog();
        }

        private void TSMItem_offer_query_Click(object sender, EventArgs e)
        {
            AccessDB adb = new AccessDB();
            string sql = "select * from OSM_OFFER_SHEET";
            DataSet dataSet = adb.SQLQuery(adb.getConnection(), sql);
            dataGridView_Main.DataSource = dataSet.Tables[0];
            //dataGridView_Main.Refresh();
            //dataGridView_Main.DataBind();
        }
    }
}
