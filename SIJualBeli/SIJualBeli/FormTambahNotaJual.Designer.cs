namespace SIJualBeli
{
    partial class FormTambahNotaJual
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPelanggan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.textBoxNoNota = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.labelKodePegawai = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(186, 434);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(88, 34);
            this.buttonSimpan.TabIndex = 26;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alamat :";
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.FormattingEnabled = true;
            this.comboBoxPelanggan.Location = new System.Drawing.Point(389, 15);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.Size = new System.Drawing.Size(175, 21);
            this.comboBoxPelanggan.TabIndex = 11;
            this.comboBoxPelanggan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPelanggan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. Nota :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "TAMBAH NOTA JUAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(482, 434);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(88, 34);
            this.buttonKeluar.TabIndex = 28;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pegawai :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelanggan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal :";
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Navy;
            this.buttonCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(286, 434);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(88, 34);
            this.buttonCetak.TabIndex = 27;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // textBoxNoNota
            // 
            this.textBoxNoNota.Location = new System.Drawing.Point(111, 15);
            this.textBoxNoNota.Name = "textBoxNoNota";
            this.textBoxNoNota.Size = new System.Drawing.Size(147, 20);
            this.textBoxNoNota.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelHarga);
            this.panel1.Controls.Add(this.textBoxJumlah);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Controls.Add(this.dataGridViewBarang);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labelNamaBarang);
            this.panel1.Controls.Add(this.labelKodeBarang);
            this.panel1.Controls.Add(this.labelNamaPegawai);
            this.panel1.Controls.Add(this.labelKodePegawai);
            this.panel1.Controls.Add(this.labelGrandTotal);
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.dateTimePickerTanggal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxPelanggan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxNoNota);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 367);
            this.panel1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Harga";
            // 
            // labelHarga
            // 
            this.labelHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHarga.Location = new System.Drawing.Point(400, 164);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(90, 17);
            this.labelHarga.TabIndex = 34;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumlah.Location = new System.Drawing.Point(488, 164);
            this.textBoxJumlah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(63, 20);
            this.textBoxJumlah.TabIndex = 33;
            this.textBoxJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumlah_KeyDown);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBarcode.Location = new System.Drawing.Point(28, 164);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(120, 20);
            this.textBoxBarcode.TabIndex = 32;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(28, 189);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.Size = new System.Drawing.Size(522, 163);
            this.dataGridViewBarang.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(58, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Barcode";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNamaBarang.Location = new System.Drawing.Point(204, 164);
            this.labelNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(199, 17);
            this.labelNamaBarang.TabIndex = 21;
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKodeBarang.Location = new System.Drawing.Point(147, 164);
            this.labelKodeBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(59, 17);
            this.labelKodeBarang.TabIndex = 20;
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Location = new System.Drawing.Point(164, 106);
            this.labelNamaPegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(35, 13);
            this.labelNamaPegawai.TabIndex = 18;
            this.labelNamaPegawai.Text = "Nama";
            // 
            // labelKodePegawai
            // 
            this.labelKodePegawai.AutoSize = true;
            this.labelKodePegawai.Location = new System.Drawing.Point(109, 106);
            this.labelKodePegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKodePegawai.Name = "labelKodePegawai";
            this.labelKodePegawai.Size = new System.Drawing.Size(32, 13);
            this.labelKodePegawai.TabIndex = 17;
            this.labelKodePegawai.Text = "Kode";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(327, 78);
            this.labelGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(235, 57);
            this.labelGrandTotal.TabIndex = 16;
            this.labelGrandTotal.Text = "0";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAlamat
            // 
            this.labelAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlamat.Location = new System.Drawing.Point(389, 44);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(174, 35);
            this.labelAlamat.TabIndex = 15;
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(111, 44);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerTanggal.TabIndex = 14;
            // 
            // FormTambahNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 478);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTambahNotaJual";
            this.Text = "FormTambahNotaJual";
            this.Load += new System.EventHandler(this.FormTambahNotaJual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.TextBox textBoxNoNota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.Label labelKodePegawai;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelHarga;
    }
}