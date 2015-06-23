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
        public int tb_JoinChoice(String Sname, String Spassword)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader qlddr = null;
            int intCount = 0;
            string strLogin = "select * from staff where Name='" + Sname + "' and StaffNumber='" + Spassword + "'";
            getSqlConnection getConnection = new getSqlConnection();
            conn = getConnection.GetConnect();
            cmd = new SqlCommand(strLogin, conn);
            qlddr = cmd.ExecuteReader();
            qlddr.Read();
            if (qlddr.HasRows)
            {
                intCount = 1;
            }
            return intCount;

        }

        #endregion
    }
}
