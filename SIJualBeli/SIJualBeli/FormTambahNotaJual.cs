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
    public partial class FormTambahNotaJual : Form
    {
        FormDaftarNotaJual frmDaftar;
        List<Pelanggan> listDataPelanggan = new List<Pelanggan>();
        List<Barang> listDataBarang = new List<Barang>();

        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            // menambah kolom di datagridview
            dataGridViewBarang.Columns.Add("KodeBarang", "Kode Barang");       
            dataGridViewBarang.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewBarang.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewBarang.Columns.Add("Jumlah", "Jumlah");
            dataGridViewBarang.Columns.Add("SubTotal", "Sub Total");

            // agar lebar dapat menyesuaikan panjang/ isi data
            dataGridViewBarang.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // agar harga jual dan sub total rata kanan
            dataGridViewBarang.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // agar harga jual dan sub total ditampilkan dengan format pemisah ribuan (1000 delimiter)
            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Format = "0,###";
            dataGridViewBarang.Columns["SubTotal"].DefaultCellStyle.Format = "0,###";

            // agar user tidak bisa menambahkan data langsung di datagridview (harus melalui tombol Tambah)
            dataGridViewBarang.AllowUserToAddRows = false;
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarNotaJual)this.Owner;

            // 1. Generate nomor nota jual & tampilkan ke textBoxNoNota
            string hasilNoNota;
            string hasilGenerate = NotaJual.GenerateNoNota(out hasilNoNota);

            if (hasilGenerate == "1")
            {
                textBoxNoNota.Text = hasilNoNota;
                textBoxNoNota.Enabled = false;
            }
            else
            {
                MessageBox.Show("Generate nomor nota gagal dilakukan. Pesan kesalahan = " + hasilGenerate);
            }

            // 2. Tanggal nota diisi default tanggal sistem
            dateTimePickerTanggal.Value = DateTime.Now;
            dateTimePickerTanggal.Enabled = false;

            // 3. ComboBoxPelanggan diisi dengan semua pelanggan yang ada di tabel Pelanggan (gunakan method BacaData di class Pelanggan)
            comboBoxPelanggan.DropDownStyle = ComboBoxStyle.DropDownList;

            string hasilBacaPelanggan = Pelanggan.BacaData("","", listDataPelanggan);

            if (hasilBacaPelanggan == "1")
            {
                // kosongi dulu comboBox
                comboBoxPelanggan.Items.Clear();

                // tambahkan data pelanggan ke comboBoxPelanggan dengan format 'Kode Pelanggan - Nama Pelanggan'
                for (int i = 0; i < listDataPelanggan.Count; i++)
                {
                    comboBoxPelanggan.Items.Add(listDataPelanggan[i].KodePelanggan + " - " + listDataPelanggan[i].Nama);
                }

                comboBoxPelanggan.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Data pelanggan gagal ditampilkan di comboBox. Pesan kesalahan = " + hasilBacaPelanggan);
            }

            // 4. Kode dan nama pegawai pembuat nota yang sedang login diambil dari label di FormUtama
            FormUtama frmUtama = (FormUtama)this.Owner.MdiParent;
            labelKodePegawai.Text = frmUtama.labelKodePegawai.Text;
            labelNamaPegawai.Text = frmUtama.labelNamaPegawai.Text;

            // 5. Tambahkan kolom di DataGridViewBarang
            FormatDataGrid();

            // 6. Agar barcode hanya bisa diisi max. 13 karakter
            textBoxBarcode.MaxLength = 13;
        }

        private void comboBoxPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hapus isi list data pelanggan sebelumnya
            listDataPelanggan.Clear();

            // cari nama barang sesuai kode pelanggan yang dipilih user
            string hasil = Pelanggan.BacaData("KodePelanggan", comboBoxPelanggan.Text.Substring(0, 1), listDataPelanggan);

            if(hasil == "1")
            {
                if(listDataPelanggan.Count > 0)
                {
                    labelAlamat.Text = listDataPelanggan[0].Alamat;
                }
                else
                {
                    MessageBox.Show("Kode pelanggan tidak ditemukan.");
                    labelAlamat.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Perintah SQL gagal dijalankan. Pesan kesalahan = " + hasil);
            }
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if(textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
            {
                listDataBarang.Clear();

                // car nama barang sesuai barcode yang diinputkan user
                string hasil = Barang.BacaData("Barcode", textBoxBarcode.Text, listDataBarang);

                if (hasil == "1")
                {
                    if(listDataBarang.Count > 0)
                    {
                        labelKodeBarang.Text = listDataBarang[0].KodeBarang;
                        labelNamaBarang.Text = listDataBarang[0].Nama;
                        labelHarga.Text = listDataBarang[0].HargaJual.ToString();
                        textBoxJumlah.Text = "1";
                        textBoxJumlah.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Barang tidak ditemukan.");
                        textBoxBarcode.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Perintah SQL gagal dijalankan. Pesan kesalahan = " + hasil);
                }
            }        
        }

        private int HitungGrandTotal()
        {
            int grandTotal = 0;
            for (int i = 0; i < dataGridViewBarang.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewBarang.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal = grandTotal + subTotal;
            }
            return grandTotal;
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // 1. Hitung Sub Total
                int subTotal = int.Parse(labelHarga.Text) * int.Parse(textBoxJumlah.Text);

                // 2. Tambahkan ke dataGridView
                dataGridViewBarang.Rows.Add(labelKodeBarang.Text, labelNamaBarang.Text, labelHarga.Text, textBoxJumlah.Text, subTotal);

                // 3. Hitung grandTotal nota dan tampilkan di labelGrandTotal
                // labelGrandTotal memiliki pemisah ribuan
                labelGrandTotal.Text = HitungGrandTotal().ToString("0,###");

                // 4. Kosongi barcode, nama barang, harga jual, dan jualan
                textBoxBarcode.Text = "";
                labelKodeBarang.Text = "";
                labelNamaBarang.Text = "";
                labelHarga.Text = "";
                textBoxJumlah.Text = "";
                textBoxBarcode.Focus();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan();

            // format comboBoxPelanggan: x - yyyyyy (kode pelanggan karakter 0 sebanyak 1, nama kategori mulai karakter ke-4 s/d akhir)
            pelanggan.KodePelanggan = int.Parse(comboBoxPelanggan.Text.Substring(0, 1));
            pelanggan.Nama = comboBoxPelanggan.Text.Substring(4, comboBoxPelanggan.Text.Length - 4);
            pelanggan.Alamat = labelAlamat.Text;

            Pegawai pegawai = new Pegawai();
            pegawai.KodePegawai = int.Parse(labelKodePegawai.Text);
            pegawai.Nama = labelNamaPegawai.Text;

            NotaJual nota = new NotaJual(textBoxNoNota.Text, dateTimePickerTanggal.Value, pelanggan, pegawai);

            // data barang diperoleh dari dataGridView
            for (int i = 0; i < dataGridViewBarang.Rows.Count; i++)
            {
                Barang brg = new Barang();
                brg.KodeBarang = dataGridViewBarang.Rows[i].Cells["KodeBarang"].Value.ToString();
                brg.Nama = dataGridViewBarang.Rows[i].Cells["NamaBarang"].Value.ToString();
                int harga = int.Parse(dataGridViewBarang.Rows[i].Cells["HargaJual"].Value.ToString());
                int jumlah = int.Parse(dataGridViewBarang.Rows[i].Cells["Jumlah"].Value.ToString());
                NotaJualDetil notaDetil = new NotaJualDetil(brg, jumlah, harga);

                // simpan detil barang ke nota
                nota.TambahDetilBarang(brg, jumlah, harga);
            }

            string hasilTambah = NotaJual.TambahData(nota);
            if(hasilTambah == "1")
            {
                MessageBox.Show("Data nota jual telah tersimpan", "Info");
                buttonCetak_Click(sender, e);

                frmDaftar.FormDaftarNotaJual_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Data nota jual gagal tersimpan. Pesan kesalahan: " + hasilTambah, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = NotaJual.CetakNota("NoNota", textBoxNoNota.Text, "nota_jual.txt");

            if(hasilCetak == "1")
            {
                MessageBox.Show("Nota jual telah tercetak");
            }
            else
            {
                MessageBox.Show("Nota jual gagal dicetak. Pesan kesalahan: " + hasilCetak);
            }
        }
    }
}
