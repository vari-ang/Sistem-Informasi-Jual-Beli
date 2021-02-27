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
    public partial class FormTambahBarang : Form
    {
        private List<Kategori> listDataKategori = new List<Kategori>();
        FormDaftarBarang frmDaftarBarang;

        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            frmDaftarBarang = (FormDaftarBarang)this.Owner;

            textBoxKodeBarang.MaxLength = 13;
            textBoxBarcode.MaxLength = 13;
            textBoxNamaBarang.MaxLength = 45;

            comboBoxKategoriBarang.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxKodeBarang.Text = "";
            textBoxKodeBarang.Enabled = false;
            textBoxBarcode.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxHargaJual.Text = "0";
            textBoxStok.Text = "0";

            textBoxHargaJual.TextAlign = HorizontalAlignment.Right;
            textBoxStok.TextAlign = HorizontalAlignment.Right;

            listDataKategori.Clear();
            string hasilBaca = Kategori.BacaData("", "", listDataKategori);

            if (hasilBaca == "1")
            {
                comboBoxKategoriBarang.Items.Clear();
                for (int i = 0; i < listDataKategori.Count; i++)
                {
                    // Tampilkan dengan format kode kategori - nama kategori
                    comboBoxKategoriBarang.Items.Add(listDataKategori[i].KodeKategori + " - " + listDataKategori[i].Nama);
                }
            }
            else
            {
                MessageBox.Show("Data Kategori barang gagal ditampilkan. Pesan kesalahan: " + hasilBaca);
            }
        }

        private void comboBoxKategoriBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kodeKategori = comboBoxKategoriBarang.Text.Substring(0, 2);
            string kodeTerbaru;

            string hasilGenerate = Barang.GenerateKode(kodeKategori, out kodeTerbaru);

            if (hasilGenerate == "1")
            {
                textBoxKodeBarang.Text = kodeTerbaru;
                textBoxBarcode.Focus();
            }
            else
            {
                MessageBox.Show("Gagal melakukan generate code. Pesan kesalahan: " + hasilGenerate);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            int indexDipilihUser = comboBoxKategoriBarang.SelectedIndex;
            Kategori kategoriBrg = listDataKategori[indexDipilihUser];
            Barang brg = new Barang(textBoxKodeBarang.Text, textBoxBarcode.Text, textBoxNamaBarang.Text, int.Parse(textBoxHargaJual.Text), int.Parse(textBoxStok.Text), kategoriBrg);

            string hasilTambah = Barang.TambahData(brg);

            if(hasilTambah == "1")
            {
                MessageBox.Show("Barang telah tersimpan.", "Informasi");
                FormTambahBarang_Load(sender, e);

                frmDaftarBarang.FormDaftarBarang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal menambah barang. Pesan kesalahan: " + hasilTambah);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            FormTambahBarang_Load(sender, e);
        }
    }
}
