
namespace PFN_Praktikum3_19SA1116
{
    partial class frmBarang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.etKodeBrg = new System.Windows.Forms.TextBox();
            this.etNamaBrg = new System.Windows.Forms.TextBox();
            this.etDiscount = new System.Windows.Forms.TextBox();
            this.etHrgJual = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.etStockRusak = new System.Windows.Forms.TextBox();
            this.etStockRak = new System.Windows.Forms.TextBox();
            this.etStockGdg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbAppTokoDataSet = new PFN_Praktikum3_19SA1116.dbAppTokoDataSet();
            this.dbAppTokoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbStockSatuan = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppTokoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppTokoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.etHrgJual);
            this.groupBox1.Controls.Add(this.etDiscount);
            this.groupBox1.Controls.Add(this.etNamaBrg);
            this.groupBox1.Controls.Add(this.etKodeBrg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "==DATA BARANG==";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Harga Jual";
            // 
            // etKodeBrg
            // 
            this.etKodeBrg.Location = new System.Drawing.Point(89, 30);
            this.etKodeBrg.Name = "etKodeBrg";
            this.etKodeBrg.Size = new System.Drawing.Size(121, 20);
            this.etKodeBrg.TabIndex = 6;
            // 
            // etNamaBrg
            // 
            this.etNamaBrg.Location = new System.Drawing.Point(89, 59);
            this.etNamaBrg.Name = "etNamaBrg";
            this.etNamaBrg.Size = new System.Drawing.Size(121, 20);
            this.etNamaBrg.TabIndex = 7;
            // 
            // etDiscount
            // 
            this.etDiscount.Location = new System.Drawing.Point(89, 93);
            this.etDiscount.Name = "etDiscount";
            this.etDiscount.Size = new System.Drawing.Size(121, 20);
            this.etDiscount.TabIndex = 8;
            this.etDiscount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // etHrgJual
            // 
            this.etHrgJual.Location = new System.Drawing.Point(89, 124);
            this.etHrgJual.Name = "etHrgJual";
            this.etHrgJual.Size = new System.Drawing.Size(121, 20);
            this.etHrgJual.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStockSatuan);
            this.groupBox2.Controls.Add(this.etStockRusak);
            this.groupBox2.Controls.Add(this.etStockRak);
            this.groupBox2.Controls.Add(this.etStockGdg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(23, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 158);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Barang";
            // 
            // etStockRusak
            // 
            this.etStockRusak.Location = new System.Drawing.Point(89, 93);
            this.etStockRusak.Name = "etStockRusak";
            this.etStockRusak.Size = new System.Drawing.Size(121, 20);
            this.etStockRusak.TabIndex = 8;
            // 
            // etStockRak
            // 
            this.etStockRak.Location = new System.Drawing.Point(89, 59);
            this.etStockRak.Name = "etStockRak";
            this.etStockRak.Size = new System.Drawing.Size(121, 20);
            this.etStockRak.TabIndex = 7;
            // 
            // etStockGdg
            // 
            this.etStockGdg.Location = new System.Drawing.Point(89, 30);
            this.etStockGdg.Name = "etStockGdg";
            this.etStockGdg.Size = new System.Drawing.Size(121, 20);
            this.etStockGdg.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Satuan ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stok Rusak";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Stok Rak";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stok Gudang";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Batal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "% (Persen)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Keluar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dbAppTokoDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(378, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 438);
            this.dataGridView1.TabIndex = 16;
            // 
            // dbAppTokoDataSet
            // 
            this.dbAppTokoDataSet.DataSetName = "dbAppTokoDataSet";
            this.dbAppTokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbAppTokoDataSetBindingSource
            // 
            this.dbAppTokoDataSetBindingSource.DataSource = this.dbAppTokoDataSet;
            this.dbAppTokoDataSetBindingSource.Position = 0;
            // 
            // cbStockSatuan
            // 
            this.cbStockSatuan.FormattingEnabled = true;
            this.cbStockSatuan.Location = new System.Drawing.Point(89, 127);
            this.cbStockSatuan.Name = "cbStockSatuan";
            this.cbStockSatuan.Size = new System.Drawing.Size(121, 21);
            this.cbStockSatuan.TabIndex = 9;
            // 
            // frmBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBarang";
            this.Text = "Form Barang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppTokoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppTokoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox etDiscount;
        private System.Windows.Forms.TextBox etNamaBrg;
        private System.Windows.Forms.TextBox etKodeBrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox etHrgJual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox etStockRusak;
        private System.Windows.Forms.TextBox etStockRak;
        private System.Windows.Forms.TextBox etStockGdg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbAppTokoDataSetBindingSource;
        private dbAppTokoDataSet dbAppTokoDataSet;
        private System.Windows.Forms.ComboBox cbStockSatuan;
    }
}

