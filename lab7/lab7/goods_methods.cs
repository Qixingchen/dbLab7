using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace lab7
{
    class goods_methods
    {
        private static goods_methods Instance = null;
        private goods_methods()
        {
        }

        public static goods_methods getInstance()
        {
            if (Instance == null)
            {
                Instance = new goods_methods();
            }
            return Instance;
        }

        #region 登录状态查询
        public bool LoginCheck(String userName, String userPwd)
        {
            SqlConnection conn = null;
            conn = getSqlConnection.getInstance().GetConnect(userName, userPwd); 
            return conn != null;
        }

        #endregion

        #region 获取用户名
        public string getUserName()
        {
            return null;
        }
        #endregion

        #region 库存查询

        public DataTable getInventoryInfo()
        {
            string SQLname = null;
            return getInventoryInfo(SQLname);
        }
        public DataTable getInventoryInfo(String SQLname)
        {
            String sqlString = "select goodsname as '商品名称',goodscount as '库存数量' from goodsInfo";
            if (SQLname != null)
            {
                sqlString += " where goodsname = '" + SQLname + "'";
            }

            return QueryDataAdapt(sqlString);
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

        #region 查询返回 DataTable 可以填充 DataGridView
        public DataTable QueryDataAdapt(string selectCommand)
        {
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = new SqlCommand(selectCommand, getSqlConnection.getInstance().GetConnect());

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            return table;
        }
        #endregion

        #endregion

    }
}
