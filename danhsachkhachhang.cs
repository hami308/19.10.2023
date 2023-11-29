using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien_qlpks
{
    public partial class danhsachkhachhang : Form
    {
        public danhsachkhachhang()
        {
            InitializeComponent();
            loadkhachhanglist();
        }
        void loadkhachhanglist()
        {
            string query = "SELECT * FROM [dbo].[Table.KHACHHANG]";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbmakhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbmakhachhang.Text = row.Cells["MAKHACHHANG"].Value.ToString();
                tbtenkhach.Text = row.Cells["TENKHACHHANG"].Value.ToString();
                tbsđt.Text = row.Cells["SĐT"].Value.ToString();
                tbcccd.Text = row.Cells["CCCD"].Value.ToString();
                sophong.Text = row.Cells["SOPHONG"].Value.ToString();

            }
        }

        private void tbtenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtenkhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void chinhsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmakhachhang.Text) && !string.IsNullOrEmpty(tbtenkhach.Text) && !string.IsNullOrEmpty(tbsđt.Text) && !string.IsNullOrEmpty(tbcccd.Text) && !string.IsNullOrEmpty(sophong.Text))
            {
                string query = $"UPDATE [dbo].[Table.KHACHHANG] SET TENKHACHHANG = '{tbtenkhach.Text}',SĐT = '{tbsđt.Text}',CCCD = '{tbcccd.Text}',SOPHONG = '{sophong.Text}' WHERE MAKHACHHANG = '{tbmakhachhang.Text}'";
                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);
                loadkhachhanglist();
                tbmakhachhang.Text = "";
                tbtenkhach.Text = "";
                tbcccd.Text = "";
                tbsđt.Text = "";
                sophong.Text = "";
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin !");
            }
        }

        private void tbidphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"SELECT COUNT(*) FROM [dbo].[Table.KHACHHANG] WHERE SOPHONG ='{tbsophong.Text}'";
            if (provider.Kiemtra(query))
            {

                string query1 = $"SELECT * FROM [dbo].[Table.KHACHHANG] WHERE SOPHONG='{tbsophong.Text}'";
                dataGridView1.DataSource = provider.ExecuteQuery(query1);
            }
            else
            {
                MessageBox.Show("Không tìm thấy số phòng hợp lệ!", "Thông báo!");
            }
        }
    }
}
