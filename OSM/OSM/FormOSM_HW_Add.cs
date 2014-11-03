using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using OSM.DBClass;

namespace OSM
{
    public partial class FormOSM_HW_Add : Form
    {
        //货物对象
        private HW hw;
        //父窗口对象
        private FormOSM_Offers_Add offerForm;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_HW_Add()
        {
            InitializeComponent();
            hw = new HW();

            string whereString = "where PID = 43 ";
            SJZDController.setZD_ComboBox(whereString, comboBox_HW_TYPE);
            comboBox_HW_TYPE.Enabled = false;

            //产品列表数据填充
            fillProductComboBox();
        }

        /// <summary>
        /// 设置父窗口对象函数
        /// </summary>
        /// <param name="parentOfferForm">报价单窗体类</param>
        public void setOfferForm(FormOSM_Offers_Add parentOfferForm)
        {
            offerForm = parentOfferForm;
        }

        /// <summary>
        /// 设置报价单编号公共函数
        /// </summary>
        /// <param name="offer_sheet_code">string类型</param>
        public void setHwOfferSheetCode(string offer_sheet_code)
        {
            hw.setOFFERSHEET_CODE(offer_sheet_code);
        }

        /// <summary>
        /// 取消添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_HW_NAME.Text))
            {
                MessageBox.Show("名称不能为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_HW_CODE.Text))
            {
                MessageBox.Show("代码不能为空！", "警告");
                return;
            }

            if (comboBox_HW_TYPE.SelectedIndex == -1)
            {
                MessageBox.Show("所属设备不能为空！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_HW_NUMBER.Text))
            {
                MessageBox.Show("数量不能为空！", "警告");
                return;
            }

            if (textBox_HW_NUMBER.Text == "0")
            {
                MessageBox.Show("数量不能为0！", "警告");
                return;
            }

            if (string.IsNullOrEmpty(textBox_HW_PRICE.Text))
            {
                MessageBox.Show("单价不能为空！", "警告");
                return;
            }

            createHW(hw);

            if (addHW(hw))
            {
                offerForm.refresh_hw_datagrid();
                this.Close();
            }
        }

        /// <summary>
        /// 控制输入框只能输入整数数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_HW_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入整数数字
            if ((e.KeyChar < 48 || e.KeyChar > 57))// && (e.KeyChar != 8) && (e.KeyChar != 46)
                e.Handled = true;
        }

        /// <summary>
        /// 控制输入框只能输入双精度数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_HW_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能输入双精度数字
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 46))// && (e.KeyChar != 8) 
                e.Handled = true;
        }

        /// <summary>
        /// 将窗口输入框内容填入货物对象
        /// </summary>
        /// <param name="hw"></param>
        private void createHW(HW hw)
        {
            int number = int.Parse(textBox_HW_NUMBER.Text);
            double price = double.Parse(textBox_HW_PRICE.Text);

            //hw.setHW_NAME(textBox_HW_NAME.Text);
            //hw.setHW_CODE(textBox_HW_CODE.Text);
            hw.setHW_NUMBER(number);
            hw.setHW_PRICE(price);
            hw.setHW_TOTALPRICE(price * number);
            hw.setCOMMENT(textBox_HW_COMMENT.Text);
        }

        /// <summary>
        /// 实现数据库插入货物数据
        /// </summary>
        /// <param name="hw"></param>
        /// <returns></returns>
        private bool addHW(HW hw)
        {
            string sql = "insert into OSM_HW(OFFERSHEET_CODE,PRODUCT_ID,HW_NUMBER,HW_PRICE,HW_TOTALPRICE,COMMENT) ";
            sql += "values('" + hw.getOFFERSHEET_CODE() + "'," + hw.getPRODUCT_ID() + ","; 
            sql += hw.getHW_NUMBER().ToString() + "," + hw.getHW_PRICE().ToString(); 
            sql += "," + hw.getHW_TOTALPRICE().ToString() + ",'" + hw.getCOMMENT() + "')";

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

        /// <summary>
        /// 新增产品按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            FormOSM_Product_Add addProduct = new FormOSM_Product_Add();
            addProduct.setHWWindow(this);
            addProduct.ShowDialog();
        }

        /// <summary>
        /// 产品列表数据填充
        /// </summary>
        /// <param name="comboBox_Product"></param>
        private void fillProductComboBox()
        {
            string sql = "select ID,HW_CODE from OSM_STORAGE";
            SJZDController.fillComboBox(sql, comboBox_Product);
        }

        /// <summary>
        /// 刷新产品列表
        /// </summary>
        public void refresh_product_comboBox()
        {
            fillProductComboBox();
        }

        /// <summary>
        /// 产品选择下拉列表选择触发事件
        /// 选择后将对应代码产品信息填入货物信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> kv = (KeyValuePair<int, string>)comboBox_Product.SelectedItem;

            int product_id = kv.Key;
            string sql = "SELECT * FROM OSM_STORAGE WHERE ID = " + product_id;
            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(sql);
            
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];

                textBox_HW_NAME.Text = dr["HW_NAME"].ToString();
                textBox_HW_CODE.Text = dr["HW_CODE"].ToString();

                for (int i = 0; i < comboBox_HW_TYPE.Items.Count; i++)
                {
                    KeyValuePair<string, string> item = (KeyValuePair<string, string>)comboBox_HW_TYPE.Items[i];
                    if (item.Key == dr["HW_TYPE"].ToString())
                    {
                        comboBox_HW_TYPE.SelectedIndex = i;
                        break;
                    }
                }

                hw.setPRODUCT_ID(int.Parse(dr["ID"].ToString()));
            }
        }
    }
}
