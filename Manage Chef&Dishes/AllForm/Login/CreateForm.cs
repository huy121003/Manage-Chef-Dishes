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
    public partial class CreateForm : Form
    {
        Modify.UseLoginAdmin useLoginAdmin = new Modify.UseLoginAdmin();
        public CreateForm()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            //
        }

        

      
        public bool checkAccount(string ac)//check tài khoản và mật khẩu
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,10}$");
        }
        public bool checkEmail(string em) {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,30}@gmail.com(.vn|)$");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string enterpass = txtEnterPass.Text;
            string email = txtEmail.Text;

            if (!checkAccount(username)) 
            { 
                MessageBox.Show("Tên tài khoản 6-10 kí tự và không có kí tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return; 
            }
            if (!checkAccount(password)) 
            { 
                MessageBox.Show("Mật khẩu 6-10 kí tự và không có kí tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return; 
            }
            if (enterpass != password) 
            { 
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return; 
            }
            if(!checkEmail(email)) 
            { 
                MessageBox.Show("Email không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return; 
            }
            if (useLoginAdmin.loginAdmins("Select * from LoginAdmin where UserName ='" + username + "'").Count != 0) 
            { 
                MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            if (useLoginAdmin.loginAdmins("Select * from LoginAdmin where Email ='" + email + "'").Count != 0) 
            { 
                MessageBox.Show("Email đã được đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return; 
            }
            try
            {
                string query = "Insert into LoginAdmin values ('" + username + "','" + password + "','" + email + "')";
                useLoginAdmin.Command(query);
                MessageBox.Show("Đăng kí thành công! ");
                txtUser.Text = "";
                txtPass.Text = "";
                txtEnterPass.Text = "";
                txtEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Tài khoản đã tồn tại !");
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
