using Manage_Chef_Dishes.AllForm.Login;
using Manage_Chef_Dishes.AllForm.Main.Dishes;
using Manage_Chef_Dishes.AllForm.Main.Chefs;
using Manage_Chef_Dishes.AllForm.Main.Statistic;
using Manage_Chef_Dishes.AllForm.Main.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Manage_Chef_Dishes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
 
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());
        }
        private void btnChef_Click(object sender, EventArgs e)
        {
            openChildForm(new ChefsForm());
        }

        private void btnDish_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DishesForm());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            openChildForm(new StatisticForm());
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingForm());
        }

        private void btnInvoice_Click_1(object sender, EventArgs e)
        {
       
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
