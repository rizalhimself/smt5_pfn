using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan2_19SA1116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Total()
        {
            int total, hrgMakanan, hrgMinuman = 0;
            hrgMakanan = Convert.ToInt32(etHargaMakanan.Text);
            hrgMinuman = Convert.ToInt32(etHargaMinuman.Text);
            total = hrgMakanan + hrgMinuman;
            etTotal.Text = Convert.ToString(total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] makanan = { "Paket Ayam Goreng", 
                "Paket Nasi Goreng", 
                "Paket Mie Goreng" };
            cbMakanan.Items.AddRange(makanan);
            string[] minuman = { "Es Teh",
                "Es Jeruk", "Es Kelapa"};
            cbMinuman.Items.AddRange(minuman);
        }

        private void cbMakananDipilih(object sender, EventArgs e)
        {
            int pilih;
            pilih = cbMakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    etHargaMakanan.Text = "14000";
                    Total();
                    break;
                case 1:
                    etHargaMakanan.Text = "12000";
                    Total();
                    break;
                case 2:
                    etHargaMakanan.Text = "11000";
                    Total();
                    break;
                default:
                    etHargaMakanan.Text = "0";
                    break;
            }
        }

        private void cbMinumanDipilih(object sender, EventArgs e)
        {
            int pilih;
            pilih = cbMinuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    etHargaMinuman.Text = "7000";
                    Total();
                    break;
                case 1:
                    etHargaMinuman.Text = "8000";
                    Total();
                    break;
                case 2:
                    etHargaMinuman.Text = "5000";
                    Total();
                    break;
                default:
                    etHargaMinuman.Text = "0";
                    break;
            }

        }

        private void etBayar_Dibayar(object sender, EventArgs e)
        {
            if (etBayar.Text == "" || etBayar.Text == " ")
            { 
                etBayar.Text = "0"; 
            }
            else
            {
                int bayar = Convert.ToInt32(etBayar.Text);
                int total = Convert.ToInt32(etTotal.Text);
                int kembali = 0;
                kembali = bayar - total;
                etKembali.Text = Convert.ToString(kembali);
            }
        }

        private void etBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void btProses_diklik(object sender, EventArgs e)
        {
            MessageBox.Show("============================" +
                "\n\tWarung Berkah" +
                "\n\tKasir: " +etNamaKasir.Text+
                "\n============================"+
                "\nPesan: "+
                "\n"+cbMakanan.Text+"\tRp. "+etHargaMakanan.Text+
                "\n"+cbMinuman.Text+"\tRp. "+etHargaMinuman.Text+
                "\n============================"+
                "\nTotal\t\t: Rp. "+etTotal.Text+
                "\nBayar\t\t: Rp. "+etBayar.Text+
                "\nKembali\t\t: Rp. " + etKembali.Text);
        }

        private void btClear_diklik(object sender, EventArgs e)
        {
            cbMakanan.Text = "";
            cbMinuman.Text = "";
            etHargaMakanan.Text = "0";
            etHargaMinuman.Text = "0";
            etTotal.Text = "0";
            etBayar.Text = "0";
            etKembali.Text = "0";
            etNamaKasir.Clear();
        }

    }

}
