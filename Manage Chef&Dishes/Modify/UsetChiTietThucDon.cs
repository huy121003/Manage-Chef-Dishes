using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Manage_Chef_Dishes.Modify
{
    internal class UsetChiTietThucDon
    {
        public UsetChiTietThucDon()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tChiTietThucDon> tChiTietThucDons(string query) //dùng để kiểm tra
        {
            List<Models.tChiTietThucDon> tChiTietThucDons = new List<Models.tChiTietThucDon>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                   tChiTietThucDons.Add(new Models.tChiTietThucDon(dataReader.GetString(0), dataReader.GetString(1),
                                                    dataReader.GetString(2), dataReader.GetString(3),
                                                    dataReader.GetInt32(4), dataReader.GetFloat(5)));
                }
                sqlConnection.Close();
            }
            return tChiTietThucDons;
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
