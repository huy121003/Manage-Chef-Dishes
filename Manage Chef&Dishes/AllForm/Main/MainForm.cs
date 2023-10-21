using Manage_Chef_Dishes.AllForm.Login;
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

       

        private void button5_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 5;
                if(sidebar.Width<= 83)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnDish.Width = sidebar.Width;
                    pnChef.Width = sidebar.Width;
                    pnStatistic.Width = sidebar.Width;
                    pnSetting.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;



                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 250)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnDish.Width = sidebar.Width;
                    pnChef.Width = sidebar.Width;
                    pnStatistic.Width = sidebar.Width;
                    pnSetting.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;

                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start ();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool isFullScreen = false;
        private void btnNo_Click(object sender, EventArgs e)
            
        {
            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            isFullScreen = !isFullScreen;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(181, 181, 181);
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }

        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }
      
    }
}
