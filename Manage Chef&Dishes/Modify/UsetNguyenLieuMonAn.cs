using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Chef_Dishes.Modify
{
    internal class UsetNguyenLieuMonAn
    {
        public UsetNguyenLieuMonAn()
        {
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tNguyenLieuMonAn> tNguyenLieuMons(string query) //dùng để kiểm tra
        {
            List<Models.tNguyenLieuMonAn> tNguyenLieuMonAns = new List<Models.tNguyenLieuMonAn>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tNguyenLieuMonAns.Add(new Models.tNguyenLieuMonAn(dataReader.GetString(0), dataReader.GetString(1),
                                                    dataReader.GetInt32(2)));
                }
                sqlConnection.Close();
            }
            return tNguyenLieuMonAns;
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
