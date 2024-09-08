using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QUANLICOFFE.D_A_O
{
    class DATA_SQLPR
    {
        private static DATA_SQLPR instance;
       public static DATA_SQLPR Instance
        {
            get {if (instance == null) instance = new DATA_SQLPR(); return DATA_SQLPR.instance; }
            private set { DATA_SQLPR.instance = value; }
        }

        //private DATA_SQLPR(){}

        //private string connectionS = "Data Source=.\\SQLEXPRESS;Initial Catalog=COFFEESHOPMANAGERSs;Integrated Security=True";

        //public DataTable ExcuteQuery(string query,object[] parameter=null)
        //{
        //    DataTable data = new DataTable();

        //    using (SqlConnection connection = new SqlConnection(connectionS)) 
        //    {
        //        connection.Open();

        //        SqlCommand command = new SqlCommand(query, connection);
        //        if(parameter!=null)
        //        {
        //            string[] listpara = query.Split(' ');
        //            int i = 0;
        //            foreach(string item in listpara)
        //            {
        //                if(item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }

        //        SqlDataAdapter adapter = new SqlDataAdapter(command);

        //        adapter.Fill(data);
        //        connection.Close();
        //    }

           
         

            return data;
        }

        
    }
}
