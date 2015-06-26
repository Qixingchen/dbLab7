using System;
using System.Data.SqlClient;

namespace lab7
{
    class getSqlConnection
    {
        #region   代码中用到的变量
        private static string strConnection ;
        private static SqlConnection getConnect;  //声明链接对象
        private static String mUserName;
        private static String mUserPwd;
        //单例模式
        private static getSqlConnection Instance;
        #endregion

        #region   私有的构造函数
        private getSqlConnection()
        {
        }
        #endregion

        #region 获取实例
        public static getSqlConnection getInstance()
        {
            if (Instance == null)
            {
                Instance = new getSqlConnection();
            }
            return Instance;
        }
        #endregion

        #region   连接数据库
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnect()
        {
            if (mUserName == null)
            {
                return null;
            }
            return GetConnect(mUserName, mUserPwd);
        }

        public SqlConnection GetConnect(string userName,string userPwd)
        {
            mUserName = userName;
            mUserPwd = userPwd;

            strConnection = "server=localhost;database=Goods;uid= " + userName + " ;pwd= "+ userPwd +";Trusted_Connection=SSPI";
            getConnect = new SqlConnection(strConnection); //连接数据库，返回数据库连接对象
            try { 
                getConnect.Open(); //打开数据库
                return getConnect;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
