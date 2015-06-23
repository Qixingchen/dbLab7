using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

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
            getSqlConnection getConnection = new getSqlConnection();
            strLogin = "select * from loginuser where userName = '" + userName + "' and  userPwd = '" + userPwd + "' "; 
            conn = getConnection.GetConnect("rootMa","123456");  //数据库连接，返回数据库连接对象
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
    }
}
