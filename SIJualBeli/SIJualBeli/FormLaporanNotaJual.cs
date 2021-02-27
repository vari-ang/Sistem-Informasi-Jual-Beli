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
    public partial class FormLaporanNotaJual : Form
    {
        List<NotaJual> listHasilData = new List<NotaJual>();

        public FormLaporanNotaJual()
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
            dataGridViewBarang.Columns.Add("KodePelanggan", "Kode Pelanggan");
            dataGridViewBarang.Columns.Add("NamaPelanggan", "Nama Pelanggan");
            dataGridViewBarang.Columns.Add("AlamatPelanggan", "Alamat Pelanggan");
            dataGridViewBarang.Columns.Add("KodePegawai", "Kode Pegawai");
            dataGridViewBarang.Columns.Add("NamaPegawai", "Nama Pegawai");

            dataGridViewBarang.Columns["NoNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["KodePelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["AlamatPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["KodePegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["NamaPegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["KodePelanggan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["KodePegawai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FormLaporanNotaJual_Load(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString();

            FormatDataGrid();
            listHasilData.Clear();

            string hasilBaca = NotaJual.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewBarang.Rows.Clear();

                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewBarang.Rows.Add(listHasilData[i].NoNota, listHasilData[i].Tanggal,
                        listHasilData[i].Pelanggan.KodePelanggan, listHasilData[i].Pelanggan.Nama, listHasilData[i].Pelanggan.Alamat,
                        listHasilData[i].Pegawai.KodePegawai, listHasilData[i].Pegawai.Nama);
                }
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = NotaJual.CetakNota("", "", "daftar_nota_jual.txt");

            MessageBox.Show("Data nota jual telah tercetak");
        }
    }
}
