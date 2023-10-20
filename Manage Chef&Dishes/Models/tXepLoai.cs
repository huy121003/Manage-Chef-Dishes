using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class tXepLoai
    {
        private string maxeploai;
        private string tenxeploai;
       


        public tXepLoai()
        {
        }

        public tXepLoai(string maxeploai, string tenxeploai)
        {
            this.maxeploai = maxeploai;
            this.tenxeploai = tenxeploai;
            
        }

        public string MaXepLoai { get => maxeploai; set => maxeploai = value; }
        public string TenXepLoai { get => tenxeploai; set => tenxeploai = value; }
        
    }
}
