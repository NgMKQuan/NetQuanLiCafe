using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLICOFFE.D_A_O;

namespace QUANLICOFFE
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
            loadaccountlist();

        }
        void loadaccountlist()
        {

            string query = "SELECT * FROM DBO.ACCOUNTs";
            dtgv_ACCOUNT.DataSource = DATA_SQLPR.Instance.ExcuteQuery(query);
        }

    }
}
