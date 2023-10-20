using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Modify
{
    internal class UsetNguyenLieu
    {
        public UsetNguyenLieu()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tNguyenLieu> tNguyenLieus(string query) //dùng để kiểm tra
        {
            List<Models.tNguyenLieu> tNguyenLieus = new List<Models.tNguyenLieu>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tNguyenLieus.Add(new Models.tNguyenLieu(dataReader.GetString(0), dataReader.GetString(1),
                                                    dataReader.GetString(2), dataReader.GetString(3),
                                                    dataReader.GetString(4), dataReader.GetFloat(5),
                                                    dataReader.GetString(6)));
                }
                sqlConnection.Close();
            }
            return tNguyenLieus;
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
