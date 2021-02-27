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
    public partial class FormDaftarKategoriBarang : Form
    {
        public List<Kategori> listHasilData = new List<Kategori>(); 

        public FormDaftarKategoriBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategoriBarang frm = new FormTambahKategoriBarang();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategoriBarang frm = new FormUbahKategoriBarang();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategoriBarang frm = new FormHapusKategoriBarang();
            frm.Owner = this;
            frm.Show();
        }

        public void FormDaftarKategoriBarang_Load(object sender, EventArgs e)
        {
            // Tampilkan semua data kategori
            listHasilData.Clear();
            string hasilBaca = Kategori.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewKategori.DataSource = null;

                // Tampilkan hasil data di dataGridView
                dataGridViewKategori.DataSource = listHasilData;
            }
            else
            {
                // Kosongi dataGridView
                dataGridViewKategori.DataSource = null;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            if(comboBoxCari.Text == "Kode Kategori")
            {
                kriteria = "KodeKategori";
            }
            else if (comboBoxCari.Text == "Nama Kategori")
            {
                kriteria = "Nama";
            }

            // Kosongi isi list
            listHasilData.Clear();

            // Tampilkan data kategori sesuai kriteria
            string hasilBaca = Kategori.BacaData(kriteria, textBoxCari.Text, listHasilData);

            if(hasilBaca == "1")
            {
                dataGridViewKategori.DataSource = null;
                dataGridViewKategori.DataSource = listHasilData;
            }
        }
    }
}
