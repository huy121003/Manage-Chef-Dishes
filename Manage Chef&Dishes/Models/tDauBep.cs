using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tDauBep
    {
        private string madaubep;
        private string tendaubep;
        private string diachi;
        private int gioitinh;
        private string sodienthoai;
        private string noihoc;
        private string trinhdo;


        public tDauBep()
        {
        }

        public tDauBep(string madaubep,string tendaubep,string diachi,int gioitinh,string sodienthoai,string noihoc,string trinhdo) { 
            this.madaubep = madaubep;
            this.tendaubep = tendaubep;
            this.diachi = diachi;
            this.gioitinh= gioitinh;
            this.sodienthoai= sodienthoai;
            this.noihoc= noihoc;
            this.trinhdo= trinhdo;
        }

        public string MaDauBep { get => madaubep; set => madaubep = value; }
        public string TenDauBep { get => tendaubep; set => tendaubep = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public int GioiTinh { get => gioitinh; set => gioitinh = value; }
        public string SoDienThoai { get => sodienthoai; set => sodienthoai = value; }
        public string NoiHoc { get => noihoc; set => noihoc = value; }
        public string TrinhDo { get => trinhdo; set => trinhdo = value; }

    }
}
