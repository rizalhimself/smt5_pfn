
namespace PFN_TP1_IF19F_19SA1116
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
            this.etMinuman = new System.Windows.Forms.TextBox();
            this.etMakanan = new System.Windows.Forms.TextBox();
            this.cbMinuman = new System.Windows.Forms.ComboBox();
            this.cbMakanan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmMinuman = new System.Windows.Forms.NumericUpDown();
            this.nmMakanan = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.etTotMinuman = new System.Windows.Forms.TextBox();
            this.etTotMakanan = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.etKasir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.etTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.etBayar = new System.Windows.Forms.TextBox();
            this.etKembali = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btProses = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMakanan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warung \"Enak\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.etMinuman);
            this.groupBox1.Controls.Add(this.etMakanan);
            this.groupBox1.Controls.Add(this.cbMinuman);
            this.groupBox1.Controls.Add(this.cbMakanan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesan";
            // 
            // etMinuman
            // 
            this.etMinuman.Location = new System.Drawing.Point(188, 56);
            this.etMinuman.Name = "etMinuman";
            this.etMinuman.Size = new System.Drawing.Size(121, 20);
            this.etMinuman.TabIndex = 5;
            this.etMinuman.Text = "0";
            // 
            // etMakanan
            // 
            this.etMakanan.Location = new System.Drawing.Point(188, 29);
            this.etMakanan.Name = "etMakanan";
            this.etMakanan.Size = new System.Drawing.Size(121, 20);
            this.etMakanan.TabIndex = 4;
            this.etMakanan.Text = "0";
            // 
            // cbMinuman
            // 
            this.cbMinuman.FormattingEnabled = true;
            this.cbMinuman.Location = new System.Drawing.Point(61, 56);
            this.cbMinuman.Name = "cbMinuman";
            this.cbMinuman.Size = new System.Drawing.Size(121, 21);
            this.cbMinuman.TabIndex = 3;
            this.cbMinuman.SelectedIndexChanged += new System.EventHandler(this.cbMinuman_SelectedIndexChanged);
            // 
            // cbMakanan
            // 
            this.cbMakanan.FormattingEnabled = true;
            this.cbMakanan.Location = new System.Drawing.Point(61, 29);
            this.cbMakanan.Name = "cbMakanan";
            this.cbMakanan.Size = new System.Drawing.Size(121, 21);
            this.cbMakanan.TabIndex = 2;
            this.cbMakanan.SelectedIndexChanged += new System.EventHandler(this.cbMakanan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Makanan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmMinuman);
            this.groupBox2.Controls.Add(this.nmMakanan);
            this.groupBox2.Location = new System.Drawing.Point(345, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satuan";
            // 
            // nmMinuman
            // 
            this.nmMinuman.Location = new System.Drawing.Point(7, 55);
            this.nmMinuman.Name = "nmMinuman";
            this.nmMinuman.Size = new System.Drawing.Size(94, 20);
            this.nmMinuman.TabIndex = 1;
            this.nmMinuman.ValueChanged += new System.EventHandler(this.nmMinuman_ValueChanged);
            // 
            // nmMakanan
            // 
            this.nmMakanan.Location = new System.Drawing.Point(7, 29);
            this.nmMakanan.Name = "nmMakanan";
            this.nmMakanan.Size = new System.Drawing.Size(94, 20);
            this.nmMakanan.TabIndex = 0;
            this.nmMakanan.ValueChanged += new System.EventHandler(this.nmMakanan_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.etTotMinuman);
            this.groupBox3.Controls.Add(this.etTotMakanan);
            this.groupBox3.Location = new System.Drawing.Point(459, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subtotal";
            // 
            // etTotMinuman
            // 
            this.etTotMinuman.Location = new System.Drawing.Point(6, 54);
            this.etTotMinuman.Name = "etTotMinuman";
            this.etTotMinuman.Size = new System.Drawing.Size(121, 20);
            this.etTotMinuman.TabIndex = 7;
            this.etTotMinuman.Text = "0";
            // 
            // etTotMakanan
            // 
            this.etTotMakanan.Location = new System.Drawing.Point(6, 29);
            this.etTotMakanan.Name = "etTotMakanan";
            this.etTotMakanan.Size = new System.Drawing.Size(121, 20);
            this.etTotMakanan.TabIndex = 6;
            this.etTotMakanan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Kasir";
            // 
            // etKasir
            // 
            this.etKasir.Location = new System.Drawing.Point(20, 237);
            this.etKasir.Name = "etKasir";
            this.etKasir.Size = new System.Drawing.Size(100, 20);
            this.etKasir.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL";
            // 
            // etTotal
            // 
            this.etTotal.Location = new System.Drawing.Point(465, 237);
            this.etTotal.Name = "etTotal";
            this.etTotal.Size = new System.Drawing.Size(118, 20);
            this.etTotal.TabIndex = 8;
            this.etTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "BAYAR";
            // 
            // etBayar
            // 
            this.etBayar.Location = new System.Drawing.Point(465, 263);
            this.etBayar.Name = "etBayar";
            this.etBayar.Size = new System.Drawing.Size(118, 20);
            this.etBayar.TabIndex = 10;
            this.etBayar.Text = "0";
            this.etBayar.TextChanged += new System.EventHandler(this.etBayar_TextChanged);
            this.etBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etBayar_KeyPress);
            // 
            // etKembali
            // 
            this.etKembali.Location = new System.Drawing.Point(465, 289);
            this.etKembali.Name = "etKembali";
            this.etKembali.Size = new System.Drawing.Size(118, 20);
            this.etKembali.TabIndex = 12;
            this.etKembali.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "KEMBALI";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(196, 341);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btProses
            // 
            this.btProses.Location = new System.Drawing.Point(302, 341);
            this.btProses.Name = "btProses";
            this.btProses.Size = new System.Drawing.Size(100, 50);
            this.btProses.TabIndex = 14;
            this.btProses.Text = "PROSES";
            this.btProses.UseVisualStyleBackColor = true;
            this.btProses.Click += new System.EventHandler(this.btProses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 403);
            this.Controls.Add(this.btProses);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.etKembali);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.etBayar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.etTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.etKasir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Kasir Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmMinuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMakanan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox etMinuman;
        private System.Windows.Forms.TextBox etMakanan;
        private System.Windows.Forms.ComboBox cbMinuman;
        private System.Windows.Forms.ComboBox cbMakanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nmMinuman;
        private System.Windows.Forms.NumericUpDown nmMakanan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox etTotMinuman;
        private System.Windows.Forms.TextBox etTotMakanan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox etKasir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox etTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox etBayar;
        private System.Windows.Forms.TextBox etKembali;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btProses;
    }
}

