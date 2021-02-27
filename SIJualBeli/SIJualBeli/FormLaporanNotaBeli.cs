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
    public partial class FormLaporanNotaBeli : Form
    {
        List<NotaBeli> listHasilData = new List<NotaBeli>();

        public FormLaporanNotaBeli()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            dataGridViewBarang.Columns.Add("NoNota", "No Nota");
            dataGridViewBarang.Columns.Add("Tanggal", "Tanggal");
            dataGridViewBarang.Columns.Add("KodeSupplier", "Kode Supplier");
            dataGridViewBarang.Columns.Add("NamaSupplier", "Nama Supplier");
            dataGridViewBarang.Columns.Add("AlamatSupplier", "Alamat Supplier");
            dataGridViewBarang.Columns.Add("KodePegawai", "Kode Pegawai");
            dataGridViewBarang.Columns.Add("NamaPegawai", "Nama Pegawai");

            dataGridViewBarang.Columns["NoNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["KodeSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["AlamatSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["KodePegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaPegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["KodeSupplier"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["KodePegawai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FormLaporanNotaBeli_Load(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString();

            FormatDataGrid();
            listHasilData.Clear();

            string hasilBaca = NotaBeli.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewBarang.Rows.Clear();

                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewBarang.Rows.Add(listHasilData[i].NoNota, listHasilData[i].Tanggal,
                        listHasilData[i].Supplier.KodeSupplier, listHasilData[i].Supplier.Nama, listHasilData[i].Supplier.Alamat,
                        listHasilData[i].Pegawai.KodePegawai, listHasilData[i].Pegawai.Nama);
                }
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            // cetak nota beli yang memenuhi kriteria pencarian user
            // simpan di file dengan nama daftar nota_beli.txt
            string hasilCetak = NotaBeli.CetakNota("", "", "daftar_nota_beli.txt");

            MessageBox.Show("Data nota beli telah tercetak");
        }
    }
}
