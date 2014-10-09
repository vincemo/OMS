using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DBClass;

namespace OSM
{
    public partial class OSM_Offers_Form : UserControl
    {
        public OSM_Offers_Form()
        {
            InitializeComponent();

            AccessDB adb = new AccessDB();
            string sql = "SELECT * FROM  OSM_OFFER_SHEET_V";
            DataSet dataSet = adb.SQLQuery(adb.getConnection(), sql);
            //DataTable dt = dataSet.Tables[0];
            dataGridView_OfferSheet.AutoGenerateColumns = false;
            dataGridView_OfferSheet.DataSource = dataSet.Tables[0];

            Dictionary<string, string> osDic = new Dictionary<string, string>();
            osDic.Add("1", "待审核");
            osDic.Add("2", "需要修改");
            osDic.Add("3", "成交");
            osDic.Add("4", "已关闭");

            BindingSource bs = new BindingSource();
            bs.DataSource = osDic;
            comboBox_OfferSheet.DataSource = bs;
            comboBox_OfferSheet.ValueMember = "Key";
            comboBox_OfferSheet.DisplayMember = "Value";
        }
    }
}
