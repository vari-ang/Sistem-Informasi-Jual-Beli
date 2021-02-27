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
    public partial class FormLaporanBarang : Form
    {
        public List<Barang> listHasilData = new List<Barang>();

        public FormLaporanBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            dataGridViewBarang.Columns.Add("KodeBarang", "Kode Barang");
            dataGridViewBarang.Columns.Add("Barcode", "Barcode");
            dataGridViewBarang.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewBarang.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewBarang.Columns.Add("Stok", "Stok");
            dataGridViewBarang.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewBarang.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewBarang.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Barcode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Format = "0,###";
        }

        private void FormLaporanBarang_Load(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString();

            FormatDataGrid();

            listHasilData.Clear();
            string hasilBaca = Barang.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewBarang.Rows.Clear();

                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewBarang.Rows.Add(listHasilData[i].KodeBarang, listHasilData[i].Barcode,
                        listHasilData[i].Nama, listHasilData[i].HargaJual, listHasilData[i].Stok,
                        listHasilData[i].KategoriBarang.KodeKategori, listHasilData[i].KategoriBarang.Nama);
                }
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = Barang.CetakNota("", "", "daftar_barang.txt");

            if (hasilCetak == "1")
            {
                MessageBox.Show("Laporan Barang telah tercetak");
            }
            else
            {
                MessageBox.Show("Laporan Barang gagal dicetak. Pesan kesalahan: " + hasilCetak);
            }
        }
    }
}
