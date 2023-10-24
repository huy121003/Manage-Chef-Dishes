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
using System.Text.RegularExpressions;

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
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{1,30}@gmail.com(.vn|)$");
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
                   
                    lbUser.ForeColor = Color.BlueViolet;
                    lbUser.Text = "Tên đăng nhập :  " + useLoginAdmin.loginAdmins(query)[0].UserName  + " \nMật khẩu          :  " + useLoginAdmin.loginAdmins(query)[0].Password;
                    //lbUser.Text = ;
                }
                else
                { 
                    txtEmail.Text = "";
                    lbUser.Text = "Email chưa được đăng kí hoặc không đúng! ";
                    

                }
            }
        }

        private void ForgotPassForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnGetPass_Click(sender, e); 
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn không cho phép xuống dòng
            }
        }

        private void ForgotPassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
