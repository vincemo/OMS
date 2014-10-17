using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//添加OleDb库
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;    
//添加JSON引用
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Json;
using System.Collections;


namespace OSM.DBClass
{
    class AccessDB
    {
        //D:\\Project\\OMS\\OSM\\OSM\\
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\\OSMDBProvider.accdb;Persist Security Info=True";
        //public static string ConnString = System.Configuration.ConfigurationManager.AppSettings["DBConnectionString"].ToString();

        public OleDbConnection getConnection() 
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            return connection;
        }

        //public SqlConnection getSqlConnection()
        //{
        //    string myConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Project\\OSM\\OSM\\DB\\OSMDBProvider.accdb;Persist Security Info=True";
        //    //"server=127.0.0.1;uid=user;pwd=123456;database=Northwind;Trusted_Connection=no";
        //    SqlConnection sqlConnection = new SqlConnection(myConn);
        //    return sqlConnection;
        //}

        public Hashtable login(string sql)
        {
            OleDbConnection conn = getConnection();
            try
            {
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();
                OleDbDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    string username = reader["USER_NAME"].ToString();
                    string userid = reader["USER_ID"].ToString();
                    string pwd = reader["USER_PWD"].ToString();

                    Hashtable ht = new Hashtable();
                    ht.Add("userid", userid);
                    ht.Add("username", username);
                    conn.Close();
                    conn.Dispose();
                    return ht;
                }
                else
                {
                    return null;
                    //throw (new Exception("当前数据表没有记录！"));
                }
            }
            catch (Exception e)
            {
                throw (new Exception("数据库连接出错！" + e.Message));
            }
        }

        public Boolean SQLExecute(string sql)
        {
            OleDbConnection conn = getConnection();
            try
            {
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();
                int row = command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();

                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw (new Exception("数据库连接出错！" + e.Message));
            }
        }

        public DataSet SQLQuery(string sql)
        {
            OleDbConnection conn = getConnection();
            try
            {
                OleDbCommand selectCommand = new OleDbCommand(sql, conn);
                OleDbDataAdapter selectAdapter = new OleDbDataAdapter();
                selectAdapter.SelectCommand = selectCommand;
                DataSet dataSet = new DataSet();
                conn.Open();
                selectAdapter.SelectCommand.ExecuteNonQuery();
                selectAdapter.Fill(dataSet);
                conn.Close();
                conn.Dispose();
                return dataSet;
            }
            catch (Exception e)
            {
                throw (new Exception("数据库连接出错！" + e.Message));
            }
        }

        public DataTable SQLTableQuery(string sql)
        {
            OleDbConnection conn = getConnection();
            try
            {
                OleDbCommand selectCommand = new OleDbCommand(sql, conn);
                OleDbDataAdapter selectAdapter = new OleDbDataAdapter();
                selectAdapter.SelectCommand = selectCommand;
                DataTable dt = new DataTable();
                conn.Open();
                selectAdapter.SelectCommand.ExecuteNonQuery();
                selectAdapter.Fill(dt);
                conn.Close();
                conn.Dispose();
                return dt;
            }
            catch (Exception e)
            {
                throw (new Exception("数据库连接出错" + e.Message));
            }
        }

        public int SQLTableDelete(string tableName, string whereString)
        {
            OleDbConnection conn = getConnection();
            string sql = "delete from " + tableName + " " + whereString;
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                return row;
            }
            catch (Exception e)
            {
                throw (new Exception("数据库连接出错" + e.Message));
            }
        }

        /// <summary>
        /// 分页使用
        /// </summary>
        /// <param name="query"></param>
        /// <param name="passCount"></param>
        /// <returns></returns>
        private string recordID(string query, int passCount)
        {
            using (OleDbConnection m_Conn = getConnection())
            {
                m_Conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, m_Conn);
                string result = string.Empty;
                using (OleDbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (passCount < 1)
                        {
                            //result += "," + dr.GetInt32(0);

                            try
                            {
                                result += "," + dr.GetInt32(0);
                            }
                            catch (Exception e)
                            {
                                //改进后的写法,以前方法是将第一个字段转换为INT
                                result += ",'" + dr.GetString(0) + "'";
                            }
                        }
                        passCount--;
                    }
                    
                }
                m_Conn.Close();
                m_Conn.Dispose();
                return result.Substring(1);
            }
        }

        /// <summary>
        /// 分页函数
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="strKey">主键</param>
        /// <param name="showString">显示字段</param>
        /// <param name="queryString">SQL语句</param>
        /// <param name="whereString">查询条件</param>
        /// <param name="orderString">排序规则</param>
        /// <param name="pageCount">传出参数，页码总数</param>
        /// <param name="recordCount">传出参数，记录总数</param>
        /// <returns>查询结果的DataTable</returns>
        public DataTable ExecutePager(int pageIndex, int pageSize, string strKey, string showString, string queryString, string whereString, string orderString, out int pageCount, out int recordCount)
        {
            if (pageIndex < 1) pageIndex = 1;
            if (pageSize < 1) pageSize = 10;
            if (string.IsNullOrEmpty(showString)) showString = "*";
            if (string.IsNullOrEmpty(orderString)) orderString = strKey + " asc ";
            using (OleDbConnection m_Conn = getConnection())
            {
                m_Conn.Open();
                string myVw = string.Format(" ( {0} ) tempVw ", queryString);
                OleDbCommand cmdCount = new OleDbCommand(string.Format(" select count(*) as recordCount from {0} {1}", myVw, whereString), m_Conn);

                recordCount = Convert.ToInt32(cmdCount.ExecuteScalar());

                if ((recordCount % pageSize) > 0)
                    pageCount = recordCount / pageSize + 1;
                else
                    pageCount = recordCount / pageSize;
                OleDbCommand cmdRecord;
                if (pageIndex == 1)//第一页
                {
                    cmdRecord = new OleDbCommand(string.Format("select top {0} {1} from {2} {3} order by {4} ", pageSize, showString, myVw, whereString, orderString), m_Conn);
                }
                else if (pageIndex > pageCount)//超出总页数
                {
                    cmdRecord = new OleDbCommand(string.Format("select top {0} {1} from {2} {3} order by {4} ", pageSize, showString, myVw, "where 1=2", orderString), m_Conn);
                }
                else
                {
                    int pageLowerBound = pageSize * pageIndex;
                    int pageUpperBound = pageLowerBound - pageSize;
                    string recordIDs = recordID(string.Format("select top {0} {1} from {2} {3} order by {4} ", pageLowerBound, strKey, myVw, whereString, orderString), pageUpperBound);
                    cmdRecord = new OleDbCommand(string.Format("select {0} from {1} where {2} in ({3}) order by {4} ", showString, myVw, strKey, recordIDs, orderString), m_Conn);

                }
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdRecord);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                m_Conn.Close();
                m_Conn.Dispose();
                return dt;
            }
        }
    }
}
