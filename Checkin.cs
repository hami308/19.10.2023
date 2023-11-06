﻿using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbcccd_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbsophong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void btcheckin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbten.Text) && !string.IsNullOrEmpty(tbsđt.Text) && !string.IsNullOrEmpty(tbcccd.Text) && cbsophong.SelectedItem != null)
                {
                    int sophong = (int)cbsophong.SelectedValue;
                    //MessageBox.Show("Giá trị của cbsophong.SelectedItem: " + sophong);

                    DataProvider provider = new DataProvider();
                    string insertKhachHangQuery = $"INSERT INTO [dbo].[Table.KHACHHANG] (TENKHACHHANG, SĐT, CCCD, SOPHONG) OUTPUT INSERTED.MAKHACHHANG VALUES ('{tbten.Text}', '{tbsđt.Text}', '{tbcccd.Text}', '{sophong}')";

                    int MaKhachHang = Convert.ToInt32(provider.ExecuteScalar(insertKhachHangQuery));
                    string ngayDatFormatted = ngaydat.Value.ToString("yyyy-MM-dd");
                    string ngayTraFormatted = ngaytra.Value.ToString("yyyy-MM-dd");
                    string insertDatphongQuery = $"INSERT INTO [dbo].[Table_DATPHONG] (MAKHACHHANG, NGAYDAT, NGAYTRA) VALUES ('{MaKhachHang}', '{ngayDatFormatted}', '{ngayTraFormatted}')";

                    provider.ExecuteQuery(insertDatphongQuery);

                    MessageBox.Show("Đặt phòng thành công! ", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
        }


        private void ngaydat_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloaiphong.SelectedItem != null)
            {
                string? loaiphong = cbloaiphong.SelectedItem.ToString();
                int LoaiPhong;

                if (int.TryParse(loaiphong, out LoaiPhong))
                {
                    // Giá trị loaiPhong là số nguyên hợp lý, bạn có thể sử dụng nó ở đây
                    // Truy vấn cơ sở dữ liệu để lấy danh sách phòng thoả mãn điều kiện.
                    string query = $"SELECT SOPHONG FROM [dbo].[Table_SOPHONG] WHERE IDLOAIPHONG  = '{loaiphong}' AND TRANGTHAI = 1";
                    DataProvider provider = new DataProvider();
                    DataTable dataTable = provider.ExecuteQuery(query);

                    // Hiển thị danh sách phòng vào ComboBox số phòng.
                    cbsophong.DataSource = dataTable;
                    cbsophong.DisplayMember = "SOPHONG";
                    cbsophong.ValueMember = "SOPHONG";
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lý!", "Lỗi");
                }

            }

        }
    }
}
