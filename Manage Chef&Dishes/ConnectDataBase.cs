using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Manage_Chef_Dishes
{
     class ConnectDataBase
    {
      
        public static String strConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLDauBep_MonAn;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }
        
        // huy hieu da ma tich
            
    }
}
