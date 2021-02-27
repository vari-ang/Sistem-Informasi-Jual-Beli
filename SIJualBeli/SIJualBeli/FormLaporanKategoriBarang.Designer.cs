namespace SIJualBeli
{
    partial class FormLaporanKategoriBarang
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
            this.labelTanggal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.dataGridViewKategori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(219, 104);
            this.labelTanggal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(99, 29);
            this.labelTanggal.TabIndex = 22;
            this.labelTanggal.Text = "tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Per Tanggal :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(1092, 666);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(161, 63);
            this.buttonKeluar.TabIndex = 20;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1296, 72);
            this.label1.TabIndex = 19;
            this.label1.Text = "LAPORAN KATEGORI BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Navy;
            this.buttonCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(41, 666);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(161, 63);
            this.buttonCetak.TabIndex = 18;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // dataGridViewKategori
            // 
            this.dataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategori.Location = new System.Drawing.Point(3, 158);
            this.dataGridViewKategori.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewKategori.Name = "dataGridViewKategori";
            this.dataGridViewKategori.Size = new System.Drawing.Size(1291, 484);
            this.dataGridViewKategori.TabIndex = 17;
            // 
            // FormLaporanKategoriBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 750);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.dataGridViewKategori);
            this.Name = "FormLaporanKategoriBarang";
            this.Text = "FormLaporanKategoriBarang";
            this.Load += new System.EventHandler(this.FormLaporanKategoriBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.DataGridView dataGridViewKategori;
    }
}