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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }
    }
}
