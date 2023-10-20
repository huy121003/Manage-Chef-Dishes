using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tLoai
    {
        private string maloai;
        private string tenloai;

        public tLoai()
        {
        }

        public tLoai(string maloai, string tenloai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
        }

        public string MaLoai { get => maloai; set => maloai = value; }
        public string TenLoai { get => tenloai; set => tenloai = value; }
    }
}
