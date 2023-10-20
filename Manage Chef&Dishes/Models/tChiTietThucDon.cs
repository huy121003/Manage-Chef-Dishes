using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tChiTietThucDon
    {
        private string mamonan;
        private string madaubep;
        private string mathucdon;       
        private string maloai;
        private int soluong;
        private float thanhtien;
        


        public tChiTietThucDon()
        {
        }

        public tChiTietThucDon(string mamonan, string madaubep, string mathucdon, string maloai, int soluong, float thanhtien)
        {
            this.mamonan = mamonan;
            this.madaubep = madaubep;
            this.mathucdon = mathucdon;
            this.maloai = maloai;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
            
        }
        public string MaMonAn { get => mamonan; set => mamonan = value; }
        public string MaDauBep { get => madaubep; set => madaubep = value; }
        public string MaThucDon { get => mathucdon; set => mathucdon = value; }
        public string MaLoai { get => maloai; set => maloai = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
        public float ThanhTien { get => thanhtien; set => thanhtien = value; }
       
    }
}
