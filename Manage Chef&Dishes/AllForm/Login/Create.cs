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
namespace Manage_Chef_Dishes.AllForm.Login
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "UserName")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "UserName";
                txtUser.ForeColor = Color.SeaGreen;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PassWord")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

            if (txtPass.Text == "")
            {
                txtPass.Text = "PassWord";
                txtPass.ForeColor = Color.SeaGreen;
            }
        }

        private void txtEnterPass_Enter(object sender, EventArgs e)
        {
            if (txtEnterPass.Text == "Enter PassWord")
            {
                txtEnterPass.Text = "";
                txtEnterPass.ForeColor = Color.White;
            }
        }

        private void txtEnterPass_Leave(object sender, EventArgs e)
        {

            if (txtEnterPass.Text == "")
            {
                txtEnterPass.Text = "Enter PassWord";
                txtEnterPass.ForeColor = Color.SeaGreen;
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Email")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {

            if (txtMail.Text == "")
            {
                txtMail.Text = "Email";
                txtMail.ForeColor = Color.SeaGreen;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }

      
    }
}
