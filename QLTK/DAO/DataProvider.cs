using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTK.DAO
{
    public class DataProvider
    {
        //Singleton
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        public static string getDtb(string data)
        {
            if (data.Equals("CHI NHÁNH 1"))
                return @"192.168.43.39,8080";
            else if (data.Equals("CHI NHÁNH 2"))
                return @"192.168.43.39,8000";
            else if (data.Equals("ADMIN"))
                return @"192.168.43.39,1433";
            return "";
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] element = null)
        {           
            string str = @"Data Source =" + getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname + ";Password=" + LoginForm.passwd;
            DataTable data = new DataTable();
            //Đảm bảo việc thực thi
            using (SqlConnection conn = new SqlConnection(str))
            {            
                conn.Open();
                ////Thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (element != null)
                {
                    string[] listElement = query.Split(' ');
                    int i = 0;
                    foreach (string item in listElement)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, element[i]);
                            i++;
                        }
                    }
                }
                conn.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

            }
            return data;
        }

        //Kiểm tra insert
        public int ExecuteNonQuery(string query, object[] element = null)
        {
            string str = @"Data Source =" + getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname + ";Password=" + LoginForm.passwd;
            int data;
            //Đảm bảo việc thực thi
            using (SqlConnection conn = new SqlConnection(str))
            {
                data = 0;
                conn.Open();
                ////Thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, conn);
                //Console.WriteLine("Open connect..");

                if (element != null)
                {
                    string[] listElement = query.Split(' ');
                    int i = 0;
                    foreach (string item in listElement)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, element[i]);
                            i++;
                        }
                    }
                }



                data = command.ExecuteNonQuery();

                Console.WriteLine(data);
                conn.Close();
            }
            return data;
        }
        //Lấy dữ liệu đầu tiên
        public object ExecuteScalar(string query, object[] element = null)
        {
            string str = @"Data Source =" + getDtb(LoginForm.chinhanh) + "; Initial Catalog = QLTK;User ID=" + LoginForm.uname + ";Password=" + LoginForm.passwd;
            object data = 0;
            //Đảm bảo việc thực thi
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                ////Thực thi câu truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (element != null)
                {
                    string[] listElement = query.Split(' ');
                    int i = 0;
                    foreach (string item in listElement)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, element[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
