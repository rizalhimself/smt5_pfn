using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UTS_KRS
{
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        linqdbDataContext db = new linqdbDataContext();
        XDocument xmldoc = XDocument.Load("Y:/Documents/Pemrograman/SMT5/Pemrograman Framework/UTS-KRS/UTS-KRS/xdbPembayaranKelas.xml");

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            var jm = (from j in xmldoc.Element("Pembayarans").Descendants("DetailKrs")
                      where j.Element("nim").Value == FormKrs.nilaiNIM
                      select j.Element("total_sks").Value).FirstOrDefault();
            etJmSks.Text = Convert.ToString(jm);
            bacaDataXmlKelas();
        }

        public void bacaDataXmlKelas()
        {
            var res = from c in xmldoc.Element("Pembayarans").Descendants("Pembayaran")
                      select c.Element("kelas_perkuliahan").Value;
            cbKelasPerkuliahan.DataSource = res.ToList();
        }

        private void cbKelasPerkuliahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string KelasPerkuliahan = cbKelasPerkuliahan.SelectedValue.ToString();
            var bg = (from kp in xmldoc.Element("Pembayarans").Descendants("Pembayaran")
                      where kp.Element("kelas_perkuliahan").Value == KelasPerkuliahan
                      select kp.Element("uang_gedung").Value).First();
            etByGd.Text = bg.ToString();
            var ba = (from kp in xmldoc.Element("Pembayarans").Descendants("Pembayaran")
                      where kp.Element("kelas_perkuliahan").Value == KelasPerkuliahan
                      select kp.Element("biaya_admin").Value).First();
            etAdm.Text = ba.ToString();
            HitungBayarKRS();
        }

        public void HitungBayarKRS()
        {
            int jmsks, bg, ba, sks, subtotal, total;
            string KelasPerkuliahan = cbKelasPerkuliahan.SelectedValue.ToString();
            var psks = (from kp in xmldoc.Element("Pembayarans").Descendants("Pembayaran")
                        where kp.Element("kelas_perkuliahan").Value == KelasPerkuliahan
                        select kp.Element("hargapersks").Value).First();
            sks = Convert.ToInt32(psks);
            jmsks = Convert.ToInt32(etJmSks.Text);
            bg = Convert.ToInt32(etByGd.Text);
            ba = Convert.ToInt32(etAdm.Text);
            subtotal = jmsks * sks;
            total = subtotal + (bg + ba);
            etSubTot.Text = subtotal.ToString();
            etTotPemb.Text = total.ToString();
            generateToken();
        }

        private void generateToken()
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());
            etKodePembayaran.Text = token;
        }

        private void btAktivasi_Click(object sender, EventArgs e)
        {
            if (etKdAktv.Text == etKodePembayaran.Text)
            {
                string aktif = "teraktivasi";
              
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
