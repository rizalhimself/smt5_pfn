
namespace UTS_KRS
{
    partial class FormKrs
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
            this.etNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.etJmlKredit = new System.Windows.Forms.TextBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCari = new System.Windows.Forms.Button();
            this.cbMakul = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btHapus = new System.Windows.Forms.Button();
            this.btTambah = new System.Windows.Forms.Button();
            this.btTotPemb = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // etNIM
            // 
            this.etNIM.Location = new System.Drawing.Point(19, 43);
            this.etNIM.Name = "etNIM";
            this.etNIM.Size = new System.Drawing.Size(180, 20);
            this.etNIM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pilih Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jumlah Kredit";
            // 
            // etJmlKredit
            // 
            this.etJmlKredit.Location = new System.Drawing.Point(19, 219);
            this.etJmlKredit.Name = "etJmlKredit";
            this.etJmlKredit.Size = new System.Drawing.Size(180, 20);
            this.etJmlKredit.TabIndex = 4;
            // 
            // cbSemester
            // 
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(19, 120);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(180, 21);
            this.cbSemester.TabIndex = 6;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCari);
            this.groupBox1.Controls.Add(this.cbMakul);
            this.groupBox1.Controls.Add(this.etNIM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.etJmlKredit);
            this.groupBox1.Controls.Add(this.cbSemester);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 252);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit KRS";
            // 
            // btCari
            // 
            this.btCari.Location = new System.Drawing.Point(123, 70);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(75, 23);
            this.btCari.TabIndex = 9;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // cbMakul
            // 
            this.cbMakul.FormattingEnabled = true;
            this.cbMakul.Location = new System.Drawing.Point(19, 169);
            this.cbMakul.Name = "cbMakul";
            this.cbMakul.Size = new System.Drawing.Size(180, 21);
            this.cbMakul.TabIndex = 8;
            this.cbMakul.SelectedIndexChanged += new System.EventHandler(this.cbMakul_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pilih Makul";
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(12, 270);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(99, 39);
            this.btHapus.TabIndex = 8;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(130, 270);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(99, 39);
            this.btTambah.TabIndex = 10;
            this.btTambah.Text = "Tambah";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btTotPemb
            // 
            this.btTotPemb.Location = new System.Drawing.Point(12, 315);
            this.btTotPemb.Name = "btTotPemb";
            this.btTotPemb.Size = new System.Drawing.Size(217, 39);
            this.btTotPemb.TabIndex = 11;
            this.btTotPemb.Text = "Total Pembayaran";
            this.btTotPemb.UseVisualStyleBackColor = true;
            this.btTotPemb.Click += new System.EventHandler(this.btTotPemb_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(246, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(542, 342);
            this.dgv1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btTotPemb);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Edit Data KRS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox etNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etJmlKredit;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMakul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Button btTotPemb;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btCari;
    }
}

