using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }


        private void btTambah_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(et1.Text);
            int nilai2 = Convert.ToInt32(et2.Text);
            int tambah;
            tambah = nilai1 + nilai2;
            dpResult.Text = tambah.ToString();
        }
        
        private void btKurang_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(et1.Text);
            int nilai2 = Convert.ToInt32(et2.Text);
            int kurang;
            kurang = nilai1 - nilai2;
            dpResult.Text = kurang.ToString();
        }

        private void btBagi_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(et1.Text);
            int nilai2 = Convert.ToInt32(et2.Text);
            int bagi;
            bagi = nilai1 / nilai2;
            dpResult.Text = bagi.ToString();
        }

        private void btKali_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(et1.Text);
            int nilai2 = Convert.ToInt32(et2.Text);
            int kali;
            kali = nilai1 * nilai2;
            dpResult.Text = kali.ToString();
        }

        private void btPersen_Click(object sender, EventArgs e)
        {
            int nilai1 = Convert.ToInt32(et1.Text);
            int nilai2 = Convert.ToInt32(et2.Text);
            int persen;
            persen = nilai1 / nilai2 * 100;
            dpResult.Text = persen.ToString();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            et1.Clear();
            et2.Clear();
            dpResult.Text = "";
        }
    }
}
