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
    public partial class FormLaporanPelanggan : Form
    {
        List<Pelanggan> listHasilData = new List<Pelanggan>();

        public FormLaporanPelanggan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = Pelanggan.CetakNota("", "", "daftar_pelanggan.txt");

            if (hasilCetak == "1")
            {
                MessageBox.Show("Laporan Pelanggan telah tercetak");
            }
            else
            {
                MessageBox.Show("Laporan Pelanggan gagal dicetak. Pesan kesalahan: " + hasilCetak);
            }
        }

        private void FormLaporanPelanggan_Load(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString();

            // Tampilkan semua data pelanggan
            string hasilBaca = Pelanggan.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                // Tampilkan hasil data di dataGridView
                dataGridViewPelanggan.DataSource = listHasilData;
            }
            else
            {
                // Kosongi dataGridView
                dataGridViewPelanggan.DataSource = null;
            }
        }
    }
}
