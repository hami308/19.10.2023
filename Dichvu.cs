using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien_qlpks
{
    public partial class Dichvu : Form
    {
        public Dichvu()
        {
            InitializeComponent();
            loaddichvulist();
        }
         void loaddichvulist()
        {
            string query = "SELECT * FROM [dbo].[Table_SANPHAM]";
            DataProvider provider = new DataProvider();
            dtgvdichvu.DataSource = provider.ExecuteQuery(query);
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {

        }

        private void btcapnhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tensanpham.Text) && !string.IsNullOrEmpty(dongia.Text))
            {
                string query = $"UPDATE [dbo].[Table_SANPHAM] SET DONGIA = '{dongia.Text}' WHERE TENSANPHAM = '{tensanpham.Text}'";
                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);
                loaddichvulist();
                tensanpham.Text = "";
                dongia.Text = "";
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin !");
            }
        }


        private void xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tensanpham.Text) && !string.IsNullOrEmpty(dongia.Text))
            {
                string tensp = tensanpham.Text;
                string gia = dongia.Text;

                string query = $"DELETE FROM [dbo].[Table_SANPHAM] WHERE TENSANPHAM = '{tensp}' AND DONGIA = '{gia}'";

                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);

                loaddichvulist();

                tensanpham.Text = "";
                dongia.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgvdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvdichvu.Rows[e.RowIndex];
                tensanpham.Text = row.Cells["TENSANPHAM"].Value.ToString();
                dongia.Text = row.Cells["DONGIA"].Value.ToString();
            }
        }
        
        private void Them_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tensanpham.Text) && !string.IsNullOrEmpty(dongia.Text))
            {
                DataProvider provider = new DataProvider();
                string tensp = tensanpham.Text;
                string gia = dongia.Text;
                string query = $"SELECT COUNT(*) FROM [dbo].[Table_SANPHAM] WHERE TENSANPHAM ='{tensp}'";
                if (!provider.Kiemtra(query))
                {
                    string queryinsert = $"INSERT INTO [dbo].[Table_SANPHAM] (TENSANPHAM, DONGIA) VALUES ('{tensp}', '{gia}')";
                    provider.ExecuteQuery(queryinsert);

                    loaddichvulist();

                    tensanpham.Text = "";
                    dongia.Text = "";
                } 
                else
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo !");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }
    }
}
