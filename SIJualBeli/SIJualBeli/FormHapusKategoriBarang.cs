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
    public partial class FormHapusKategoriBarang : Form
    {
        FormDaftarKategoriBarang frmDaftar;
        List<Kategori> listHasilData = new List<Kategori>();

        public FormHapusKategoriBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            // Pastikan dulu kepada user apakah akan menghapus data
            DialogResult konfirmasi = MessageBox.Show("Data kategori akan terhapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) // Jika user yakin menghapus data
            {
                // Ciptakan objek yg akan dihapus
                Kategori k = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);

                // Panggil static method HapusData di class kategori
                string hasilHapus = Kategori.HapusData(k);

                if (hasilHapus == "1")
                {
                    MessageBox.Show("Kategori telah dihapus.", "Informasi");

                    buttonKosongi_Click(sender, e);
                    frmDaftar.FormDaftarKategoriBarang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus kategori. Pesan kesalahan : " + hasilHapus);
                }
            }
        }

        private void FormHapusKategoriBarang_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarKategoriBarang)this.Owner;

            textBoxNamaKategori.Enabled = false;
            textBoxKodeKategori.MaxLength = 2;
        }

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            // Jika user telah mengetik sesuai panjang karakter KodeKategori
            if (textBoxKodeKategori.Text.Length == textBoxKodeKategori.MaxLength)
            {
                listHasilData.Clear();

                // Cari nama kategori sesuai kode kategori yang diinputkan user
                string hasilBaca = Kategori.BacaData("KodeKategori", textBoxKodeKategori.Text, listHasilData);

                if (hasilBaca == "1")
                {
                    // Jika kode kategori di database (jumlah data list hasil pembacaan lebih dari nol)
                    if (listHasilData.Count > 0)
                    {
                        textBoxNamaKategori.Text = listHasilData[0].Nama;
                        textBoxNamaKategori.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kode kategori tidak ditemukan. Proses Ubah Data tidak bisa dilakukan.");
                        textBoxNamaKategori.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Perintah SQL gagal dijalankan. Pesan kesalahan = " + hasilBaca);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
        }
    }
}
