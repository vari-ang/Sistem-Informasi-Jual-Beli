using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PenjualanPembelian;

namespace SIJualBeli
{
    public partial class FormLaporanKategoriBarang : Form
    {
        List<Kategori> listHasilData = new List<Kategori>();

        public FormLaporanKategoriBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporanKategoriBarang_Load(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString();

            // Tampilkan semua data kategori
            string hasilBaca = Kategori.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                // Tampilkan hasil data di dataGridView
                dataGridViewKategori.DataSource = listHasilData;
            }
            else
            {
                // Kosongi dataGridView
                dataGridViewKategori.DataSource = null;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = Kategori.CetakNota("", "", "daftar_kategori_barang.txt");

            if (hasilCetak == "1")
            {
                MessageBox.Show("Laporan Kategori Barang telah tercetak");
            }
            else
            {
                MessageBox.Show("Laporan Kategori Barang gagal dicetak. Pesan kesalahan: " + hasilCetak);
            }
        }
    }
}
