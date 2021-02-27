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
    public partial class FormHapusBarang : Form
    {
        FormDaftarBarang frmDaftarBarang;
        private List<Barang> listHasilData = new List<Barang>();

        public FormHapusBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHapusBarang_Load(object sender, EventArgs e)
        {
            frmDaftarBarang = (FormDaftarBarang)this.Owner;

            textBoxKodeBarang.MaxLength = 5;
            textBoxKategori.Enabled = false;
            textBoxBarcode.Enabled = false;
            textBoxNamaBarang.Enabled = false;
            textBoxHargaJual.Enabled = false;
            textBoxStok.Enabled = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            // Pastikan dulu kepada user apakah akan menghapus data
            DialogResult konfirmasi = MessageBox.Show("Data barang akan terhapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) // Jika user yakin menghapus data
            {
                string kodeKategori = textBoxKategori.Text.Substring(1, 2);
                string namaKategori = textBoxKategori.Text.Substring(6, textBoxKategori.Text.Length - 6);
                Kategori kategoriBrg = new Kategori(kodeKategori, namaKategori);

                // Ciptakan objek yg akan dihapus
                Barang b = new Barang(textBoxKodeBarang.Text, textBoxBarcode.Text, textBoxNamaBarang.Text, int.Parse(textBoxHargaJual.Text), int.Parse(textBoxStok.Text), kategoriBrg);

                // Panggil static method HapusData di class kategori
                string hasilHapus = Barang.HapusData(b);

                if (hasilHapus == "1")
                {
                    MessageBox.Show("Barang telah dihapus.", "Informasi");

                    frmDaftarBarang.FormDaftarBarang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus barang. Pesan kesalahan : " + hasilHapus);
                }
            }
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

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeBarang.Text = "";
            textBoxKategori.Text = "";
            textBoxBarcode.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxHargaJual.Text = "0";
            textBoxStok.Text = "0";
        }
    }
}
