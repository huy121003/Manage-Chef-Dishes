using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Modify
{
    internal class UsetXepLoai
    {
        public UsetXepLoai()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tXepLoai> tXepLoais(string query) //dùng để kiểm tra
        {
            List<Models.tXepLoai> tXepLoais = new List<Models.tXepLoai>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tXepLoais.Add(new Models.tXepLoai(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return tXepLoais;
        }
        public void Command(string query) //dùng thêm dữ liệu
        {
            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn
                sqlConnection.Close();

            }
        }
    }
}
