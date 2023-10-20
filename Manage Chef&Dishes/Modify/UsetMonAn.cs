using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Modify
{
    internal class UsetMonAn
    {
        public UsetMonAn()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tMonAn> tMonAns(string query) //dùng để kiểm tra
        {
            List<Models.tMonAn> tMonAns = new List<Models.tMonAn>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tMonAns.Add(new Models.tMonAn(dataReader.GetString(0), dataReader.GetString(1),
                                                    dataReader.GetString(2), dataReader.GetString(3),
                                                    dataReader.GetFloat(4), dataReader.GetString(5),
                                                    dataReader.GetString(6)));
                }
                sqlConnection.Close();
            }
            return tMonAns;
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
