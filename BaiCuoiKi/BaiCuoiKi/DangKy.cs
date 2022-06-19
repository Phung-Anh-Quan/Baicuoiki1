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
using System.Text.RegularExpressions;

namespace BaiCuoiKi
{
    public partial class DangKy : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlDataReader reader;
        private string sqlstr;
        public bool CheckAcount (string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail (string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }
        public DangKy()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        { 
        }
        private string check_Pass()
        {
            if (txtmk.Text == txtxn.Text)
            {
                return "true";
            }
            else
                return "false";
        }
    
    private void button1_Click(object sender, EventArgs e)
        {
            if (txtDn.Text != "" && txtmk.Text != "" && txtxn.Text !="" && txtem.Text!= "")//kiểm tra đã nhập đủ thông tin chưa
            {
                if (check_Pass() == "true")
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString.ToString();
                    conn.Open();
                    string name = txtDn.Text;
                    string pass = txtmk.Text;
                    string em = txtem.Text;
                    string sql = "INSERT into DangNhap values('" + name + "','" + pass + "','"+em+"')";//xây dựng câu lệnh sql

                    command = new SqlCommand(sql, conn);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công");
                        DangNhap dn = new DangNhap();
                        dn.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Đăng ký thất bại");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        

    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
