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
    public partial class FormUbahJabatan : Form
    {
        FormDaftarJabatan frmDaftar;
        private List<Jabatan> listHasilData = new List<Jabatan>();

        public FormUbahJabatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUbahJabatan_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarJabatan)this.Owner;

            textBoxIdJabatan.MaxLength = 2;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Jabatan j = new Jabatan(textBoxIdJabatan.Text, textBoxNamaJabatan.Text);

            // Panggil static method UbahData di class kategori
            string hasilUbah = Jabatan.UbahData(j);

            if (hasilUbah == "1")
            {
                MessageBox.Show("Data jabatan telah diubah.", "Informasi");

                buttonKosongi_Click(sender, e);
                frmDaftar.FormDaftarJabatan_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal mengubah jabatan. Pesan kesalahan: " + hasilUbah);
            }
        }

        private void textBoxIdJabatan_TextChanged(object sender, EventArgs e)
        {
            // Jika user telah mengetik sesuai panjang karakter KodeKategori
            if (textBoxIdJabatan.Text.Length == textBoxIdJabatan.MaxLength)
            {
                listHasilData.Clear();

                // Cari nama kategori sesuai kode kategori yang diinputkan user
                string hasilBaca = Jabatan.BacaData("IdJabatan", textBoxIdJabatan.Text, listHasilData);

                if (hasilBaca == "1")
                {
                    // Jika kode kategori di database (jumlah data list hasil pembacaan lebih dari nol)
                    if (listHasilData.Count > 0)
                    {
                        textBoxNamaJabatan.Text = listHasilData[0].NamaJabatan;
                        textBoxNamaJabatan.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Id Jabatan tidak ditemukan. Proses Ubah Data tidak bisa dilakukan.");
                        textBoxNamaJabatan.Text = "";
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
            textBoxIdJabatan.Text = "";
            textBoxNamaJabatan.Text = "";
        }
    }
}
