using QUANLICOFFE.D_T_O;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICOFFE.D_A_O
{
   public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }

        public static int tablewidth = 100;
        public static int tableheight = 100;

        private TableDAO() { }

        public List<Table> Loadtablelist()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DATA_SQLPR.Instance.ExcuteQuery("SELECT *FROM DBO.TABLEs");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
    }
}
