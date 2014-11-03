using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace OSM.DBClass
{
    class SJZDController
    {
        /// <summary>
        /// 以数据字典中的内容填充下拉列表
        /// </summary>
        /// <param name="whereString"></param>
        /// <param name="cmbx"></param>
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

        /// <summary>
        /// 以sql查询结果填充下拉列表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cbox"></param>
        public static void fillComboBox(string sql, ComboBox cbox)
        {
            AccessDB adb = new AccessDB();
            DataTable dt = adb.SQLTableQuery(sql);

            Dictionary<int, string> Dict = new Dictionary<int, string>();

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr.ItemArray[0];
                string com_name = dr.ItemArray[1].ToString();
                Dict.Add(id, com_name);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = Dict;
            cbox.DataSource = bs;
            cbox.ValueMember = "Key";
            cbox.DisplayMember = "Value";
        }
    }
}
