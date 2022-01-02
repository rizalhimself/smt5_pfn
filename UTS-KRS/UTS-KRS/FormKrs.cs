using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UTS_KRS
{
    public partial class FormKrs : Form
    {
        public FormKrs()
        {
            InitializeComponent();
        }

        public static string nilaiNIM;

        linqdbDataContext db = new linqdbDataContext();
        XDocument xmldoc = XDocument.Load("Y:/Documents/Pemrograman/SMT5/Pemrograman Framework/UTS-KRS/UTS-KRS/xdbPembayaranKelas.xml");

        private void tampilDataKrs()
        {
            var krsMahasiswa = from km in db.krs
                               join dm in db.makuls on km.kdmakul equals dm.kdmakul
                               select new
                               {
                                   km.kdmakul,
                                   dm.nmMakul,
                                   dm.bobotsks,
                                   dm.dosenpengampu,
                                   km.status
                               };
            dgv1.DataSource = krsMahasiswa;
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
                seleksi = "select krs.kdmakul, makul.nmMakul, makul.bobotsks, makul.dosenpengampu, krs.status " +
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
                cbSemester.Text = "";
                cbMakul.Text = "";
                etJmlKredit.Text = "";
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

        private void btTambah_Click(object sender, EventArgs e)
        {
            if ((from r in db.krs
                 where r.kdmakul ==
       (from q in db.makuls
        where q.nmMakul == Convert.ToString(cbMakul.SelectedValue)
        select q.kdmakul).First()
                 select r).Count() > 0)
            {
                MessageBox.Show("Data sudah ada!");

            }
            else if (etJmlKredit.Text == "")
            {
                MessageBox.Show("Silahkan Cari Data KRS Dulu");

            }
            else
            {
                var kmakul = (from p in db.makuls where p.nmMakul == Convert.ToString(cbMakul.SelectedValue) select p.kdmakul).First();
                int kdmakul = kmakul, nim = Convert.ToInt32(etNIM.Text);
                string status = "Belum Diaktivasi";

                var krs = new kr
                {
                    kdmakul = kdmakul,
                    nim = nim,
                    status = status
                };

                db.krs.InsertOnSubmit(krs);
                db.SubmitChanges();
                MessageBox.Show("Data Berhasil Ditambahkan!");
                tampilDataKrs();
            }

        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            bool makcheck = (from ck in db.krs where ck.kdmakul == (from cm in db.makuls where cm.nmMakul == cbMakul.SelectedValue.ToString() select cm.kdmakul).First() select ck).Any();
            if (cbMakul.SelectedItem == null || makcheck == false)
            {
                MessageBox.Show("Makul tidak ada atau belum ada!");
            }
            else
            {
                var krs = (from k in db.krs
                           where k.kdmakul == (from b in db.makuls where b.nmMakul == Convert.ToString(cbMakul.SelectedValue) select b.kdmakul).First() && k.nim == Convert.ToInt32(etNIM.Text)
                           select k).First();
                db.krs.DeleteOnSubmit(krs);
                db.SubmitChanges();
                MessageBox.Show("Data berhasil dihapus!");
                tampilDataKrs();
            };

        }

        private void btTotPemb_Click(object sender, EventArgs e)
        {
            simpanDataXml();
            nilaiNIM = etNIM.Text;
            FormPembayaran pembayaran = new FormPembayaran();
            pembayaran.ShowDialog();

        }

        private void simpanDataXml()
        {
            string path = "Y:/Documents/Pemrograman/SMT5/Pemrograman Framework/UTS-KRS/UTS-KRS/xdbPembayaranKelas.xml";
            var jmk = (from j in db.krs join k in db.makuls on j.kdmakul equals k.kdmakul where j.nim == Convert.ToInt32(etNIM.Text) select k.bobotsks).Sum();
            bool nimcheck = (from c in xmldoc.Element("Pembayarans").Descendants("DetailKrs") where c.Element("nim").Value == etNIM.Text select c).Any();
            if (nimcheck == false)
            {
                XElement dbuff = new XElement("DetailKrs",
                new XElement("nim", etNIM.Text),
                new XElement("total_sks", jmk.ToString()),
                new XElement("tanggl_pemb", "null"),
                new XElement("kd_aktivasi", "null"),
                new XElement("status", "Belum Tervalidasi"));
                xmldoc.Root.Add(dbuff);
                xmldoc.Save(path);
            }

        }
    }
}
