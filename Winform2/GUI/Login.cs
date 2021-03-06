using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Winform2.GUI
{
    public partial class Login : Form
    {
        LoginBUS loginBUS = new LoginBUS();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Program.us = loginBUS.checkUser(txtMa.Text, txtPass.Text);
            if(Program.us != null)
            {
                //Mở form muốn hiện
                MDIParent md = new MDIParent();
                md.Show();
                //Ẩn form login
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(txtMa, "Tài khoản hoặc mật khẩu không chính xác");
                txtMa.Clear();
                txtPass.Clear();
                txtMa.Focus();
            }
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)(e.KeyChar) == 13)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)(e.KeyChar) == 13)
            {
                btnLogin.Focus();
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
