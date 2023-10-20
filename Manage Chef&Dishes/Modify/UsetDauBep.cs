using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Manage_Chef_Dishes.Modify
{
    internal class UsetDauBep
    {
        public UsetDauBep()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tDauBep> tDauBeps(string query) //dùng để kiểm tra
        {
            List<Models.tDauBep> tDauBeps = new List<Models.tDauBep>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tDauBeps.Add(new Models.tDauBep(dataReader.GetString(0), dataReader.GetString(1), 
                                                    dataReader.GetString(2), dataReader.GetInt32(3),
                                                    dataReader.GetString(4), dataReader.GetString(5),
                                                    dataReader.GetString(6)));
                }
                sqlConnection.Close();
            }
            return tDauBeps;
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
