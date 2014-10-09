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
        private string connectionString;
        //public static string ConnString = System.Configuration.ConfigurationManager.AppSettings["DBConnectionString"].ToString();

        public OleDbConnection getConnection() 
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Project\\OMS\\OSM\\OSM\\DB\\OSMDBProvider.accdb;Persist Security Info=True";
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

        public Hashtable login(OleDbConnection conn, string sql)
        {

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

        public Boolean SQLExecute(OleDbConnection conn, string sql)
        {
            try
            {
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();
                int row = command.ExecuteNonQuery();
                conn.Close();

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

        public DataSet SQLQuery(OleDbConnection conn, string sql)
        {
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
                return dataSet;
            }
            catch (Exception e)
            {
                throw (new Exception("数据库连接出错！" + e.Message));
            }
        }
    }
}
