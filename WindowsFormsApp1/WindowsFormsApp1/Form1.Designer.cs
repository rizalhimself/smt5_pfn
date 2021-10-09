
namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btTambah = new System.Windows.Forms.Button();
            this.et1 = new System.Windows.Forms.TextBox();
            this.et2 = new System.Windows.Forms.TextBox();
            this.btKurang = new System.Windows.Forms.Button();
            this.btKali = new System.Windows.Forms.Button();
            this.btBagi = new System.Windows.Forms.Button();
            this.btPersen = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dpResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai 2";
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(47, 176);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(75, 21);
            this.btTambah.TabIndex = 2;
            this.btTambah.Text = "+";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // et1
            // 
            this.et1.Location = new System.Drawing.Point(128, 48);
            this.et1.Name = "et1";
            this.et1.Size = new System.Drawing.Size(156, 20);
            this.et1.TabIndex = 3;
            // 
            // et2
            // 
            this.et2.Location = new System.Drawing.Point(128, 103);
            this.et2.Name = "et2";
            this.et2.Size = new System.Drawing.Size(156, 20);
            this.et2.TabIndex = 4;
            // 
            // btKurang
            // 
            this.btKurang.Location = new System.Drawing.Point(128, 176);
            this.btKurang.Name = "btKurang";
            this.btKurang.Size = new System.Drawing.Size(75, 21);
            this.btKurang.TabIndex = 5;
            this.btKurang.Text = "-";
            this.btKurang.UseVisualStyleBackColor = true;
            this.btKurang.Click += new System.EventHandler(this.btKurang_Click);
            // 
            // btKali
            // 
            this.btKali.Location = new System.Drawing.Point(209, 176);
            this.btKali.Name = "btKali";
            this.btKali.Size = new System.Drawing.Size(75, 21);
            this.btKali.TabIndex = 6;
            this.btKali.Text = "x";
            this.btKali.UseVisualStyleBackColor = true;
            this.btKali.Click += new System.EventHandler(this.btKali_Click);
            // 
            // btBagi
            // 
            this.btBagi.Location = new System.Drawing.Point(47, 205);
            this.btBagi.Name = "btBagi";
            this.btBagi.Size = new System.Drawing.Size(75, 21);
            this.btBagi.TabIndex = 7;
            this.btBagi.Text = "/";
            this.btBagi.UseVisualStyleBackColor = true;
            this.btBagi.Click += new System.EventHandler(this.btBagi_Click);
            // 
            // btPersen
            // 
            this.btPersen.Location = new System.Drawing.Point(128, 205);
            this.btPersen.Name = "btPersen";
            this.btPersen.Size = new System.Drawing.Size(75, 21);
            this.btPersen.TabIndex = 8;
            this.btPersen.Text = "%";
            this.btPersen.UseVisualStyleBackColor = true;
            this.btPersen.Click += new System.EventHandler(this.btPersen_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(209, 205);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 21);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dpResult
            // 
            this.dpResult.AutoSize = true;
            this.dpResult.Location = new System.Drawing.Point(324, 55);
            this.dpResult.Name = "dpResult";
            this.dpResult.Size = new System.Drawing.Size(37, 13);
            this.dpResult.TabIndex = 10;
            this.dpResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 247);
            this.Controls.Add(this.dpResult);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btPersen);
            this.Controls.Add(this.btBagi);
            this.Controls.Add(this.btKali);
            this.Controls.Add(this.btKurang);
            this.Controls.Add(this.et2);
            this.Controls.Add(this.et1);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Kalkulator Sederhana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.TextBox et1;
        private System.Windows.Forms.TextBox et2;
        private System.Windows.Forms.Button btKurang;
        private System.Windows.Forms.Button btKali;
        private System.Windows.Forms.Button btBagi;
        private System.Windows.Forms.Button btPersen;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label dpResult;
    }
}

