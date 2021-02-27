namespace SIJualBeli
{
    partial class FormTambahNotaBeli
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
            this.label10 = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNoNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(779, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "Harga";
            // 
            // labelHarga
            // 
            this.labelHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHarga.Location = new System.Drawing.Point(734, 303);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(164, 29);
            this.labelHarga.TabIndex = 34;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumlah.Location = new System.Drawing.Point(894, 303);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(114, 29);
            this.textBoxJumlah.TabIndex = 33;
            this.textBoxJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumlah_KeyDown);
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Navy;
            this.buttonCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(513, 803);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(161, 63);
            this.buttonCetak.TabIndex = 32;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
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
            this.panel1.Controls.Add(this.comboBoxSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxNoNota);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 678);
            this.panel1.TabIndex = 30;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBarcode.Location = new System.Drawing.Point(51, 303);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(219, 29);
            this.textBoxBarcode.TabIndex = 32;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged_1);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(51, 349);
            this.dataGridViewBarang.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.Size = new System.Drawing.Size(957, 301);
            this.dataGridViewBarang.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(904, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Barcode";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNamaBarang.Location = new System.Drawing.Point(374, 303);
            this.labelNamaBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(363, 29);
            this.labelNamaBarang.TabIndex = 21;
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKodeBarang.Location = new System.Drawing.Point(270, 303);
            this.labelKodeBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(107, 29);
            this.labelKodeBarang.TabIndex = 20;
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Location = new System.Drawing.Point(301, 196);
            this.labelNamaPegawai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(64, 25);
            this.labelNamaPegawai.TabIndex = 18;
            this.labelNamaPegawai.Text = "Nama";
            // 
            // labelKodePegawai
            // 
            this.labelKodePegawai.AutoSize = true;
            this.labelKodePegawai.Location = new System.Drawing.Point(200, 196);
            this.labelKodePegawai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodePegawai.Name = "labelKodePegawai";
            this.labelKodePegawai.Size = new System.Drawing.Size(59, 25);
            this.labelKodePegawai.TabIndex = 17;
            this.labelKodePegawai.Text = "Kode";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(600, 144);
            this.labelGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(431, 105);
            this.labelGrandTotal.TabIndex = 16;
            this.labelGrandTotal.Text = "0";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAlamat
            // 
            this.labelAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlamat.Location = new System.Drawing.Point(714, 81);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(317, 63);
            this.labelAlamat.TabIndex = 15;
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(204, 81);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(266, 29);
            this.dateTimePickerTanggal.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alamat :";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(713, 28);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(318, 32);
            this.comboBoxSupplier.TabIndex = 11;
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplier_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. Nota :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pegawai :";
            // 
            // textBoxNoNota
            // 
            this.textBoxNoNota.Location = new System.Drawing.Point(204, 28);
            this.textBoxNoNota.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNoNota.Name = "textBoxNoNota";
            this.textBoxNoNota.Size = new System.Drawing.Size(266, 29);
            this.textBoxNoNota.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal :";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(330, 803);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(161, 63);
            this.buttonSimpan.TabIndex = 31;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(873, 803);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(161, 63);
            this.buttonKeluar.TabIndex = 33;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 72);
            this.label1.TabIndex = 29;
            this.label1.Text = "TAMBAH NOTA BELI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 883);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahNotaBeli";
            this.Text = "FormTambahNotaBeli";
            this.Load += new System.EventHandler(this.FormTambahNotaBeli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNoNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
    }
}