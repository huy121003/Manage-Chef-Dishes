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
    public partial class LoginForm : Form
    {
        Modify.UseLoginAdmin useLoginAdmin=new Modify.UseLoginAdmin();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
        }

        private void llbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassForm fg =new ForgotPassForm();
            fg.ShowDialog();
            this.Close();
            
        }

        private void llbCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateForm cr =new CreateForm();
            cr.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            if (username.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản"); }
            else if (password.Trim() == "") {MessageBox.Show("Vui lòng nhập mật khẩu");  }
            else
            {
                string query="Select * from LoginAdmin where UserName ='"+username+"' and PassWord ='"+password +"'";
                if(useLoginAdmin.loginAdmins(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    MainForm mf= new MainForm();
                    mf.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Text = "UserName";
                    txtPass.Text = "PassWord";
                    txtUser.ForeColor = Color.SeaGreen;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
