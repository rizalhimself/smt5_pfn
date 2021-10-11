using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFN_TP1_IF19F_19SA1116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] makanan = {"Paket Ayam Goreng", "Paket Nasi Goreng",
                "Paket Mie Goreng","Paket Bebek Goreng"};
            cbMakanan.Items.AddRange(makanan);
            string[] minuman = { "Teh Anget", "Jeruk Anget", "Es Teh", "Es Jeruk" };
            cbMinuman.Items.AddRange(minuman);

        }

        private void Total()
        {
            if (etTotMakanan.Text == "" || etTotMakanan.Text == " ")
            {
                etTotMakanan.Text = "0";
            }
            else if (etTotMinuman.Text == "" || etTotMinuman.Text == " ")
            {
                etTotMinuman.Text = "0";
            }
            int total, totMakan, totMinum;
            totMakan = Convert.ToInt32(etTotMakanan.Text);
            totMinum = Convert.ToInt32(etTotMinuman.Text);
            total = totMakan + totMinum;
            etTotal.Text = Convert.ToString(total);
        }

        private void cbMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cbMakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    etMakanan.Text = "14000";
                    break;
                case 1:
                    etMakanan.Text = "12000";
                    break;
                case 2:
                    etMakanan.Text = "11000";
                    break;
                case 3:
                    etMakanan.Text = "24000";
                    break;
                default:
                    etMakanan.Text = "0";
                    break;
            }
        }

        private void cbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cbMinuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    etMinuman.Text = "7000";
                    break;
                case 1:
                    etMinuman.Text = "8000";
                    break;
                case 2:
                    etMinuman.Text = "7500";
                    break;
                case 3:
                    etMinuman.Text = "8500";
                    break;
                default:
                    etMinuman.Text = "0";
                    break;
            }
        }

        private void nmMakanan_ValueChanged(object sender, EventArgs e)
        {
            int jumlah, makanan;
            if (etMakanan.Text == "" || etMakanan.Text == " ") 
            {
                etMakanan.Text = "0";
            }
            jumlah = ((int)nmMakanan.Value);
            makanan = Convert.ToInt32(etMakanan.Text);
            etTotMakanan.Text = Convert.ToString(makanan * jumlah);
            Total();

        }

        private void nmMinuman_ValueChanged(object sender, EventArgs e)
        {

            int jumlah, minuman;
            if(etMinuman.Text == "" || etMinuman.Text == " ")
            {
                etMinuman.Text = "0";
            }
            jumlah = ((int)nmMinuman.Value);
            minuman = Convert.ToInt32(etMinuman.Text);
            etTotMinuman.Text = Convert.ToString(minuman * jumlah);
            Total();
            
        }

        private void etBayar_TextChanged(object sender, EventArgs e)
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
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbMakanan.Text = "";
            nmMakanan.Value = 0;
            nmMinuman.Value = 0;
            cbMinuman.Text = "";
            etMakanan.Text = "0";
            etMinuman.Text = "0";
            etTotMakanan.Text = "0";
            etTotMinuman.Text = "0";
            etTotal.Text = "0";
            etBayar.Text = "0";
            etKembali.Text = "0";
            etKasir.Clear();
        }

        private void btProses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("============================" +
                "\n\tWarung Enak" +
                "\n\tKasir: " + etKasir.Text +
                "\n============================" +
                "\nPesan: " +
                "\n" + cbMakanan.Text + "\t"+nmMakanan.Value+" pcs"+ "\tRp. " + etTotMakanan.Text +
                "\n" + cbMinuman.Text + "\t"+nmMinuman.Value+" pcs"+"\tRp. " + etTotMinuman.Text +
                "\n============================" +
                "\nTotal\t\t\tRp. " + etTotal.Text +
                "\nBayar\t\t\tRp. " + etBayar.Text +
                "\nKembali\t\t\tRp. " + etKembali.Text);
        }
    }
}

