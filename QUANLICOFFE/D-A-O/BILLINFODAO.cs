using QUANLICOFFE.D_T_O;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICOFFE.D_A_O
{
    public class BILLINFODAO
    {
        private static BILLINFODAO instance;

        public static BILLINFODAO Instance
        {
            get { if (instance == null) instance = new BILLINFODAO(); return BILLINFODAO.instance; }
            private set { BILLINFODAO.instance = value; }
        }

        private BILLINFODAO() { }

        public List<Billinfo>Getlistbillinfo(int id)
        {
            List<Billinfo> listbillinfo = new List<Billinfo>();
            DataTable data = DATA_SQLPR.Instance.ExcuteQuery("SELECT *FROM DBO.BILLINFOs WHERE IDBILL =" + id);
            foreach(DataRow item in data.Rows)
            {
                Billinfo info = new Billinfo(item);
                listbillinfo.Add(info);
            }
            return listbillinfo;
        }
    }
}
