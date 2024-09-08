using QUANLICOFFE.D_T_O;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICOFFE.D_A_O
{
   public class BILLDAO
    {
        private static BILLDAO instance;

        public static BILLDAO Instance
        {
            get { if (instance == null) instance = new BILLDAO(); return BILLDAO.instance; }
            private set { BILLDAO.instance = value; }
        }


        private BILLDAO() { }

        public int GetUncheckBillByTableID(int id)
        {
            DataTable data = DATA_SQLPR.Instance.ExcuteQuery("SELECT *FROM DBO.BILLs WHERE IDTABLE = " + id + " AND STATUS = 0");

            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
}
