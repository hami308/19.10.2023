using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tienphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Timkiem_Click(object sender, EventArgs e)
        {
            string MKH = tbmakhachhang.Text;
            string query = $@"SELECT KH.TENKHACHHANG, KH.SOPHONG, DATEDIFF(DAY, DP.NGAYDAT, GETDATE()) AS SO_NGAY_LUU_TRU, LP.DONGIA, DSP.IDSANPHAM, DSP.SOLUONG, SPA.DONGIA AS GIA
                FROM [dbo].[Table.KHACHHANG] AS KH
                INNER JOIN [dbo].[Table_DATPHONG] AS DP ON KH.MAKHACHHANG = DP.MAKHACHHANG
                INNER JOIN [dbo].[Table_SOPHONG] AS SP ON SP.SOPHONG = KH.SOPHONG 
                INNER JOIN [dbo].[Table_IDLOAIPHONG] AS LP ON LP.IDLOAIPHONG = SP.IDLOAIPHONG    
                LEFT JOIN [dbo].[Table_DATSANPHAM] AS DSP ON DSP.MAKHACHHANG = KH.MAKHACHHANG
                LEFT JOIN [dbo].[Table_SANPHAM] AS SPA ON SPA.IDSANPHAM = DSP.IDSANPHAM
                WHERE KH.MAKHACHHANG = '{MKH}'";

            DataProvider provider = new DataProvider();
            double tongtienSanPham = 0;

            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
                while (reader.Read())
                {
                    tbtenkhachhang.Text = reader["TENKHACHHANG"].ToString();
                    tbsophong.Text = reader["SOPHONG"].ToString();
                    tbsongayluutru.Text = reader["SO_NGAY_LUU_TRU"].ToString();
                    double dongia = Convert.ToDouble(reader["DONGIA"].ToString());
                    int songayluutru = Convert.ToInt32(tbsongayluutru.Text);
                    double tienphong = dongia * songayluutru;
                    tbtienphong.Text = tienphong.ToString();

                    if (reader["IDSANPHAM"] != DBNull.Value && reader["SOLUONG"] != DBNull.Value)
                    {
                        double gia = Convert.ToDouble(reader["GIA"].ToString());
                        int soluong = Convert.ToInt32(reader["SOLUONG"].ToString());
                        double tiensanpham1 = soluong * gia;
                        tongtienSanPham += tiensanpham1;
                    }

                    tiensanpham.Text = tongtienSanPham.ToString();
                    double tong = tongtienSanPham + tienphong;
                    Tongtien.Text = tong.ToString();
                }

            }
        }

        private void Tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsophong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabthanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tiensanpham_TextChanged(object sender, EventArgs e)
        {

        }
        private void Thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {   
                    string maKH = tbmakhachhang.Text;
                    DataProvider provider = new DataProvider();
                    string queryupdate = $"UPDATE [dbo].[Table_SOPHONG] SET TRANGTHAI=1 WHERE SOPHONG='{tbsophong.Text}'";
                    provider.ExecuteQuery(queryupdate);

                    string querychuyenKH = $@"INSERT INTO [dbo].[Table_KHACHHANGCU] (MAKHACHANG, TENKHACHHANG, SĐT,CCCD, SOPHONG, NGAYDAT, NGAYTRADUKIEN, NGAYTRATHUCTE)
                         SELECT KH.MAKHACHHANG, KH.TENKHACHHANG, KH.SĐT,KH.CCCD, KH.SOPHONG, DP.NGAYDAT, DP.NGAYTRADUKIEN, GETDATE() AS NGAYTRATHUCTE
                         FROM [dbo].[Table.KHACHHANG] AS KH
                         INNER JOIN [dbo].[Table_DATPHONG] AS DP ON KH.MAKHACHHANG = DP.MAKHACHHANG
                         WHERE KH.MAKHACHHANG = '{maKH}'";

                    provider.ExecuteQuery(querychuyenKH);
                    string query1 = $"DELETE FROM [dbo].[Table_DATSANPHAM] WHERE MAKHACHHANG ='{maKH}'";
                    provider.ExecuteQuery(query1);
                    string query2 = $"DELETE FROM [dbo].[Table_DATPHONG] WHERE MAKHACHHANG ='{maKH}'";
                    provider.ExecuteQuery(query2);
                    string queryxoaKH = $"DELETE FROM [dbo].[Table.KHACHHANG] WHERE MAKHACHHANG ='{maKH}'";
                    provider.ExecuteQuery(queryxoaKH);

                    MessageBox.Show("Thanh toán thành công !", "Thông báo");
                    tbmakhachhang.Text = "";
                    tbtenkhachhang.Text = "";
                    tbsophong.Text = "";
                    tbtienphong.Text = "";
                    tiensanpham.Text = "";
                    Tongtien.Text = "";
                    tbsongayluutru.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
