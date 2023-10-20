using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tNguyenLieu
    {
        private string manguyenlieu;
        private string madonvitinh;
        private string macongdung;
        private string tennguyenlieu;
        private string yeucau;
        private float dongia;
        private string dinhduong;
  


        public tNguyenLieu()
        {
        }

        public tNguyenLieu(string manguyenlieu, string madonvitinh,string macongdung, string tennguyenlieu, string yeucau, float dongia, string dinhduong)
        {
            this.manguyenlieu = manguyenlieu;
            this.madonvitinh = madonvitinh;
            this.macongdung = macongdung;
            this.tennguyenlieu = tennguyenlieu;
            this.yeucau = yeucau;
            this.dongia = dongia;
            this.dinhduong = dinhduong;
            
        }

        public string MaNguyenLieu { get => manguyenlieu; set => manguyenlieu = value; }
        public string MaCongDung { get => macongdung; set => macongdung = value; }  
        public string MaDonViTinh { get => madonvitinh; set => madonvitinh = value; }
        public string TenNguyenLieu { get => tennguyenlieu; set => tennguyenlieu = value; }
        public string YeuCau { get => yeucau; set => yeucau = value; }
        public float DonGia { get => dongia; set => dongia = value; }
        public string DinhDuong { get => dinhduong; set => dinhduong = value; }      
    }
}
