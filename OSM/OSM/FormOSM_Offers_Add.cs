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
        private Buyer buyer;
        private Seller seller;
        private HW hw;

        public FormOSM_Offers_Add()
        {
            InitializeComponent();

            buyer = new Buyer();
            seller = new Seller();
            hw = new HW();

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

        private void queryByHW(DataGridView dgv)
        {
            string sql = "select HW_NAME,HW_TYPE,HW_NUMBER,HW_PRICE,HW_TOTALPRICE,HW_CODE,OFFERSHEET_CODE from OSM_HW where OFFERSHEET_CODE = '" + textBox_OFFERSHEET_CODE.Text + "' ";
            sql += "order by ID DESC";

            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(adb.getConnection(), sql);
            dgv.DataSource = dt;
        }

        private void fillSellerComboBox(ComboBox cbox)
        {
            string sql = "select ID,COM_NAME from OSM_BJF";
            fillComboBox(sql, cbox);
        }

        private void fillBuyerComboBox(ComboBox cbox)
        {
            string sql = "select ID,COM_NAME from OSM_GMF";
            fillComboBox(sql, cbox);
        }

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

        private void button_CONFIRM_Click(object sender, EventArgs e)
        {

        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Seller_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Buyer_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_HW_Click(object sender, EventArgs e)
        {

        }

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
                DataRow dr = dt.Rows[0];
                seller.setID(int.Parse(id));
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
                DataRow dr = dt.Rows[0];
                buyer.setID(int.Parse(id));
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
    }
}
