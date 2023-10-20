using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Models
{
    internal class LoginAdmin
    {
        private string username;
        private string password;
        private string email;

        public LoginAdmin()
        {
        }

        public LoginAdmin(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }

       public string UserName { get => username;set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; } 
    }
}
