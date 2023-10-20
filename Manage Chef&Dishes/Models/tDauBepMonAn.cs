using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tDauBepMonAn
    {
        private string madaubep;
        private string mamonan;
        private string maxeploai;

        public tDauBepMonAn()
        {
        }
        public tDauBepMonAn(string madaubep, string mamonan, string maxeploai)
        {
            this.madaubep = madaubep;
            this.mamonan = mamonan;
            this.maxeploai = maxeploai;
            
        }
        public string MaDauBep { get => madaubep; set => madaubep = value; }
        public string MaMonAn { get => mamonan; set => mamonan = value; }
        public string MaXepLoai { get => maxeploai; set => maxeploai = value; }
       
    }
}
