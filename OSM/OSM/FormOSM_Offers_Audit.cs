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
    public partial class FormOSM_Offers_Audit : Form
    {
        public FormOSM_Offers_Audit()
        {
            InitializeComponent();

            Dictionary<string, string> typeDict = new Dictionary<string, string>();
            typeDict.Add("1", "类型1");
            typeDict.Add("2", "类型2");
            typeDict.Add("3", "类型3");
            typeDict.Add("4", "类型4");

            BindingSource bs = new BindingSource();
            bs.DataSource = typeDict;
            comboBox_offersheet_type.DataSource = bs;
            comboBox_offersheet_type.ValueMember = "Key";
            comboBox_offersheet_type.DisplayMember = "Value";

            refreshOfferSheetList(dataGridView_OfferSheet, "where OFFERSHEET_STATE = '1'");
        }

        private void refreshOfferSheetList(DataGridView dgv, string whereString = "")
        {
            string sql = "select * from OSM_OFFER_SHEET_V ";

            OSM_Pager_Offer_Audit.setDataGridView(dgv);
            OSM_Pager_Offer_Audit.setQueryString(sql);
            OSM_Pager_Offer_Audit.setKey("OFFERSHEET_CODE");
            OSM_Pager_Offer_Audit.setWhereString(whereString);
            OSM_Pager_Offer_Audit.setOrderString("OFFERSHEET_CODE DESC");
            OSM_Pager_Offer_Audit.setPageIndex(1);
            OSM_Pager_Offer_Audit.setPageSize(10);
            OSM_Pager_Offer_Audit.refreshDataGirdViewBySQL(dgv);
        }
    }
}
