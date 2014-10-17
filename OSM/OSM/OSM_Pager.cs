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
    public partial class OSM_Pager : UserControl
    {
        //控件控制的datagridview对象
        private DataGridView dgv;
        //对应的SQL查询语句
        private string queryString = "";
        //对应主键
        private string keyString = "";
        //对SQL查询结果的查询条件
        private string whereString = "";
        //排序条件
        private string orderString = "";
        //显示字段
        private string showString = "";
        //页码
        private int pageIndex = 0;
        //单页面最大记录数
        private int pageSize = 0;
        //页数
        private int pageCount = 0;
        //总记录数
        private int recordSum = 0;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OSM_Pager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置控制的datagridview
        /// </summary>
        /// <param name="objDgv"></param>
        public void setDataGridView(DataGridView objDgv)
        {
            dgv = objDgv;
        }

        /// <summary>
        /// 设置对应的SQL查询语句
        /// </summary>
        /// <param name="objSQL">SQL语句字符串</param>
        public void setQueryString(string strQuery)
        {
            queryString = strQuery;
        }

        /// <summary>
        /// 设置对应数据表的主键
        /// </summary>
        /// <param name="strKey">主键字符串</param>
        public void setKey(string strKey)
        {
            keyString = strKey;
        }

        /// <summary>
        /// 设置页码
        /// </summary>
        /// <param name="page_index">页码值</param>
        public void setPageIndex(int page_index)
        {
            pageIndex = page_index;
        }

        /// <summary>
        /// 设置单个页面最大容量
        /// </summary>
        /// <param name="page_size">单页面容量值</param>
        public void setPageSize(int page_size)
        {
            pageSize = page_size;
        }


        /// <summary>
        /// 设置查询条件
        /// </summary>
        /// <param name="strWhere">查询条件字符串</param>
        public void setWhereString(string strWhere)
        {
            whereString = strWhere;
        }

        /// <summary>
        /// 设置排序条件
        /// </summary>
        /// <param name="strOrder">排序条件字符串</param>
        public void setOrderString(string strOrder)
        {
            orderString = strOrder;
        }

        /// <summary>
        /// 刷新对应的dataGridView并展示第一页
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="sql"></param>
        public void refreshDataGirdViewBySQL(DataGridView dgv)
        {
            showString = "";

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i] is DataGridViewTextBoxColumn)
                {
                    showString += dgv.Columns[i].DataPropertyName + ",";
                }
            }
            showString = showString.Substring(0, showString.Length - 1) + " ";

            AccessDB adb = new AccessDB();
            //执行查询第一页,默认页面容量为1
            DataTable dt = adb.ExecutePager(pageIndex, pageSize, keyString, showString, queryString, whereString, orderString, out pageCount, out recordSum);
            dgv.DataSource = dt;
            label_current_page.Text = "1";
            label_page_sum.Text = pageCount.ToString();
            label_record_sum.Text = recordSum.ToString();

        }

        /// <summary>
        /// 首页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_first_page_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            AccessDB adb = new AccessDB();
            DataTable dt = adb.ExecutePager(pageIndex, pageSize, keyString, showString, queryString, whereString, orderString, out pageCount, out recordSum);
            dgv.DataSource = dt;
            textBox_page_index.Text = "1";
            label_current_page.Text = "1";
            label_page_sum.Text = pageCount.ToString();
            label_record_sum.Text = recordSum.ToString();
        }

        /// <summary>
        /// 上一页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_previous_Click(object sender, EventArgs e)
        {
            pageIndex = int.Parse(textBox_page_index.Text);
            if (--pageIndex < 1)
            {
                pageIndex = 1;
            }

            AccessDB adb = new AccessDB();
            DataTable dt = adb.ExecutePager(pageIndex, pageSize, keyString, showString, queryString, whereString, orderString, out pageCount, out recordSum);
            dgv.DataSource = dt;
            textBox_page_index.Text = pageIndex.ToString();
            label_current_page.Text = pageIndex.ToString();
            label_page_sum.Text = pageCount.ToString();
            label_record_sum.Text = recordSum.ToString();
        }

        /// <summary>
        /// 下一页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_next_Click(object sender, EventArgs e)
        {
            pageIndex = int.Parse(textBox_page_index.Text);
            if (++pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }

            AccessDB adb = new AccessDB();
            DataTable dt = adb.ExecutePager(pageIndex, pageSize, keyString, showString, queryString, whereString, orderString, out pageCount, out recordSum);
            dgv.DataSource = dt;
            textBox_page_index.Text = pageIndex.ToString();
            label_current_page.Text = pageIndex.ToString();
            label_page_sum.Text = pageCount.ToString();
            label_record_sum.Text = recordSum.ToString();
        }

        /// <summary>
        /// 尾页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_last_page_Click(object sender, EventArgs e)
        {
            pageIndex = pageCount;

            AccessDB adb = new AccessDB();
            DataTable dt = adb.ExecutePager(pageIndex, pageSize, keyString, showString, queryString, whereString, orderString, out pageCount, out recordSum);
            dgv.DataSource = dt;
            textBox_page_index.Text = pageIndex.ToString();
            label_current_page.Text = pageIndex.ToString(); 
            label_page_sum.Text = pageCount.ToString();
            label_record_sum.Text = recordSum.ToString();
        }

        /// <summary>
        /// 跳转按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_goToPage_Click(object sender, EventArgs e)
        {
            pageIndex = int.Parse(textBox_page_index.Text);
            if (pageIndex > pageCount)
            {
                MessageBox.Show("页码大于总页数！", "错误");
                return;
            }

            AccessDB adb = new AccessDB();
            DataTable dt = adb.ExecutePager(pageIndex, pageSize, keyString, showString, queryString, whereString, orderString, out pageCount, out recordSum);
            dgv.DataSource = dt;
            textBox_page_index.Text = pageIndex.ToString();
            label_current_page.Text = pageIndex.ToString(); 
            label_page_sum.Text = pageCount.ToString();
            label_record_sum.Text = recordSum.ToString();
        }
    }
}
