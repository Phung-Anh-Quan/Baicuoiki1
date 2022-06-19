using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BaiCuoiKi
{
    public partial class DangNhap : Form
    {

        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlDataReader reader;
        private string sqlstr;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString.ToString();
            try
            {
                conn.Open();

                string tk = txtDn.Text;
                string mk = txtDk.Text;
                string sql = string.Format("select * from DangNhap where TenDn='{0}'And MatKhau='{1}'", tk,mk);
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Trangquanly ql = new Trangquanly();
                    ql.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            



        }
    }
}
