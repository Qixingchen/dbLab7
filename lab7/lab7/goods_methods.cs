using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace lab7
{
    class goods_methods
    {
        #region 登录状态查询
        public bool LoginCheck(String userName, String userPwd)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader qlddr = null;
            string strLogin = null;
            bool LoginStatus = false;
            strLogin = "select * from loginuser where userName = '" + userName + "' and  userPwd = '" + userPwd + "' ";
            conn = getSqlConnection.getInstance().GetConnect("rootMa", "123456");  //数据库连接，返回数据库连接对象
            cmd = new SqlCommand(strLogin, conn); //创建command对象
            qlddr = cmd.ExecuteReader();
            //通过Read方法可以判断数据是否还有下一行，如果存在数据，则继续运行并返回true，否则返回false
            qlddr.Read();
            if (qlddr.HasRows)
            {
                LoginStatus = true; //用户名密码正确
            }
            return LoginStatus;

        }

        #endregion

        #region 获取用户名
        public string getUserName()
        {
            return null;
        }
        #endregion

        #region  执行简单SQL语句

        #region  执行SQL语句，返回影响的记录数
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = getSqlConnection.getInstance().GetConnect())
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        #endregion

        #region 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSQL)
        {
            SqlConnection connection = getSqlConnection.getInstance().GetConnect();
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            try
            {
                connection.Open();
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }

        }

        #endregion

        #region 执行查询语句，返回DataSet
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            using (SqlConnection connection = getSqlConnection.getInstance().GetConnect())
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

        #endregion

        #endregion

        public static DataSet querySellInfo(String queryName)
        {
            String sqlString = "select * from sellInfo where id=" + queryName;
            return Query(sqlString);
        }
    }
}
