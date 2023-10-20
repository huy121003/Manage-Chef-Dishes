using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tThucDon
    {
        private string mathucdon;
        private string makhachhang;
        private DateTime ngaydatban;
        private float thueVAT;
        private float giamgia;
        private float tongtien;
       

        public tThucDon()
        {
        }

        public tThucDon(string mathucdon, string makhachhang, DateTime ngaydatban, float thueVAT, float giamgia, float tongtien)
        {
            this.mathucdon = mathucdon;
            this.makhachhang = makhachhang;
            this.ngaydatban = ngaydatban;
            this.thueVAT = thueVAT;
            this.giamgia= giamgia;
            this.tongtien = tongtien;
        }

        public string MaThucDon { get => mathucdon; set => mathucdon = value; }
        public string MaKhachHang { get => makhachhang; set => makhachhang = value; }
        public DateTime NgayDatBan { get => ngaydatban; set => ngaydatban = value; }
        public float ThueVAT { get => thueVAT; set => thueVAT = value; }
        public float GiamGia { get => giamgia; set => giamgia = value; }
        public float TongTien { get => tongtien; set => tongtien = value; }
       
    }
}
