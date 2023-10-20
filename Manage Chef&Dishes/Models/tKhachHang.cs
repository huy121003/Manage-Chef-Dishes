using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tKhachHang
    {
        private string makhachhang;
        private string tenkhachhang;
        private string diachi;      
        private string sodienthoai;
        


        public tKhachHang()
        {
        }

        public tKhachHang(string makhachhang, string tenkhachhang, string diachi, string sodienthoai)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.diachi = diachi;          
            this.sodienthoai = sodienthoai;          
        }

        public string MaKhachHang { get => makhachhang; set => makhachhang = value; }
        public string TenKhachHang { get => tenkhachhang; set => tenkhachhang = value; }
        public string DiaChi { get => diachi; set => diachi = value; }      
        public string SoDienThoai { get => sodienthoai; set => sodienthoai = value; }      
    }
}
