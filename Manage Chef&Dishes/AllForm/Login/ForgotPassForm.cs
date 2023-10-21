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

    public partial class ForgotPassForm : Form
    {
        Modify.UseLoginAdmin useLoginAdmin = new Modify.UseLoginAdmin();
        public ForgotPassForm()
        {
            InitializeComponent();
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
                    txtEmail.Text = "";
                    lbPass.ForeColor = Color.BlueViolet;
                    lbUser.ForeColor = Color.BlueViolet;
                    lbPass.Text = "Your PassWord is:  " + useLoginAdmin.loginAdmins(query)[0].Password;
                    lbUser.Text = "Your UserName is:  " + useLoginAdmin.loginAdmins(query)[0].UserName;
                }
                else
                { 
                    txtEmail.Text = "";
                    lbPass.Text = "Email chưa được đăng kí hoặc không đúng! ";
                    

                }
            }
        }

        private void ForgotPassForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnGetPass_Click(sender, e); 
        }

       
    }
}
