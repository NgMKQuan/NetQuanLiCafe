using QUANLICOFFE.D_A_O;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLICOFFE
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;
            if(login(username,password))
            {
                Main domain = new Main();
                this.Hide();
                domain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai user hoặc password yêu cầu bạn nhập lại !!! ");
            }
            
        }
        bool login(string username,string password )
        {
            return AccountLoginDAO.Instance.login(username,password);
        }
        
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckb_remember_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_remember.Checked==true)
            {
                txt_pass.UseSystemPasswordChar = true;
            }
            else
                txt_pass.UseSystemPasswordChar = false;
        }

        private void btn_Dangki_Click(object sender, EventArgs e)
        {
            Sigup domain = new Sigup();
            this.Hide();
            domain.ShowDialog();
            this.Close();

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
