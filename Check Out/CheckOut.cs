using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Check_OUt
{
    public partial class CheckOut : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-S43LD1IU;Initial Catalog=QLKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
           
        }
        public CheckOut()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            
                connection = new SqlConnection(str);

                SqlDataAdapter adapter = new
                SqlDataAdapter("LAY_HOADON", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = txtKhachHang.Text;

                DataTable table = new DataTable();
                adapter.Fill(table);
                HOADON.DataSource = table;
                //=====================
                SqlDataAdapter adapter1 = new
                SqlDataAdapter("DICHVU_GIA", connection);
                adapter1.SelectCommand.CommandType = CommandType.StoredProcedure;

                adapter1.SelectCommand.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = txtKhachHang.Text;

                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                DICHVU.DataSource = table1;
                connection.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);

            SqlDataAdapter adapter = new
            SqlDataAdapter("TONG_GIA", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.SelectCommand.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = txtKhachHang.Text;

            DataTable table = new DataTable();
            adapter.Fill(table);
            Tong.DataSource = table;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}