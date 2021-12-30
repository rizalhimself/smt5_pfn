
namespace UTS_KRS
{
    partial class FormPembayaran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.etTotPemb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.etAdm = new System.Windows.Forms.TextBox();
            this.etByGd = new System.Windows.Forms.TextBox();
            this.etJmSks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.etSubTot = new System.Windows.Forms.TextBox();
            this.cbKelasPerkuliahan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBatal = new System.Windows.Forms.Button();
            this.btAktivasi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.etKodePembayaran = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.etKdAktv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.etTotPemb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.etAdm);
            this.groupBox1.Controls.Add(this.etByGd);
            this.groupBox1.Controls.Add(this.etJmSks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.etSubTot);
            this.groupBox1.Controls.Add(this.cbKelasPerkuliahan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 195);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Pembayaran";
            // 
            // etTotPemb
            // 
            this.etTotPemb.Location = new System.Drawing.Point(452, 158);
            this.etTotPemb.Name = "etTotPemb";
            this.etTotPemb.Size = new System.Drawing.Size(180, 20);
            this.etTotPemb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Biaya Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Biaya Gedung";
            // 
            // etAdm
            // 
            this.etAdm.Location = new System.Drawing.Point(452, 120);
            this.etAdm.Name = "etAdm";
            this.etAdm.Size = new System.Drawing.Size(180, 20);
            this.etAdm.TabIndex = 10;
            // 
            // etByGd
            // 
            this.etByGd.Location = new System.Drawing.Point(452, 82);
            this.etByGd.Name = "etByGd";
            this.etByGd.Size = new System.Drawing.Size(180, 20);
            this.etByGd.TabIndex = 9;
            // 
            // etJmSks
            // 
            this.etJmSks.Location = new System.Drawing.Point(19, 44);
            this.etJmSks.Name = "etJmSks";
            this.etJmSks.Size = new System.Drawing.Size(180, 20);
            this.etJmSks.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subtotal";
            // 
            // etSubTot
            // 
            this.etSubTot.Location = new System.Drawing.Point(452, 45);
            this.etSubTot.Name = "etSubTot";
            this.etSubTot.Size = new System.Drawing.Size(180, 20);
            this.etSubTot.TabIndex = 4;
            // 
            // cbKelasPerkuliahan
            // 
            this.cbKelasPerkuliahan.FormattingEnabled = true;
            this.cbKelasPerkuliahan.Location = new System.Drawing.Point(235, 44);
            this.cbKelasPerkuliahan.Name = "cbKelasPerkuliahan";
            this.cbKelasPerkuliahan.Size = new System.Drawing.Size(180, 21);
            this.cbKelasPerkuliahan.TabIndex = 6;
            this.cbKelasPerkuliahan.SelectedIndexChanged += new System.EventHandler(this.cbKelasPerkuliahan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah SKS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pilih Kelas Perkuliahan";
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(464, 315);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(99, 39);
            this.btBatal.TabIndex = 14;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btAktivasi
            // 
            this.btAktivasi.Location = new System.Drawing.Point(564, 315);
            this.btAktivasi.Name = "btAktivasi";
            this.btAktivasi.Size = new System.Drawing.Size(99, 39);
            this.btAktivasi.TabIndex = 15;
            this.btAktivasi.Text = "Aktivasi";
            this.btAktivasi.UseVisualStyleBackColor = true;
            this.btAktivasi.Click += new System.EventHandler(this.btAktivasi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.etKodePembayaran);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.etKdAktv);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(13, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 96);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktivasi KRS";
            // 
            // etKodePembayaran
            // 
            this.etKodePembayaran.Location = new System.Drawing.Point(19, 44);
            this.etKodePembayaran.Name = "etKodePembayaran";
            this.etKodePembayaran.Size = new System.Drawing.Size(179, 20);
            this.etKodePembayaran.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kode Aktivasi";
            // 
            // etKdAktv
            // 
            this.etKdAktv.Location = new System.Drawing.Point(233, 44);
            this.etKdAktv.Name = "etKdAktv";
            this.etKdAktv.Size = new System.Drawing.Size(398, 20);
            this.etKdAktv.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Kode Pembayaran";
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAktivasi);
            this.Controls.Add(this.btBatal);
            this.Name = "FormPembayaran";
            this.Text = "Aktivasi KRS";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox etJmSks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etSubTot;
        private System.Windows.Forms.ComboBox cbKelasPerkuliahan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox etAdm;
        private System.Windows.Forms.TextBox etByGd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox etTotPemb;
        private System.Windows.Forms.Button btAktivasi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox etKodePembayaran;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox etKdAktv;
        private System.Windows.Forms.Label label13;
    }
}