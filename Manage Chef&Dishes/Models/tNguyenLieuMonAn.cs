using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tNguyenLieuMonAn
    {
        private string mamonan;
        private string manguyenlieu;
        private float soluong;

        public tNguyenLieuMonAn()
        {
        }

        public tNguyenLieuMonAn(string mamonan, string manguyenlieu,float soluong)
        {
            this.mamonan = mamonan;
            this.manguyenlieu = manguyenlieu;
            this.soluong = soluong;
        }

        public string MaMonAn { get => mamonan; set => mamonan = value; }
        public string MaNguyenLieu { get => manguyenlieu; set => manguyenlieu = value; }
        public float SoLuong { get => soluong; set => soluong = value; }
    }
}
