using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PFN_Praktikum3_19SA1116
{
    public partial class frmBarang : Form
    {
        public frmBarang()
        {
            InitializeComponent();
            tampilDataBarang();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            etKodeBrg.Clear();
            etNamaBrg.Clear();
            etHrgJual.Clear();
            etDiscount.Clear();
            etStockGdg.Clear();
            etStockRak.Clear();
            etStockRusak.Clear();
            cbStockSatuan.SelectedIndex = -1;
        }

        //membuat method tampil data barang
        private void tampilDataBarang()
        {
            //string conS = "Data Source=192.168.0.100; Initial Catalog=dbAppTokoDataSet; Integrated Security=False";
            string conS = "Server=192.168.0.100;Database=dbAppToko;User Id=sa;Password=07032015rIsA";
            SqlConnection connection = new SqlConnection(conS);
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = connection;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
