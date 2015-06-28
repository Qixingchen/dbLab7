﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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

        #region 新增用户
        public void AddUser(String staffID, String username, String UserAge, String UserSex, String UserType)
        {
            String SQL =
                "insert into staffinfo values(" + staffID + "," + "'" + username + "'" + "," + "'" + UserSex + "'" +
                "," + UserAge + ",'" + UserType + "')";
            goods_methods.ExecuteSql(SQL);

            SQL = @"EXEC sp_addlogin " + username + @",'123456','Goods'
EXEC sp_adduser " + username + "," + username;

            if (UserType.CompareTo("root") == 0)
            {
                SQL += @"
GRANT insert,select,update,delete ON staffinfo TO " + username + @";
GRANT insert,select,update,delete ON stockinfo TO " + username + @";
GRANT insert,select,update,delete ON goodsinfo TO " + username + @";
GRANT insert,select,update,delete ON goodsphoto TO " + username + @";
GRANT insert,select,update,delete ON sellinfo TO " + username + @";
GRANT insert,select,update,delete ON loginuser TO " + username + ";";
            }
            if (UserType.CompareTo("admin") == 0)
            {
                SQL += @"
GRANT select ON staffinfo TO " + username + @";
GRANT select ON stockinfo TO " + username + @";
GRANT select ON goodsinfo TO  " + username + @";
GRANT select ON goodsphoto TO  " + username + @";
GRANT select ON sellinfo TO " + username;
            }
            if (UserType.CompareTo("staff") == 0)
            {
                SQL += @"
GRANT insert,select,update,delete ON staffinfo TO  " + username;
            }
            if (UserType.CompareTo("stock") == 0)
            {
                SQL += @"
GRANT insert,select,update,delete ON stockinfo TO  " + username + @";
GRANT insert,select,update,delete ON goodsinfo TO  " + username + @";
GRANT insert,select,update,delete ON goodsphoto TO " + username;
            }
            if (UserType.CompareTo("sell") == 0)
            {
                SQL += @"
GRANT insert,select,update,delete ON goodsinfo TO  " + username + @";
GRANT insert,select,update,delete ON goodsphoto TO   " + username + @";
GRANT insert,select,update,delete ON sellinfo TO   " + username;
            }
            goods_methods.ExecuteSql(SQL,true);



        }
        #endregion

        #region 获取用户名
        public string getUserType(String userName)
        {
            String SQl = "select staffInfo.staffType from staffInfo where staffname = '"
                + userName + "'";
            SqlDataReader reader = ExecuteReader(SQl, true);
            reader.Read();
            String ans = reader.GetString(0);
            reader.Close();
            return ans;
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
            String sqlString = "select goodsid as '商品编号', goodsname as '商品名称',reserve as '库存数量' from inventoryInfo";
            if (SQLname != null)
            {
                sqlString += " where goodsname = '" + SQLname + "'";
            }
            return QueryDataAdapt(sqlString);
        }

        #endregion

        #region 商品清单查询

        public DataTable getGoodsInfo(int which, string key)
        {
            String sqlString = string.Empty;
            if (which == 1)
            {
                sqlString = @"select goodsid as '商品编号',goodsname as '商品名称',
                    goodsprice as '单价',goodsphoto.goodsphotoid as '图片编号',photourl as '商品图片url'from 
                    goodsInfo,goodsphoto where goodsInfo.goodsphotoid = goodsphoto.goodsphotoid";

            }
            else if (which == 2)
            {
                sqlString = @"select goodsid as '商品编号',goodsname as '商品名称',
                   goodsprice as '单价',goodsphoto.goodsphotoid as '图片编号',photourl as '商品图片url'from 
                    goodsInfo,goodsphoto where goodsInfo.goodsphotoid = goodsphoto.goodsphotoid 
                    and goodsname like '%" + key + "%' ";
            }
            return QueryDataAdapt(sqlString);
        }

        #endregion

        #region  执行简单SQL语句

        #region  执行SQL语句，返回影响的记录数

        //true时最大权限查询
        public static int ExecuteSql(string SQLString, bool isMaxPermission = false)
        {
            SqlConnection connection = null;
            connection = isMaxPermission ? getSqlConnection.getInstance().GetMaxPermissionSQLConnect() : getSqlConnection.getInstance().GetConnect();
            using (SqlCommand cmd = new SqlCommand(SQLString, connection))
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    connection.Close();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    connection.Close();
                    MessageBox.Show("无权操作");
                    return 0;
                }
            }
            
        }

        #endregion

        #region 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )

        //true时最大权限查询
        public static SqlDataReader ExecuteReader(string strSQL, bool isMaxPermission = false)
        {
            SqlConnection connection;
            if (isMaxPermission)
            {
                connection = getSqlConnection.getInstance().GetMaxPermissionSQLConnect();
            }
            else
            {
                connection = getSqlConnection.getInstance().GetConnect();
            }

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
        public static DataSet Query(string SQLString, bool isMaxpermission = false)
        {
            SqlConnection connection = isMaxpermission
                ? getSqlConnection.getInstance().GetMaxPermissionSQLConnect()
                : getSqlConnection.getInstance().GetConnect();

            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                command.Fill(ds, "ds");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("无权操作");
                connection.Close();
                return null;
            }
            connection.Close();
            return ds;

        }

        #endregion

        #region 查询返回 DataTable 可以填充 DataGridView
        public DataTable QueryDataAdapt(string selectCommand,bool isMaxpermission = false)
        {
            SqlConnection connection = isMaxpermission
                ? getSqlConnection.getInstance().GetMaxPermissionSQLConnect()
                : getSqlConnection.getInstance().GetConnect();
            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = new SqlCommand(selectCommand, connection);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = CultureInfo.InvariantCulture;
            try
            {
                dataAdapter.Fill(table);
            }
            catch (Exception)
            {
                MessageBox.Show("无权操作");
            }
            
            return table;
        }
        #endregion

        #endregion

        public DataTable querySellInfo(String queryName)
        {
            String sqlString = @"select sellid as '销售ID',selltime as '销售日期',
            sellcount as '销售数量',payment as '销售价格',goodsid as '商品ID',
            staffid as '销售员ID' from sellInfo where sellid=" + queryName;
            return QueryDataAdapt(sqlString);
        }
        public DataTable queryProductInfo(String queryName)
        {
            String sqlString = @"select goodsid as '商品ID',goodsname as '商品名称',
            goodsprice as '商品价格',goodsphotoid as '商品照片ID',
            (select photourl from goodsphoto where goodsphotoid = goodsInfo.goodsphotoid) as '商品照片URL' 
            from goodsInfo where goodsid=" + queryName;
            return QueryDataAdapt(sqlString);
        }
    }
}
