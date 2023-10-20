using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tMonAn
    {
        private string mamonan;
        private string maloai;
        private string macongdung;
        private string tenmonan;
        private float dongia;
        private string cachlam;
        private string yeucau;


        public tMonAn()
        {
        }

        public tMonAn(string mamonan, string maloai, string macongdung, string tenmonan, float dongia, string cachlam, string yeucau)
        {
            this.mamonan = mamonan;
            this.maloai = maloai;
            this.macongdung = macongdung;
            this.tenmonan = tenmonan;
            this.dongia = dongia;
            this.cachlam = cachlam;
            this.yeucau = yeucau;
        }

        public string MaMonAn { get => mamonan; set => mamonan = value; }
        public string MaLoai { get => maloai; set => maloai = value; }
        public string MaCongDung { get => macongdung; set => macongdung = value; }
        public string TenMonAn { get => tenmonan; set => tenmonan = value; }
        public float DonGia { get => dongia; set => dongia = value; }
        public string CachLam { get => cachlam; set => cachlam = value; }
        public string YeuCau { get => yeucau; set => yeucau = value; }
    }
}
