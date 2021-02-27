namespace SIJualBeli
{
    partial class FormTambahBarang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxKategoriBarang = new System.Windows.Forms.ComboBox();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.textBoxNamaBarang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxKategoriBarang);
            this.panel1.Controls.Add(this.textBoxKodeBarang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxStok);
            this.panel1.Controls.Add(this.textBoxHargaJual);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 506);
            this.panel1.TabIndex = 20;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(306, 199);
            this.textBoxNamaBarang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxNamaBarang.Multiline = true;
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(356, 124);
            this.textBoxNamaBarang.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nama Barang :";
            // 
            // comboBoxKategoriBarang
            // 
            this.comboBoxKategoriBarang.FormattingEnabled = true;
            this.comboBoxKategoriBarang.Location = new System.Drawing.Point(306, 26);
            this.comboBoxKategoriBarang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxKategoriBarang.Name = "comboBoxKategoriBarang";
            this.comboBoxKategoriBarang.Size = new System.Drawing.Size(356, 32);
            this.comboBoxKategoriBarang.TabIndex = 11;
            this.comboBoxKategoriBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategoriBarang_SelectedIndexChanged);
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Location = new System.Drawing.Point(306, 81);
            this.textBoxKodeBarang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(110, 29);
            this.textBoxKodeBarang.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kategori Barang :";
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(306, 412);
            this.textBoxStok.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(110, 29);
            this.textBoxStok.TabIndex = 8;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Location = new System.Drawing.Point(306, 354);
            this.textBoxHargaJual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(226, 29);
            this.textBoxHargaJual.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga Jual :";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(306, 138);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(226, 29);
            this.textBoxBarcode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barcode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode Barang :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 72);
            this.label1.TabIndex = 19;
            this.label1.Text = "TAMBAH BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(933, 650);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(161, 63);
            this.buttonKeluar.TabIndex = 23;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Navy;
            this.buttonKosongi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(369, 650);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(161, 63);
            this.buttonKosongi.TabIndex = 22;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(176, 650);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(161, 63);
            this.buttonSimpan.TabIndex = 21;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonSimpan);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormTambahBarang";
            this.Text = "FormTambahBarang";
            this.Load += new System.EventHandler(this.FormTambahBarang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxKategoriBarang;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
    }
}