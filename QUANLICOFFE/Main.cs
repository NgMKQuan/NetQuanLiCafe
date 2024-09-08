using QUANLICOFFE.D_A_O;
using QUANLICOFFE.D_T_O;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace QUANLICOFFE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loadtable();
        }
        void loadtable()
        {
            List<Table> tablelist = TableDAO.Instance.Loadtablelist(); 
            foreach(Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.tablewidth, Height = TableDAO.tableheight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch(item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flp_table.Controls.Add(btn);

            }
        }
        void ShowBill(int id)
        {
            lsv_bill.Items.Clear();
            List<D_T_O.Menu> listbillinfo = MENUDAO.Instance.GetlistMenuTable(id);

            foreach (D_T_O.Menu item in listbillinfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsv_bill.Items.Add(lsvItem);

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            ShowBill(TableID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccount accountdomain = new FrmAccount();
            accountdomain.ShowDialog();

        }

        private void adimnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadmin admin = new frmadmin();
            admin.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
