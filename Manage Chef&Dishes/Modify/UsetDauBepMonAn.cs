using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manage_Chef_Dishes.Modify
{
    internal class UsetDauBepMonAn
    {
        public UsetDauBepMonAn()
        { 
        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh sql
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng
        public List<Models.tDauBepMonAn> tDauBepMonAns(string query) //dùng để kiểm tra
        {
            List<Models.tDauBepMonAn> tDauBepMonAns = new List<Models.tDauBepMonAn>();

            using (SqlConnection sqlConnection = ConnectDataBase.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tDauBepMonAns.Add(new Models.tDauBepMonAn(dataReader.GetString(0), dataReader.GetString(1),
                                                             dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return tDauBepMonAns;
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
