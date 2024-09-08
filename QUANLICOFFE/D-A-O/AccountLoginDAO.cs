using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICOFFE.D_A_O
{
    public class AccountLoginDAO
    {
        private static AccountLoginDAO instance;
        public static AccountLoginDAO Instance
        {
            get { if (instance == null) instance = new AccountLoginDAO(); return instance; }
           private set { instance = value; }
        }
        private AccountLoginDAO() { }
        public bool login(string username,string password)
        {
            string query = "SELECT *FROM DBO.ACCOUNTs WHERE USERNAME = @username AND PASSWORD = @password";
            DataTable result = DATA_SQLPR.Instance.ExcuteQuery(query,new object[] { username, password });
            return result.Rows.Count > 0;
            //return false; 
        }
    }
}
