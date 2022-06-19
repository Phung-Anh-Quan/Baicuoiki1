using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace BaiCuoiKi
{
    public partial class Trangquanly : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlDataReader reader;
        private string sqlstr;


       
        public void loadData()
        {
            string sql = "select * from SinhVien";
            dataGridView1.DataSource = ketnoi.getData(sql);
            string sql1 = "select * from MonHoc";
            dataGridView2.DataSource = ketnoi.getData(sql1);
           
        }
        public Trangquanly()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trangquanly_Load(object sender, EventArgs e)
        {

            ketnoi.moKetNoi();
    
            loadData();
            ketnoi.dongKetNoi();



        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SinhVien values(@MaSV,@HoVaTen,@NgaySinh ,@GioiTinh,@Email,@MaLop)";
            string[] name = { "@MaSV","@HoVaTen","@NgaySinh" ,"@GioiTinh","@Email","@MaLop" };

            bool gt = radioButton1.Checked == true ? true : false;

            object[] value = { txtSv.Text , txtHT.Text, dataNs.Value, gt, txtEmail.Text, comboBox1.Text};

            ketnoi.moKetNoi();
            ketnoi.updateData(sql, value, name, 6);
            loadData();
            ketnoi.dongKetNoi();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update SinhVien set MaSV =@MaSV , HoVaTen =@HoVaTen , NgaySinh =@NgaySinh , GioiTinh =@GioiTinh , Email =@Email , Malop =@Malop where MaSV={0}",txtSv.Text);
            string[] name = { "@MaSV", "@HoVaTen", "@NgaySinh", "@GioiTinh", "@Email", "@Malop" };

            bool gt = radioButton1.Checked == true ? true : false;
            object[] value = { txtSv.Text, txtHT.Text, dataNs.Value, gt , txtEmail.Text, comboBox1.Text };

            ketnoi.moKetNoi();
            ketnoi.updateData(sql,value,name, 6);
            loadData();
            ketnoi.dongKetNoi();
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            txtSv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHT.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dataNs.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            string gt = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if (gt == "True")
            {
                radioButton1.Checked = true;
            }
            else
                radioButton2.Checked = true;
            txtEmail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string msv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string sql = string.Format("delete from SinhVien where MaSV ='{0}'", msv);
                    object[] value = { };
                    string[] name = { };

                    ketnoi.moKetNoi();
                    ketnoi.updateData(sql, value, name, 0);
                    loadData();
                    ketnoi.dongKetNoi();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i1 = dataGridView2.CurrentCell.RowIndex;
            if (i1 >= 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string mmh = dataGridView2.Rows[i1].Cells[0].Value.ToString();
                    string sql = string.Format("delete from MonHoc where MaMH ='{0}'", mmh);
                    object[] value = { };
                    string[] name = { };

                    ketnoi.moKetNoi();
                    ketnoi.updateData(sql, value, name, 0);
                    loadData();
                    ketnoi.dongKetNoi();
                }
            }

        }
   
        public int ktraMaMH(string ma)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString;
            conn.Open();
            string sql = string.Format("select count(*) from MonHoc where MaMH ='{0}'", ma.Trim());
            SqlCommand cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            conn.Close();
            return sl;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ktraMaMH(txtMmh.Text) == 0)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString;
                conn.Open();//mở kết nối
                string mmh = txtMmh.Text;
                string  tmh = txtMh.Text;
                string stc = cbtc.Text;
                string stlt = txtLT.Text;
                string stth = txtTh.Text;
                //xây dựng câu lệnh sql
                string sql = "INSERT into MonHoc values('" + mmh + "','" +tmh + "','" + stc+ "','" + stlt + "','" + stth + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
                loadData();
                conn.Close();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update MonHoc set MaMH =@MaMh , TenMH =@TenMH , STC =@STC , SoTietLT =@LT , SoTietTH =@TH where MaMH={0}", txtMmh.Text);
            string[] name = { "@MaMH", "@TenMH", "@STC", "@LT", "@TH" };
            object[] value = { txtMmh.Text, txtMh.Text, cbtc.Text, txtLT.Text, txtTh.Text };

            ketnoi.moKetNoi();
            ketnoi.updateData(sql, value, name, 5);
            loadData();
            ketnoi.dongKetNoi();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView2.CurrentCell.RowIndex;
            txtMmh.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtMh.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cbtc.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtLT.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txtTh.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
        }
    }
 }

        

