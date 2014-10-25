using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSM.DBClass
{
    class SJZDController
    {
        public static void setZD_ComboBox(string whereString, ComboBox cmbx)
        {
            AccessDB adb = new AccessDB();
            Dictionary<string, string> dict = adb.QuerySJZD(whereString);
            BindingSource bs = new BindingSource();
            bs.DataSource = dict;
            cmbx.DataSource = bs;
            cmbx.ValueMember = "Key";
            cmbx.DisplayMember = "Value";
        }
    }
}
