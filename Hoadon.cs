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
    public partial class Hoadon : Form
    {
        string mkh;
        public Hoadon(string mkh)
        {
            InitializeComponent();
            this.mkh = mkh;
            hienthihoadon(mkh);
        }
        void hienthihoadon(string mkh)
        {
            DataProvider provider = new DataProvider();
            tbmakhachhang.Text = mkh;
            double tiensp = 0;
            double tienphong = 0;
            string query = $@"SELECT TENKHACHHANG, SOPHONG, DATEDIFF(DAY, NGAYDAT, GETDATE()) AS SO_NGAY_LUU_TRU,TIENPHONG
                            FROM [dbo].[Table_KHACHHANGCU]
                            WHERE MAKHACHANG ='{mkh}'";
            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
                while (reader.Read())
                {
                    tbtenkhachhang.Text = reader["TENKHACHHANG"].ToString();
                    tbsophong.Text = reader["SOPHONG"].ToString();
                    tbsongayluutru.Text = reader["SO_NGAY_LUU_TRU"].ToString();
                    tbtienphong.Text = reader["TIENPHONG"].ToString();
                    tienphong = Convert.ToDouble(tbtienphong.Text);                   
                }
           }
            string querysp = $"SELECT TENSANPHAM,SOLUONG,TIENSANPHAM FROM [dbo].[Table_DICHVU_CU] WHERE MAKHACHHANG='{mkh}'";
            dtgvsp.DataSource=provider.ExecuteQuery(querysp);
           
            string querytinhtong = $"SELECT SUM(TIENSANPHAM) AS TIENSP FROM [dbo].[Table_DICHVU_CU] WHERE MAKHACHHANG='{mkh}'";
            using (SqlDataReader reader = provider.ExecuteReader(querytinhtong))
            {
                while (reader.Read())
                {
                    tiensanpham.Text = reader["TIENSP"].ToString();
                    if (reader["TIENSP"]!=DBNull.Value) { tiensp = Convert.ToDouble(tiensanpham.Text); }
                }
            }
            double tong = tiensp + tienphong;
            Tongtien.Text = tong.ToString();

        }
        public Hoadon()
        {
            InitializeComponent();
        }

        protected void Hoadon_Load(object sender, EventArgs e)
        {

        }

        protected void tabthanhtoan_Click(object sender, EventArgs e)
        {

        }

        protected void tabPage1_Click(object sender, EventArgs e)
        {

        }

        protected void tabhoadon_Click(object sender, EventArgs e)
        {

        }

        protected void tbmakhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        protected void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void tbmakhachhang_TextChanged_1(object sender, EventArgs e)
        {

        }

        protected void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        protected void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void dtgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void tiensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Tongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
