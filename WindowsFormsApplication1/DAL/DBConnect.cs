using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1.DAL
{
    public class DBConnect
    {
        // Chuỗi kết nối tới SQL Server
        private string connectionString = "Server=JUSTBREN\\SQLEXPRESS;Database=WindowsFormsApplication1;User Id=sa;Password=123;";
        SqlConnection connection = new SqlConnection(File.ReadAllText("config.env"));
        // Phương thức mở kết nối
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(File.ReadAllText("config.env"));
            try
            {
                connection.Open();
                //MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối với cơ sở dữ liệu: " + ex.Message);
                connection = null;  // Đặt null nếu kết nối thất bại
            }

            return connection;
        }

        // Phương thức đóng kết nối
        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("Đã đóng kết nối.");
            }
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Phương thức thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                if (connection == null)
                {
                    return -1; // Trả về -1 nếu không thể kết nối
                }

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                    return -1;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            using (SqlConnection connection = GetConnection())
            {
                if (connection == null)
                {
                    return -1; // Trả về -1 nếu không thể kết nối
                }

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = commandType; // Xác định loại câu lệnh

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters); // Thêm tham số vào câu lệnh
                    }
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                    return -1;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
        }

        // Phương thức thực thi câu lệnh SQL và trả về dữ liệu (SELECT)
        public SqlDataReader ExecuteReader(string query)
        {
            SqlConnection connection = GetConnection();
            if (connection == null) return null;

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteReader(CommandBehavior.CloseConnection); // Đảm bảo đóng kết nối khi reader bị đóng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                CloseConnection(connection); // Đóng nếu có lỗi
                return null;
            }
        }

        public SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
        {
            SqlConnection connection = GetConnection();
            if (connection == null)
            {
                return null; // Trả về null nếu không thể kết nối
            }

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure; // Xác định kiểu là stored procedure

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters); // Thêm tham số vào câu lệnh
                }

                SqlDataReader reader = command.ExecuteReader();
                return reader; // Trả về SqlDataReader để xử lý dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                return null;
            }
        }

        public DataTable TableRead(string query)
        {
            SqlConnection connection = GetConnection();
            if (connection == null)
            {
                return null; // Trả về null nếu không thể kết nối
            }

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnection(connection);
            }
        }

        public void AED(string query)
        {
            SqlConnection cn = GetConnection();
            SqlCommand command = new SqlCommand(query, cn);
            command.ExecuteNonQuery();
            command.Dispose();
            CloseConnection(cn);
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null, CommandType commandType = CommandType.Text)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                if (connection == null) return null;

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message);
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
            return dataTable;
        }
    }
}
