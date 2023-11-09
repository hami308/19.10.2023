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
            string query = $@"SELECT KH.TENKHACHHANG, KH.SOPHONG, DATEDIFF(DAY, DP.NGAYDAT, DP.NGAYTRA) AS SO_NGAY_LUU_TRU,LP.DONGIA
                     FROM [dbo].[Table.KHACHHANG] AS KH
                     INNER JOIN [dbo].[Table_DATPHONG] AS DP ON KH.MAKHACHHANG = DP.MAKHACHHANG
                     INNER JOIN [dbo].[Table_SOPHONG] AS SP ON SP.SOPHONG = KH.SOPHONG 
                     INNER JOIN [dbo].[Table_IDLOAIPHONG] AS LP ON LP.IDLOAIPHONG =SP.IDLOAIPHONG
                     WHERE KH.MAKHACHHANG = '{MKH}'";
            DataProvider provider = new DataProvider();
            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    tbtenkhachhang.Text = reader["TENKHACHHANG"].ToString();
                    tbsophong.Text = reader["SOPHONG"].ToString();
                    tbsongayluutru.Text = reader["SO_NGAY_LUU_TRU"].ToString() ;                
                    double dongia = Convert.ToDouble(reader["DONGIA"].ToString());
                    int songayluutru = Convert.ToInt32(tbsongayluutru.Text);
                    double tienphong = dongia * songayluutru;                  
                    tbtienphong.Text = tienphong.ToString();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu phù hợp");
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

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            Form Hoadon = new Hoadon();
            this.Hide();
            Hoadon.ShowDialog();
            this.Show();
        }
    }
}
