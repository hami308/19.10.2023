using GiaoDien_qlpks.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class danhsachkhachhangcu : Form
    {
        public danhsachkhachhangcu()
        {
            InitializeComponent();

        }
        void loadkhachhangcu()
        {
            string query = $"SELECT MAKHACHANG ,TENKHACHHANG,SĐT,CCCD,SOPHONG,NGAYDAT,NGAYTRADUKIEN,NGAYTRATHUCTE FROM [dbo].[Table_KHACHHANGCU]";
            DataProvider provider = new DataProvider();
            dtgvkhcu.DataSource = provider.ExecuteQuery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query1 = $"SELECT COUNT(*) FROM [dbo].[Table_KHACHHANGCU] WHERE TENKHACHHANG='{textBox1.Text}'";
            if (provider.Kiemtra(query1))
            {
                string query = $"SELECT MAKHACHANG ,TENKHACHHANG,SĐT,CCCD,SOPHONG,NGAYDAT,NGAYTRADUKIEN,NGAYTRATHUCTE FROM [dbo].[Table_KHACHHANGCU] WHERE TENKHACHHANG='{textBox1.Text}'";
                dtgvkhcu.DataSource = provider.ExecuteQuery(query);
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    loadkhachhangcu();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên này !", "Thông báo!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            loadkhachhangcu();
        }

       
        private void dtgvkhcu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvkhcu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mkh = " ";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvkhcu.Rows[e.RowIndex];
                mkh = row.Cells["MAKHACHANG"].Value.ToString();
            }
            Form hoadon = new Hoadon(mkh);
            this.Hide();
            hoadon.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
