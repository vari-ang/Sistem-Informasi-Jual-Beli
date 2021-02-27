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
    public partial class FormDaftarBarang : Form
    {
        private List<Barang> listHasilData = new List<Barang>();

        public FormDaftarBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang frm = new FormTambahBarang();
            frm.Owner = this;
            frm.Show();
        }
        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahBarang frm = new FormUbahBarang();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusBarang frm = new FormHapusBarang();
            frm.Owner = this;
            frm.Show();
        }

        public void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            dataGridViewBarang.Columns.Add("KodeBarang", "Kode Barang");
            dataGridViewBarang.Columns.Add("Barcode", "Barcode");
            dataGridViewBarang.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewBarang.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewBarang.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewBarang.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewBarang.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Barcode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridViewBarang.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridViewBarang.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Format = "0,###";
        }

        public void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            comboBoxCari.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();

            listHasilData.Clear();
            string hasilBaca = Barang.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewBarang.Rows.Clear();

                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewBarang.Rows.Add(listHasilData[i].KodeBarang, listHasilData[i].Barcode,
                        listHasilData[i].Nama, listHasilData[i].HargaJual,
                        listHasilData[i].KategoriBarang.KodeKategori, listHasilData[i].KategoriBarang.Nama);
                }
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxCari.Text == "Kode Barang")
            {
                kriteria = "B.KodeBarang";
            }
            else if (comboBoxCari.Text == "Barcode")
            {
                kriteria = "B.Barcode";
            }
            else if (comboBoxCari.Text == "Nama")
            {
                kriteria = "B.Nama";
            }
            else if (comboBoxCari.Text == "Harga Jual")
            {
                kriteria = "B.HargaJual";
            }
            else if (comboBoxCari.Text == "Stok")
            {
                kriteria = "B.Stok";
            }
            else if (comboBoxCari.Text == "Kode Kategori")
            {
                kriteria = "B.KodeKategori";
            }
                else if (comboBoxCari.Text == "Nama Kategori")
            {
                kriteria = "K.Nama";
            }

            string hasilBaca = Barang.BacaData(kriteria, textBoxCari.Text, listHasilData);

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
    }
}
