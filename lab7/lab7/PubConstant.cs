using System.Configuration;

namespace DBUtility
{    
    /// <summary>
    /// ��������
    /// </summary>
    public class PubConstant
    {        
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"]; 
                return _connectionString; 
            }
        }
    }
}