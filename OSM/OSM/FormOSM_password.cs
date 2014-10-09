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
    public partial class FormOSM_password : Form
    {
        public string uid;
        public string uname;

        public FormOSM_password()
        {
            InitializeComponent();
            ////获取屏幕高宽;
            //int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            //int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            ////计算窗体显示坐标值;
            //int x = ScreenWidth - this.Width - 5;
            //int y = ScreenHeight - this.Height - 5;

            //this.Location = new Point(x, y);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_old_pwd.Text == "")
            {
                MessageBox.Show("原密码输入框不能为空！", "警告");
                return;
            }

            if (textBox_new_pwd.Text == "")
            {
                MessageBox.Show("新密码输入框不能为空！", "警告");
                return;
            }

            AccessDB adb = new AccessDB();
            string sql = "SELECT * FROM BASE_USERS WHERE USER_ID = '" + uid + "'";
            DataSet ds = adb.SQLQuery(adb.getConnection(), sql);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];

            if (textBox_old_pwd.Text != dr["USER_PWD"].ToString() && dr["USER_PWD"] != null)
            {
                MessageBox.Show("原密码输入错误！", "警告");
                return;
            }


            if (textBox_new_pwd.Text == textBox_old_pwd.Text)
            {
                MessageBox.Show("新密码请不要与旧密码重复", "警告");
                return;
            }

            if (textBox_new_pwd.Text != textBox_pwd_confirm.Text)
            {
                MessageBox.Show("两次输入密码不一致！", "警告");
                return;
            }

            sql = "UPDATE BASE_USERS SET USER_PWD = '" + textBox_new_pwd.Text + "' WHERE USER_ID = '" + uid + "'";
            if (adb.SQLExecute(adb.getConnection(), sql))
            {
                MessageBox.Show("密码修改成功！", "消息");
                this.Close();
            }
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
