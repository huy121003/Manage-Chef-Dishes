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
        Modify.UseLoginAdmin useLoginAdmin = new Modify.UseLoginAdmin();
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.SeaGreen;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }

        private void btnGetPass_Click(object sender, EventArgs e)
        {
            string email=txtEmail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email đăng kí"); }
            else
            {
                string query = "Select * from LoginAdmin where Email='" + email + "'";
                if (useLoginAdmin.loginAdmins(query).Count != 0)
                {
                    lbPass.ForeColor = Color.SeaGreen;
                    lbPass.Text = "Your PassWord is:  " + useLoginAdmin.loginAdmins(query)[0].Password;
                }
                else
                {
                    lbPass.Text = "Email chưa được đăng kí hoặc không đúng! ";

                }
            }
        }

   
    }
}
