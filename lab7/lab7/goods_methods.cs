using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

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

        #region 库存查询

        public DataTable getInventoryInfo()
        {
            String sqlString = "select goodsid as '商品编号', goodsname as '商品名称',reserve as '库存数量' from inventoryInfo";
            return QueryDataAdapt(sqlString);
        }

        #endregion

        #region 商品清单查询

        public DataTable getGoodsInfo(int which,string key)
        {
            String sqlString = string.Empty;
            if(which == 1)
            {
                sqlString = "select goodsid as '商品编号',goodsname as '商品名称',goodscount as '商品数量'," 
                    + "goodsprice as '单价',photourl as '商品图片url'from "
                    + "goodsInfo,goodsphoto where goodsInfo.goodsphotoid = goodsphoto.goodsphotoid";
            }
            else if(which == 2)
            {
                sqlString = "select goodsid as '商品编号',goodsname as '商品名称',goodscount as '商品数量',"
                    + "goodsprice as '单价',photourl as '商品图片url'from "
                    + "goodsInfo,goodsphoto where goodsInfo.goodsphotoid = goodsphoto.goodsphotoid "
                    +"and goodsname like '%" + key + "%' ";
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

                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SqlException e)
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
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myReader;
            }
            catch (SqlException e)
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
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (SqlException ex)
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
            table.Locale = CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            return table;
        }
        #endregion

        #endregion

        public DataTable querySellInfo(String queryName)
        {
            String sqlString = "select sellid as '销售ID',selltime as '销售日期',sellcount as '销售数量',payment as '销售价格',goodsid as '商品ID',staffid as '销售员ID' from sellInfo where sellid=" + queryName;
            return QueryDataAdapt(sqlString);
        }
        public DataTable queryProductInfo(String queryName)
        {
            String sqlString = "select goodsid as '商品ID',goodsname as '商品名称',goodscount as '商品数量',goodsprice as '商品价格',goodsphotoid as '商品照片ID',(select photourl from goodsphoto where goodsphotoid = goodsInfo.goodsphotoid) as '商品照片URL' from goodsInfo where goodsid=" + queryName;
            return QueryDataAdapt(sqlString);
        }
    }
}
