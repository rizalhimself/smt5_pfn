
namespace Latihan2_19SA1116
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMinuman = new System.Windows.Forms.ComboBox();
            this.cbMakanan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.etHargaMinuman = new System.Windows.Forms.TextBox();
            this.etHargaMakanan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.etNamaKasir = new System.Windows.Forms.TextBox();
            this.etTotal = new System.Windows.Forms.TextBox();
            this.etBayar = new System.Windows.Forms.TextBox();
            this.etKembali = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btProses = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warung Berkah";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMinuman);
            this.groupBox1.Controls.Add(this.cbMakanan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesan";
            // 
            // cbMinuman
            // 
            this.cbMinuman.FormattingEnabled = true;
            this.cbMinuman.Location = new System.Drawing.Point(64, 55);
            this.cbMinuman.Name = "cbMinuman";
            this.cbMinuman.Size = new System.Drawing.Size(121, 21);
            this.cbMinuman.TabIndex = 3;
            this.cbMinuman.SelectedIndexChanged += new System.EventHandler(this.cbMinumanDipilih);
            // 
            // cbMakanan
            // 
            this.cbMakanan.FormattingEnabled = true;
            this.cbMakanan.Location = new System.Drawing.Point(64, 26);
            this.cbMakanan.Name = "cbMakanan";
            this.cbMakanan.Size = new System.Drawing.Size(121, 21);
            this.cbMakanan.TabIndex = 2;
            this.cbMakanan.SelectedIndexChanged += new System.EventHandler(this.cbMakananDipilih);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Makanan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.etHargaMinuman);
            this.groupBox2.Controls.Add(this.etHargaMakanan);
            this.groupBox2.Location = new System.Drawing.Point(225, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harga";
            // 
            // etHargaMinuman
            // 
            this.etHargaMinuman.Location = new System.Drawing.Point(7, 55);
            this.etHargaMinuman.Name = "etHargaMinuman";
            this.etHargaMinuman.Size = new System.Drawing.Size(100, 20);
            this.etHargaMinuman.TabIndex = 1;
            this.etHargaMinuman.Text = "0";
            // 
            // etHargaMakanan
            // 
            this.etHargaMakanan.Location = new System.Drawing.Point(7, 26);
            this.etHargaMakanan.Name = "etHargaMakanan";
            this.etHargaMakanan.Size = new System.Drawing.Size(100, 20);
            this.etHargaMakanan.TabIndex = 0;
            this.etHargaMakanan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama Kasir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "BAYAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "KEMBALI";
            // 
            // etNamaKasir
            // 
            this.etNamaKasir.Location = new System.Drawing.Point(20, 180);
            this.etNamaKasir.Name = "etNamaKasir";
            this.etNamaKasir.Size = new System.Drawing.Size(100, 20);
            this.etNamaKasir.TabIndex = 2;
            // 
            // etTotal
            // 
            this.etTotal.Location = new System.Drawing.Point(232, 156);
            this.etTotal.Name = "etTotal";
            this.etTotal.Size = new System.Drawing.Size(100, 20);
            this.etTotal.TabIndex = 6;
            this.etTotal.Text = "0";
            // 
            // etBayar
            // 
            this.etBayar.Location = new System.Drawing.Point(232, 182);
            this.etBayar.Name = "etBayar";
            this.etBayar.Size = new System.Drawing.Size(100, 20);
            this.etBayar.TabIndex = 7;
            this.etBayar.Text = "0";
            this.etBayar.TextChanged += new System.EventHandler(this.etBayar_Dibayar);
            this.etBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etBayar_KeyPress);
            // 
            // etKembali
            // 
            this.etKembali.Location = new System.Drawing.Point(232, 208);
            this.etKembali.Name = "etKembali";
            this.etKembali.Size = new System.Drawing.Size(100, 20);
            this.etKembali.TabIndex = 8;
            this.etKembali.Text = "0";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(66, 244);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_diklik);
            // 
            // btProses
            // 
            this.btProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProses.Location = new System.Drawing.Point(172, 244);
            this.btProses.Name = "btProses";
            this.btProses.Size = new System.Drawing.Size(100, 50);
            this.btProses.TabIndex = 10;
            this.btProses.Text = "Proses";
            this.btProses.UseVisualStyleBackColor = true;
            this.btProses.Click += new System.EventHandler(this.btProses_diklik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(369, 306);
            this.Controls.Add(this.btProses);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.etKembali);
            this.Controls.Add(this.etBayar);
            this.Controls.Add(this.etTotal);
            this.Controls.Add(this.etNamaKasir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Kasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMinuman;
        private System.Windows.Forms.ComboBox cbMakanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etHargaMinuman;
        private System.Windows.Forms.TextBox etHargaMakanan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox etNamaKasir;
        private System.Windows.Forms.TextBox etTotal;
        private System.Windows.Forms.TextBox etBayar;
        private System.Windows.Forms.TextBox etKembali;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btProses;
    }
}

