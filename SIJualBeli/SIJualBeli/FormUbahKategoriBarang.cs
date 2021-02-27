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
    public partial class FormUbahKategoriBarang : Form
    {
        FormDaftarKategoriBarang frmDaftar;
        List<Kategori> listHasilData = new List<Kategori>();

        public FormUbahKategoriBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);

            // Panggil static method UbahData di class kategori
            string hasilUbah = Kategori.UbahData(k);

            if (hasilUbah == "1")
            {
                MessageBox.Show("Data kategori telah diubah.", "Informasi");

                buttonKosongi_Click(sender, e);
                frmDaftar.FormDaftarKategoriBarang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal mengubah kategori. Pesan kesalahan: " + hasilUbah);
            }
        }

        private void FormUbahKategoriBarang_Load(object sender, EventArgs e)
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

                if(hasilBaca == "1")
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
