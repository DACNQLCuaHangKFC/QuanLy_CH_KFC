using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1.GUI
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            cboQuyen.ValueMember = "Value";
            cboQuyen.DisplayMember = "Text";
            var items = new[]
            {
                new { Text = "Windows Authentication", Value = "1" },
                new { Text = "SQL Server Authentication", Value = "2" },
            };
            cboQuyen.DataSource = items;

        }

        private void btnLayDSDatabase_Click(object sender, EventArgs e)
        {
            string connString = null;

            if (cboQuyen.SelectedIndex == 0)
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                SqlDataAdapter dA = new SqlDataAdapter("SELECT name FROM sys.databases WHERE name not in('master','model','msdb','tempdb')", conn);
                DataTable dt = new DataTable();
                dA.Fill(dt);
                dA.Dispose();
                conn.Close();

                cboDatabase.DataSource = dt;
                cboDatabase.DisplayMember = "name";
                cboDatabase.ValueMember = "name";

                btnLayDSDatabase.Enabled = false;
                lblSeverName.Enabled = false;
                txtServerName.Enabled = false;
                btnKetnoi.Enabled = true;
                cboQuyen.Enabled = false;
                lblPassword.Enabled = false;
                lblUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
            }
            catch (Exception ex)
            {
                btnKetnoi.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKetnoi_Click(object sender, EventArgs e)
        {
            if (cboDatabase.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn 1 CSDL.");
                return;
            }

            string connString = null;
            if (cboQuyen.SelectedIndex == 0)
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cboDatabase.SelectedValue.ToString() + ";Integrated Security=True";
            }
            else
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cboDatabase.SelectedValue.ToString() + ";User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }

            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("TESTCONNECTION", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = command.ExecuteReader();
                bool flag = false;

                while (dataReader.Read())
                {
                    if (dataReader[0].ToString().Equals("True"))
                    {
                        flag = true;
                    }
                    break;
                }
                conn.Close();

                if (flag)
                {
                    flag = false;
                    File.WriteAllText("config.env", connString);
                    this.Hide();
                    new frmKiemTraDB().Show();
                }
                else
                {
                    MessageBox.Show("Không thể đọc file config. Vui lòng kiểm tra và thử lại.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Vui lòng cấp quyền ghi file config.env.\n" + ex.Message);
                return;
            }
        }

        private void frmKetNoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
