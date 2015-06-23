using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lab7
{
    class getSqlConnection
    {
        #region   代码中用到的变量
        //string G_Str_ConnectionString = "(Data Source=.\\SQLExpress;Integrated Security=SSPI;AttachDBFilename=C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SmallMarket.mdf;User Instance=true";
        string strConnection ;
        SqlConnection getConnect;  //声明链接对象
        #endregion

        #region  构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public getSqlConnection()
        {

        }
        #endregion

        #region   连接数据库
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnect(string userName,string userPwd)
        {
            strConnection = "server=localhost;database=Goods;uid= " + userName + " ;pwd= "+ userPwd +";Trusted_Connection=SSPI";
            getConnect = new SqlConnection(strConnection); //连接数据库，返回数据库连接对象
            try { 
                getConnect.Open(); //打开数据库
                return getConnect;
            }
            catch (Exception ee)
            {
                return null;
            }
        }
        #endregion
    }
}
