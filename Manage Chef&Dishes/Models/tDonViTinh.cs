using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Manage_Chef_Dishes.Models
{
    internal class tDonViTinh
    {
        private string madonvitinh;
        private string tendonvitinh;

        public tDonViTinh()
        {
        }

        public tDonViTinh(string madonvitinh, string tendonvitinh)
        {
            this.madonvitinh = madonvitinh;
            this.tendonvitinh = tendonvitinh;           
        }

        public string MaDonViTinh { get => madonvitinh; set => madonvitinh = value; }
        public string TenDonViTinh { get => tendonvitinh; set => tendonvitinh = value; }
       
    }
}
