using Manage_Chef_Dishes.Models;
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
    public partial class DashboardForm : Form
    {
        Modify.Modify modify= new Modify.Modify();  
        public DashboardForm()
        {
            InitializeComponent();
        }

        
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
           lbTongHD.Text = modify.Table("select count(MaThucDon)\r\nfrom tThucDon").Rows[0][0].ToString();

           lbDoanhThu.Text = modify.Table("select sum(TongTien) from tThucDon").Rows[0][0].ToString();
            
            lbSLDauBep.Text= modify.Table("select count(MaDauBep) from tDauBep").Rows[0][0].ToString();
            lbSLMonAn.Text = modify.Table("select count(MaMonAn) from tMonAn").Rows[0][0].ToString();
        }

    }
}
