using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Modify
{
    internal class UsetThucDon
    {
        public UsetThucDon()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tThucDon> tThucDons(string query) //dùng để kiểm tra
        {
            List<Models.tThucDon> tThucDons = new List<Models.tThucDon>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tThucDons.Add(new Models.tThucDon(dataReader.GetString(0), dataReader.GetString(1),
                                                    dataReader.GetDateTime(2), dataReader.GetFloat(3),
                                                    dataReader.GetFloat(4), dataReader.GetFloat(5) ));
                }
                sqlConnection.Close();
            }
            return tThucDons;
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
