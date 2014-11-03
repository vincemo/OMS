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
    public partial class FormOSM_Product_Add : Form
    {
        //父窗口
        FormOSM_HW_Add HWWindow;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_Product_Add()
        {
            InitializeComponent();

            string where = "where PID = 43";
            SJZDController.setZD_ComboBox(where, comboBox_Type);
        }

        /// <summary>
        /// 设置父窗口
        /// </summary>
        /// <param name="hw_form"></param>
        public void setHWWindow(FormOSM_HW_Add hw_form)
        {
            HWWindow = hw_form;
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                MessageBox.Show("产品名称不能为空！", "警告");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Code.Text))
            {
                MessageBox.Show("产品代码不能为空！", "警告");
                return;
            }

            if (comboBox_Type.SelectedIndex == -1)
            {
                MessageBox.Show("所属设备不能为空！", "警告");
                return;
            }

            AccessDB adb = new AccessDB();

            KeyValuePair<string,string> item = (KeyValuePair<string,string>)(comboBox_Type.SelectedItem);

            string insertSQL = "INSERT INTO OSM_STORAGE(HW_NAME,HW_CODE,HW_TYPE,COMMENT) VALUES (";
            insertSQL += "'" + textBox_Name.Text + "','" + textBox_Code.Text + "','" + item.Key + "','" + textBox_Comment.Text + "')";

            if (adb.SQLExecute(insertSQL))
            {
                MessageBox.Show("添加成功！", "消息");
                HWWindow.refresh_product_comboBox();
                this.Close();
                this.Dispose();
            }
        }
    }
}
