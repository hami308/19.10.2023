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

namespace GiaoDien_qlpks
{
    public partial class Datsanpham : Form
    {
        public Datsanpham()
        {
            InitializeComponent();
            loaddichvulist();

        }
        void loaddichvulist()
        {
            string query = "SELECT * FROM [dbo].[Table_SANPHAM]";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbmkh.Text) && !string.IsNullOrEmpty(tbid.Text) && nbsoluong.Value!=0)
            {
                string query = $"INSERT INTO [dbo].[Table_DATSANPHAM] (MAKHACHHANG, IDSANPHAM, SOLUONG) VALUES ('{tbmkh.Text}', '{tbid.Text}', {nbsoluong.Value})";

                DataProvider provider = new DataProvider();
                provider.ExecuteQuery(query);
                tbmkh.Text = "";
                tbid.Text = "";
                tbtensp.Text = "";
                tbgia.Text = "";
                tbtongtien.Text = "";
                nbsoluong.Value = 0;

                MessageBox.Show("Đặt sản phẩm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {

            string query = $"SELECT * FROM [dbo].[Table_SANPHAM] WHERE TENSANPHAM='{tbtim.Text}'";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
            if (string.IsNullOrEmpty(tbtim.Text))
            {
                loaddichvulist();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbtensp.Text = row.Cells["TENSANPHAM"].Value.ToString();
                tbgia.Text = row.Cells["DONGIA"].Value.ToString();
                tbid.Text =row.Cells["IDSANPHAM"].Value.ToString();    
                
            }

        }

        private void tbtongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void nbsoluong_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbgia.Text, out decimal gia) && gia >= 0 && decimal.TryParse(nbsoluong.Value.ToString(), out decimal soluong) && soluong >= 0)
            {
                decimal tongtien = soluong * gia;
                tbtongtien.Text = tongtien.ToString();
            }
        }
    }
}
