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
    public partial class FormOSM_Login : Form
    {
        public string userid = "";
        public string username = "";

        public FormOSM_Login()
        {
            InitializeComponent();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            AccessDB adb = new AccessDB();
            string sql = "select * from BASE_USERS where USER_ID = '" + TB_UserName.Text + "' and USER_PWD = '" + TB_PWD.Text + "'";
            Hashtable ht = adb.login(sql);

            if (ht != null)
            {
                userid = ht["userid"].ToString();
                username = ht["username"].ToString();
                //MessageBox.Show("登录成功！", "欢迎");
                //登陆成功，返回成功信息
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名密码不匹配！", "警告");
            }
        }

        private void TB_PWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
