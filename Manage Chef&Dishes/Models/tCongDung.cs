using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tCongDung
    {
        private string macongdung;
        private string tencongdung;
        public tCongDung()
        {
        }
        public tCongDung(string macongdung, string tencongdung)
        {
            this.macongdung = macongdung;
            this.tencongdung = tencongdung;
           
        }

        public string MaCongDung { get => macongdung; set => macongdung = value; }
        public string TenCongDung { get => tencongdung; set => tencongdung = value; }
        

    }
}
