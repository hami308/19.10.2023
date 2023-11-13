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
            loadkhachhangcu();
        }
        void loadkhachhangcu()
        {
            string query = $"SELECT *FROM[dbo].[Table_KHACHHANGCU]";
            DataProvider provider = new DataProvider();
            dtgvkhcu.DataSource = provider.ExecuteQuery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string query = $"SELECT * FROM [dbo].[Table_KHACHHANGCU] WHERE TENKHACHHANG='{textBox1.Text}'";
            DataProvider provider = new DataProvider();
            dtgvkhcu.DataSource = provider.ExecuteQuery(query);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                loadkhachhangcu();
            }
        }
    }
}
