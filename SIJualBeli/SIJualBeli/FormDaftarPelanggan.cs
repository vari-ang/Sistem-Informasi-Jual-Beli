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
    public partial class FormDaftarPelanggan : Form
    {
        List<Pelanggan> listHasilData = new List<Pelanggan>();

        public FormDaftarPelanggan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan frm = new FormTambahPelanggan();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPelanggan frm = new FormUbahPelanggan();
            frm.Owner = this;
            frm.Show();
        }

        public void FormDaftarPelanggan_Load(object sender, EventArgs e)
        {
            // Tampilkan semua data pelanggan
            listHasilData.Clear();
            string hasilBaca = Pelanggan.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewPelanggan.DataSource = null;

                // Tampilkan hasil data di dataGridView
                dataGridViewPelanggan.DataSource = listHasilData;
            }
            else
            {
                // Kosongi dataGridView
                dataGridViewPelanggan.DataSource = null;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if (comboBoxCari.Text == "Kode Pelanggan")
            {
                kriteria = "KodePelanggan";
            }
            else if (comboBoxCari.Text == "Nama")
            {
                kriteria = "Nama";
            }
            else if (comboBoxCari.Text == "Alamat")
            {
                kriteria = "Alamat";
            }
            else if (comboBoxCari.Text == "Telepon")
            {
                kriteria = "Telepon";
            }

            // Kosongi isi list
            listHasilData.Clear();

            // Tampilkan data kategori sesuai kriteria
            string hasilBaca = Pelanggan.BacaData(kriteria, textBoxCari.Text, listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewPelanggan.DataSource = null;
                dataGridViewPelanggan.DataSource = listHasilData;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPelanggan frm = new FormHapusPelanggan();
            frm.Owner = this;
            frm.Show();
        }
    }
}
