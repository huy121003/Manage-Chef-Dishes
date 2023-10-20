using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Chef_Dishes.Modify
{
    internal class UsetCongDung
    {
        public UsetCongDung()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tCongDung> tCongDungs(string query) //dùng để kiểm tra
        {
            List<Models.tCongDung> tCongDungs = new List<Models.tCongDung>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tCongDungs.Add(new Models.tCongDung(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return tCongDungs;
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
