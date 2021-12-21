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

namespace UTS_KRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        linqdbDataContext db = new linqdbDataContext();

        private void tampilDataKrs()
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = Koneksi.Conn.ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("select * from makul");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dtMakul = new DataTable();
            sda.Fill(dtMakul);
        }

        

        private void btCari_Click(object sender, EventArgs e)
        {
            String cari = "SELECT count (*) from mahasiswa where nim = @nim",
                seleksi = "select krs.kdmakul, makul.nmMakul, makul.bobotsks, makul.dosenpengampu " +
                "from krs right join makul on krs.kdmakul = makul.kdmakul where nim like '%" + etNIM.Text + "%'";
            String connString = Koneksi.Conn.ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand perintah = new SqlCommand(cari, conn);
            perintah.Parameters.AddWithValue("@nim", etNIM.Text);
            conn.Open();
            int records = (int)perintah.ExecuteScalar();
            if (records == 0)
            {
                perintah.Parameters.Clear();
                MessageBox.Show("NIM tidak ditemukan!");
            }
            else
            {
                perintah.Parameters.Clear();
                perintah = new SqlCommand(seleksi, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                perintah.Connection = conn;
                dataAdapter.SelectCommand = perintah;
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv1.DataSource = dataTable;
                MessageBox.Show("NIM ditemukan!");
                cbBinding();

            }
        }

        private void cbBinding()
        {
            var semester = (from s in db.makuls select s).ToList();
            cbSemester.ValueMember = "semester";
            cbSemester.DataSource = semester;
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            var makul = (from m in db.makuls where m.semester == Convert.ToInt32(cbSemester.SelectedValue) select m).ToList();
            cbMakul.ValueMember = "nmMakul";
            cbMakul.DataSource = makul;
        }

        private void cbMakul_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jmakul = cbMakul.SelectedValue.ToString();
            var jmlkrdt = (from j in db.makuls where j.nmMakul == jmakul select j).First();
            etJmlKredit.Text = jmlkrdt.bobotsks.ToString();
        }
    }
}
