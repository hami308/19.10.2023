using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class quanlyphong : Form
    {
        public quanlyphong()
        {
            InitializeComponent();
            string query = "SELECT SOPHONG FROM [dbo].[Table_SOPHONG]";
            DataProvider provider = new DataProvider();
            DataTable dataTable = provider.ExecuteQuery(query);
            cbchonphong.DataSource = dataTable;
            cbchonphong.DisplayMember = "SOPHONG";
            cbchonphong.ValueMember = "SOPHONG";
        }
        void loadphong(string selectedPhong)
        {
            if (string.IsNullOrEmpty(selectedPhong)) { return; }
            string query = "";
            if (selectedPhong == "Danh sách phòng trống")
            {
                query = "SELECT SOPHONG FROM [dbo].[Table_SOPHONG] WHERE TRANGTHAI = 1 ";
            }

            if (selectedPhong == "Danh sách phòng đã đặt")
            {
                query = "SELECT SOPHONG FROM [dbo].[Table_SOPHONG] WHERE TRANGTHAI = 0 ";
            }
            DataProvider provider = new DataProvider();
            dtgvdanhsachphong.DataSource = provider.ExecuteQuery(query);

        }

        private void tabkiemtra_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cbxem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxem.SelectedItem != null)
            {
                string? selectedPhong = cbxem.SelectedItem.ToString();
                if (selectedPhong != null)
                {
                    loadphong(selectedPhong);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbchonphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sophong = (int)cbchonphong.SelectedValue;
            string query = $"SELECT TRANGTHAI, IDLOAIPHONG, VESINHPHONG FROM [dbo].[Table_SOPHONG] WHERE SOPHONG = '{sophong}'";
            DataProvider provider = new DataProvider();
            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    string? trangthai1 = reader["TRANGTHAI"].ToString();
                    string? loaiphong1 = reader["IDLOAIPHONG"].ToString();
                    string? vesinhphong1 = reader["VESINHPHONG"].ToString();
                    if (!string.IsNullOrEmpty(trangthai1) && !string.IsNullOrEmpty(vesinhphong1) && ! string.IsNullOrEmpty(loaiphong1))
                    {

                        if (trangthai1=="FALSE")
                        {
                            trangthai.Text = "PHÒNG ĐÃ ĐƯỢC ĐẶT";
                        }
                        else if (trangthai1.Equals("TRUE", StringComparison.OrdinalIgnoreCase))
                        {
                            trangthai.Text = "PHÒNG CÒN TRỐNG";
                        }
                        else
                        {
                            trangthai.Text = "TRẠNG THÁI KHÔNG XÁC ĐỊNH";
                        }

                        if (vesinhphong1.Equals("TRUE", StringComparison.OrdinalIgnoreCase))
                        {
                            vesinhphong.Text = "PHÒNG ĐÃ ĐƯỢC DỌN DẸP";
                        }
                        else if (vesinhphong1.Equals("FALSE", StringComparison.OrdinalIgnoreCase))
                        {
                            vesinhphong.Text = "PHÒNG CHƯA ĐƯỢC DỌN DẸP";
                        }
                        else
                        {
                            vesinhphong.Text = "VESINHPHONG KHÔNG XÁC ĐỊNH";
                        }

                        if (loaiphong1.Equals("1", StringComparison.OrdinalIgnoreCase))
                        {
                            loaiphong.Text = "PHÒNG ĐƠN (VIP)";
                        }
                        else if (loaiphong1.Equals("2", StringComparison.OrdinalIgnoreCase))
                        {
                            loaiphong.Text = "PHÒNG ĐƠN (THƯỜNG)";
                        }
                        else if (loaiphong1.Equals("3", StringComparison.OrdinalIgnoreCase))
                        {
                            loaiphong.Text = "PHÒNG ĐÔI (VIP)";
                        }
                        else if (loaiphong1.Equals("4", StringComparison.OrdinalIgnoreCase))
                        {
                            loaiphong.Text = "PHÒNG ĐÔI (THƯỜNG)";
                        }

                        else
                        {
                            loaiphong.Text = "LOAIPHONG KHÔNG XÁC ĐỊNH";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu phù hợp");
                }

            }

        }

        private void btcapnhap_Click(object sender, EventArgs e)
        {
            int vesinhphong1 = radioButton1.Checked ? 1 : 0;
            int sophong = (int)cbchonphong.SelectedValue;
            string query = $"UPDATE [dbo].[Table_SOPHONG] SET VESINHPHONG ='{vesinhphong1}' WHERE SOPHONG = '{sophong}' ";
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery(query);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            loaiphong.Text = string.Empty;
            trangthai.Text = string.Empty;
            vesinhphong.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void quanlyphong_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
