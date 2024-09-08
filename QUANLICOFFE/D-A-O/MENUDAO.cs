using QUANLICOFFE.D_T_O;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QUANLICOFFE.D_A_O
{
   public class MENUDAO
    {
        private static MENUDAO instance;

        public static MENUDAO Instance
        {
            get { if (instance == null) instance = new MENUDAO(); return MENUDAO.instance; }
            private set { MENUDAO.instance = value; }
        }

        private MENUDAO() { }

        public List<D_T_O.Menu>GetlistMenuTable(int id)
        {
            {
                List<D_T_O.Menu> listMenu = new List<D_T_O.Menu>();
                string query = "SELECT W.NAME,BI.COUNT, W.PRICE, W.PRICE*BI.COUNT AS TOTALPRICE FROM DBO.BILLINFOs AS BI, DBO.BILLs AS B, DBO.WATERs AS W WHERE BI.IDBILL = B.ID AND BI.IDWATER = W.ID AND B.IDTABLE = " + id;
                DataTable data = DATA_SQLPR.Instance.ExcuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    D_T_O.Menu menu = new D_T_O.Menu(item);
                    listMenu.Add(menu);
                }
                return listMenu;
            }
        }
       
    }
}
