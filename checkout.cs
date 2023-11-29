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
    public partial class checkout : Hoadon
    {
        public checkout()
        {
            InitializeComponent();
        }

        protected void checkout_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {

        }

        protected void tabhoadon_Click(object sender, EventArgs e)
        {

        }

        protected void tbsongayluutru_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void Timkiem_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string MKH = tbmakhachhang.Text;
            string query1 = $"SELECT COUNT(*) FROM [dbo].[Table.KHACHHANG] WHERE MAKHACHHANG = '{MKH}'";
            if (provider.Kiemtra(query1))
            {
                string query = $@"SELECT KH.TENKHACHHANG, KH.SOPHONG, DATEDIFF(DAY, DP.NGAYDAT, GETDATE()) AS SO_NGAY_LUU_TRU, LP.DONGIA, DSP.IDSANPHAM, DSP.SOLUONG, SPA.DONGIA AS GIA
                FROM [dbo].[Table.KHACHHANG] AS KH
                INNER JOIN [dbo].[Table_DATPHONG] AS DP ON KH.MAKHACHHANG = DP.MAKHACHHANG
                INNER JOIN [dbo].[Table_SOPHONG] AS SP ON SP.SOPHONG = KH.SOPHONG 
                INNER JOIN [dbo].[Table_IDLOAIPHONG] AS LP ON LP.IDLOAIPHONG = SP.IDLOAIPHONG    
                LEFT JOIN [dbo].[Table_DATSANPHAM] AS DSP ON DSP.MAKHACHHANG = KH.MAKHACHHANG
                LEFT JOIN [dbo].[Table_SANPHAM] AS SPA ON SPA.IDSANPHAM = DSP.IDSANPHAM
                WHERE KH.MAKHACHHANG = '{MKH}'";

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
                        string querysp = @$"SELECT DSP.IDDATSANPHAM ,SP.TENSANPHAM,SP.DONGIA,DSP.SOLUONG,SP.DONGIA* DSP.SOLUONG AS TONG FROM[dbo].[Table_DATSANPHAM] DSP
                    INNER JOIN [dbo].[Table_SANPHAM] AS SP ON SP.IDSANPHAM = DSP.IDSANPHAM
                    WHERE MAKHACHHANG = '{MKH}' ";
                        dtgvsp.DataSource = provider.ExecuteQuery(querysp);
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
            else
            {
                MessageBox.Show("Không tìm thấy mã khách hàng này !", "Thông báo!");
            }
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbmakhachhang.Text))
                {
                    string maKH = tbmakhachhang.Text;
                    DataProvider provider = new DataProvider();
                    string queryupdate = $"UPDATE [dbo].[Table_SOPHONG] SET TRANGTHAI=1 WHERE SOPHONG='{tbsophong.Text}'";
                    provider.ExecuteQuery(queryupdate);

                    string querychuyenKH = $@"INSERT INTO [dbo].[Table_KHACHHANGCU] (MAKHACHANG, TENKHACHHANG, SĐT,CCCD, SOPHONG, NGAYDAT, NGAYTRADUKIEN, NGAYTRATHUCTE, TIENPHONG)
                                          SELECT KH.MAKHACHHANG, KH.TENKHACHHANG, KH.SĐT, KH.CCCD, KH.SOPHONG, DP.NGAYDAT, DP.NGAYTRADUKIEN, GETDATE() AS NGAYTRATHUCTE,
                                          DATEDIFF(DAY, DP.NGAYDAT, GETDATE()) * LP.DONGIA AS TIENPHONG
                                          FROM [dbo].[Table.KHACHHANG] AS KH
                                          INNER JOIN [dbo].[Table_DATPHONG] AS DP ON KH.MAKHACHHANG = DP.MAKHACHHANG  
                                          INNER JOIN [dbo].[Table_SOPHONG] AS SP ON SP.SOPHONG = KH.SOPHONG 
                                          INNER JOIN [dbo].[Table_IDLOAIPHONG] AS LP ON LP.IDLOAIPHONG = SP.IDLOAIPHONG 
                                          WHERE KH.MAKHACHHANG = '{maKH}'";

                    provider.ExecuteQuery(querychuyenKH);

                    string querychuyenSP = $@"INSERT INTO [dbo].[Table_DICHVU_CU] (MAKHACHHANG, TENSANPHAM,SOLUONG,TIENSANPHAM)
                         SELECT DSP.MAKHACHHANG, SP.TENSANPHAM,DSP.SOLUONG,DSP.SOLUONG*SP.DONGIA AS TIENSANPHAM
                         FROM [dbo].[Table_DATSANPHAM] AS DSP
                         INNER JOIN [dbo].[Table_SANPHAM] AS SP ON SP.IDSANPHAM = DSP.IDSANPHAM 
                         WHERE DSP.MAKHACHHANG = '{maKH}'";
                    provider.ExecuteQuery(querychuyenSP);

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
                    dtgvsp.DataSource = null;
                    dtgvsp.Rows.Clear();
                    dtgvsp.Columns.Clear();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng !", "Thông báo !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
