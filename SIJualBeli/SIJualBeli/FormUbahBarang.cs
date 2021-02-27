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
    public partial class FormUbahBarang : Form
    {
        FormDaftarBarang frmDaftarBarang;
        private List<Barang> listHasilData = new List<Barang>();

        public FormUbahBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            frmDaftarBarang = (FormDaftarBarang)this.Owner;

            textBoxKodeBarang.MaxLength = 5;
            textBoxBarcode.MaxLength = 13;
            textBoxNamaBarang.MaxLength = 45;

            textBoxKodeBarang.Text = "";
            textBoxKategori.Text = "";
            textBoxKategori.Enabled = false;
            textBoxBarcode.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxHargaJual.Text = "";
            textBoxStok.Text = "0";
            textBoxKodeBarang.Focus();

            textBoxHargaJual.TextAlign = HorizontalAlignment.Right;
            textBoxStok.TextAlign = HorizontalAlignment.Right;
        }

        private void textBoxKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeBarang.Text.Length == textBoxKodeBarang.MaxLength)
            {
                listHasilData.Clear();

                string hasilBaca = Barang.BacaData("KodeBarang", textBoxKodeBarang.Text, listHasilData);
                if (hasilBaca == "1")
                {
                    if (listHasilData.Count > 0)
                    {
                        textBoxBarcode.Text = listHasilData[0].Barcode;
                        textBoxNamaBarang.Text = listHasilData[0].Nama;
                        textBoxHargaJual.Text = listHasilData[0].HargaJual.ToString();
                        textBoxStok.Text = listHasilData[0].Stok.ToString();

                        textBoxStok.Enabled = false;
                        textBoxKategori.Text = listHasilData[0].KategoriBarang.KodeKategori + " - " + listHasilData[0].KategoriBarang.Nama;
                        textBoxBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kode barang tidak ditemukan. Proses Ubah Data tidak bisa dilakukan");
                    }
                }
                else
                {
                    MessageBox.Show("Perintah SQL gagal dijalankan. Pesan kesalahan = " + hasilBaca);
                }
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string kodeKategori = textBoxKategori.Text.Substring(1, 2);
            string namaKategori = textBoxKategori.Text.Substring(6, textBoxKategori.Text.Length - 6);
            Kategori kategoriBrg = new Kategori(kodeKategori, namaKategori);

            Barang brg = new Barang(textBoxKodeBarang.Text, textBoxBarcode.Text, textBoxNamaBarang.Text, 
                int.Parse(textBoxHargaJual.Text), int.Parse(textBoxStok.Text), kategoriBrg);

            string hasilUbah = Barang.UbahData(brg);

            if (hasilUbah == "1")
            {
                MessageBox.Show("Data barang telah terubah", "Informasi");
                FormUbahBarang_Load(sender, e);

                frmDaftarBarang.FormDaftarBarang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal mengubah data barang. Pesan kesalahan: " + hasilUbah);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            FormUbahBarang_Load(sender, e);
        }
    }
}
