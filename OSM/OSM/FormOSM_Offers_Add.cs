using System;
using System.Collections;
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
    public partial class FormOSM_Offers_Add : Form
    {
        //报价单对象
        private OfferSheet offer_sheet;
        //购买方对象
        private Buyer buyer;
        //报价方对象
        private Seller seller;
        //货物对象
        //private HW hw;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FormOSM_Offers_Add()
        {
            InitializeComponent();

            buyer = new Buyer();
            seller = new Seller();
            offer_sheet = new OfferSheet();
            //hw = new HW();

            Dictionary<string, string> otDic = new Dictionary<string, string>();
            otDic.Add("1", "类型1");
            otDic.Add("2", "类型2");
            otDic.Add("3", "类型3");
            otDic.Add("4", "类型4");
            BindingSource bs = new BindingSource();
            bs.DataSource = otDic;
            comboBox_OFFERSHEET_TYPE.DataSource = bs;
            comboBox_OFFERSHEET_TYPE.ValueMember = "Key";
            comboBox_OFFERSHEET_TYPE.DisplayMember = "Value";

            string offsht_code = "OSC" + DateTime.Now.ToString("yyyyMMddHHmmss");
            textBox_OFFERSHEET_CODE.Text = offsht_code;

            fillSellerComboBox(comboBox_SELLER);
            fillBuyerComboBox(comboBox_BUYER);
            queryByHW(dataGridView_HW);
        }

        /// <summary>
        /// 查询对应报价单货物列表
        /// </summary>
        /// <param name="dgv"></param>
        private void queryByHW(DataGridView dgv)
        {
            string sql = "select HW_NAME,HW_TYPE,HW_NUMBER,HW_PRICE,HW_TOTALPRICE,HW_CODE,OFFERSHEET_CODE from OSM_HW where OFFERSHEET_CODE = '" + textBox_OFFERSHEET_CODE.Text + "' ";
            sql += "order by ID DESC";

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(adb.getConnection(), sql);
            dgv.DataSource = dt;
        }

        /// <summary>
        /// 刷新货物列表
        /// </summary>
        public void refresh_hw_datagrid()
        {
            string sql = "select HW_NAME,HW_TYPE,HW_NUMBER,HW_PRICE,HW_TOTALPRICE,HW_CODE,OFFERSHEET_CODE from OSM_HW where OFFERSHEET_CODE = '" + textBox_OFFERSHEET_CODE.Text + "' ";
            sql += "order by ID DESC";

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(adb.getConnection(), sql);
            dataGridView_HW.DataSource = dt;
        }

        /// <summary>
        /// 加载报价方列表
        /// </summary>
        /// <param name="cbox"></param>
        private void fillSellerComboBox(ComboBox cbox)
        {
            string sql = "select ID,COM_NAME from OSM_BJF";
            fillComboBox(sql, cbox);
        }

        /// <summary>
        /// 刷新报价方列表
        /// </summary>
        public void refresh_seller_comboBox()
        {
            string sql = "select ID,COM_NAME from OSM_BJF";
            fillComboBox(sql, comboBox_SELLER);
        }

        /// <summary>
        /// 加载购买方列表
        /// </summary>
        /// <param name="cbox"></param>
        private void fillBuyerComboBox(ComboBox cbox)
        {
            string sql = "select ID,COM_NAME from OSM_GMF";
            fillComboBox(sql, cbox);
        }

        /// <summary>
        /// 刷新购买方列表
        /// </summary>
        public void refresh_buyer_comboBox()
        {
            string sql = "select ID,COM_NAME from OSM_GMF";
            fillComboBox(sql, comboBox_BUYER);
        }

        /// <summary>
        /// 执行comboBox的SQL查询结果填充
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cbox"></param>
        private void fillComboBox(string sql, ComboBox cbox)
        {
            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(adb.getConnection(), sql);

            Dictionary<int, string> sellerDict = new Dictionary<int, string>();

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr.ItemArray[0];
                string com_name = dr.ItemArray[1].ToString();
                sellerDict.Add(id, com_name);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = sellerDict;
            cbox.DataSource = bs;
            cbox.ValueMember = "Key";
            cbox.DisplayMember = "Value";
        }

        /// <summary>
        /// 确认按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CONFIRM_Click(object sender, EventArgs e)
        {
            //string date = dateTimePicker_OFFERSHEET_DATE.Text;
            //将报价单编号用于构造报价单对象
            offer_sheet.setOFFERSHEET_CODE(textBox_OFFERSHEET_CODE.Text);
            //由于是新增报价单，所以状态是初始状态1
            offer_sheet.setOFFERSHEET_STATE("1");
            offer_sheet.setOFFERSHEET_DATE(dateTimePicker_OFFERSHEET_DATE.Text);

            if (addOfferSheet(offer_sheet))
            {
                this.Close();
            }
        }

        private bool addOfferSheet(OfferSheet offer_sheet)
        {
            string sql = "insert into OSM_OFFER_SHEET(OFFERSHEET_CODE,GMF_ID,BJF_ID,OFFERSHEET_TYPE,OFFERSHEET_DATE,OFFERSHEET_STATE) ";
            sql += "values('" + offer_sheet.getOFFERSHEET_CODE() + "'," + offer_sheet.getGMF_ID() + "," + offer_sheet.getBJF_ID();
            sql += ",'" + offer_sheet.getOFFERSHEET_TYPE() + "','" + offer_sheet.getOFFERSHEET_DATE() + "','" + offer_sheet.getOFFERSHEET_STATE() + "')";

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

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            //string sql = "delete from OSM_HW where OFFERSHEET_CODE = '" + textBox_OFFERSHEET_CODE.Text + "'";
            //if (adb.SQLExecute(adb.getConnection(), sql))
            //{
            //    this.Close();
            //}

            AccessDB adb = new AccessDB();
            string whereStr = " where OFFERSHEET_CODE = '" + textBox_OFFERSHEET_CODE.Text + "'";
            if (adb.SQLTableDelete(adb.getConnection(), "OSM_HW", whereStr) >= 0)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 添加报价方按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Add_Seller_Click(object sender, EventArgs e)
        {
            FormOSM_Seller_Add form_add_seller = new FormOSM_Seller_Add();
            form_add_seller.setOfferForm(this);
            form_add_seller.ShowDialog();
        }

        /// <summary>
        /// 添加购买方按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Add_Buyer_Click(object sender, EventArgs e)
        {
            FormOSM_Buyer_Add form_add_buyer = new FormOSM_Buyer_Add();
            form_add_buyer.setOfferForm(this);
            form_add_buyer.ShowDialog();
        }

        /// <summary>
        /// 添加货物按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Add_HW_Click(object sender, EventArgs e)
        {
            FormOSM_HW_Add form_add_hw = new FormOSM_HW_Add();
            form_add_hw.setOfferForm(this);
            form_add_hw.setHwOfferSheetCode(textBox_OFFERSHEET_CODE.Text);
            form_add_hw.ShowDialog();
        }

        /// <summary>
        /// 报价方列表index变化触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SELLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> kv = ((KeyValuePair<int,string>)comboBox_SELLER.SelectedItem);
            string id = kv.Key.ToString();
            string sql = "select COM_NAME,ADDR,CONTACT,PHONE,ZIP_CODE,EMAIL,FAX,COMMENT from OSM_BJF where ID = ";
            sql += id;

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(adb.getConnection(), sql);
            if (dt.Rows.Count == 1)
            {
                //构造报价方ID
                seller.setID(int.Parse(id));
                //报价单中报价方ID
                offer_sheet.setBJF_ID(int.Parse(id));
                
                DataRow dr = dt.Rows[0];

                seller.setCOM_NAME(dr.ItemArray[0].ToString());
                seller.setADDR(dr.ItemArray[1].ToString());
                seller.setCONTACT(dr.ItemArray[2].ToString());
                seller.setPHONE(dr.ItemArray[3].ToString());
                seller.setZIP_CODE(dr.ItemArray[4].ToString());
                seller.setEMAIL(dr.ItemArray[5].ToString());
                seller.setFAX(dr.ItemArray[6].ToString());
                seller.setCOMMENT(dr.ItemArray[7].ToString());

                textBox_COM_NAME_SELLER.Text = seller.getCOM_NAME();
                textBox_ADDR_SELLER.Text = seller.getADDR();
                textBox_CONTACT_SELLER.Text = seller.getCONTACT();
                textBox_PHONE_SELLER.Text = seller.getPHONE();
                textBox_ZIPCODE_SELLER.Text = seller.getZIP_CODE();
                textBox_EMAIL_SELLER.Text = seller.getEMAIL();
                textBox_FAX_SELLER.Text = seller.getFAX();
                textBox_COMMENT_SELLER.Text = seller.getCOMMENT();
            }
            else
            {
                MessageBox.Show("数据库返回数据不止一条！");
                return;
            }
            
        }

        /// <summary>
        /// 购买方按钮index变化触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_BUYER_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> kv = ((KeyValuePair<int, string>)comboBox_BUYER.SelectedItem);
            string id = kv.Key.ToString();
            string sql = "select COM_NAME,COM_CODE,ADDR,CONTACT,PHONE,ZIP_CODE,EMAIL,FAX,COMMENT from OSM_GMF where ID = ";
            sql += id;

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(adb.getConnection(), sql);
            if (dt.Rows.Count == 1)
            {
                //构造购买方ID
                buyer.setID(int.Parse(id));
                //报价单中购买方ID
                offer_sheet.setGMF_ID(int.Parse(id));

                DataRow dr = dt.Rows[0];

                buyer.setCOM_NAME(dr.ItemArray[0].ToString());
                buyer.setCOM_CODE(dr.ItemArray[1].ToString());
                buyer.setADDR(dr.ItemArray[2].ToString());
                buyer.setCONTACT(dr.ItemArray[3].ToString());
                buyer.setPHONE(dr.ItemArray[4].ToString());
                buyer.setZIP_CODE(dr.ItemArray[5].ToString());
                buyer.setEMAIL(dr.ItemArray[6].ToString());
                buyer.setFAX(dr.ItemArray[7].ToString());
                buyer.setCOMMENT(dr.ItemArray[8].ToString());


                textBox_COM_NAME_BUYER.Text = buyer.getCOM_NAME();
                textBox_COM_CODE_BUYER.Text = buyer.getCOM_CODE();
                textBox_ADDR_BUYER.Text = buyer.getADDR();
                textBox_CONTACT_BUYER.Text = buyer.getCONTACT();
                textBox_PHONE_BUYER.Text = buyer.getPHONE();
                textBox_ZIPCODE_BUYER.Text = buyer.getZIP_CODE();
                textBox_EMAIL_BUYER.Text = buyer.getEMAIL();
                textBox_FAX_BUYER.Text = buyer.getFAX();
                textBox_COMMENT_BUYER.Text = buyer.getCOMMENT();
            }
            else
            {
                MessageBox.Show("数据库返回数据不止一条！");
                return;
            }
        }

        private void comboBox_OFFERSHEET_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> kv = (KeyValuePair<string, string>)comboBox_OFFERSHEET_TYPE.SelectedItem;
            string offer_sheet_type = kv.Key;
            offer_sheet.setOFFERSHEET_TYPE(offer_sheet_type);
        }

        private void dateTimePicker_OFFERSHEET_DATE_ValueChanged(object sender, EventArgs e)
        {
            string offer_sheet_date = dateTimePicker_OFFERSHEET_DATE.Text;
            offer_sheet.setOFFERSHEET_DATE(offer_sheet_date);
        }
    }
}
