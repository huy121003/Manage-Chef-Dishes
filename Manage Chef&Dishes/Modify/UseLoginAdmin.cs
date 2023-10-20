using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Manage_Chef_Dishes.Modify
{
    internal class UseLoginAdmin
    {
        public UseLoginAdmin() 
        { 
        }

       

        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.LoginAdmin> loginAdmins(string query) //dùng để kiểm tra
        {     
            List<Models.LoginAdmin> loginAdmins = new List<Models.LoginAdmin>();

            using(SqlConnection sqlConnection= ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader =sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    loginAdmins.Add(new Models.LoginAdmin(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return loginAdmins;
        }
        public void Command(string query) //dùng thêm dữ liệu
        { 
            using(SqlConnection sqlConnection=ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn
                sqlConnection.Close();

            }
        }
    }
}
