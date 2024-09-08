using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICOFFE.D_T_O
{
   public class Billinfo
    {

        public Billinfo(int id ,int billID,int waterID,int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.WaterID = waterID;
            this.Count = count;
        }

        public Billinfo(DataRow row)
        {
            this.ID = (int) row["ID"];
            this.BillID =(int) row["IDBILL"];
            this.WaterID =(int) row["IDWATER"];
            this.Count =(int) row ["COUNT"];

        }
        private int waterID;

        public int WaterID
        {
            get { return waterID; }
            set { waterID = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
