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
    public partial class FormDaftarNotaJual : Form
    {
        List<NotaJual> listHasilData = new List<NotaJual>();

        string kriteria = "";

        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual frm = new FormTambahNotaJual();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            // cetak nota jual yang memenuhi kriteria pencarian user
            // simpan di file dengan nama daftar nota_jual.txt
            string hasilCetak = NotaJual.CetakNota(kriteria, textBoxCari.Text, "daftar_nota_jual.txt");

            MessageBox.Show("Data telah tercetak");
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxCari.Text == "No Nota")
            {
                kriteria = "N.NoNota";
            }
            else if (comboBoxCari.Text == "Tanggal")
            {
                kriteria = "N.Tanggal";
            }
            else if (comboBoxCari.Text == "Kode Pelanggan")
            {
                kriteria = "N.KodePelanggan";
            }
            else if (comboBoxCari.Text == "Nama Pelanggan")
            {
                kriteria = "Plg.Nama";
            }
            else if (comboBoxCari.Text == "Alamat Pelanggan")
            {
                kriteria = "Plg.Alamat";
            }
            else if (comboBoxCari.Text == "Kode Pegawai")
            {
                kriteria = "N.KodePegawai";
            }
            else if (comboBoxCari.Text == "Nama Pegawai")
            {
                kriteria = "Peg.Nama";
            }

            listHasilData.Clear();
            string hasilBaca = NotaJual.BacaData(kriteria, textBoxCari.Text, listHasilData);

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

        public void FormDaftarNotaJual_Load(object sender, EventArgs e)
        {
            comboBoxCari.DropDownStyle = ComboBoxStyle.DropDownList;

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

        private void buttonHapus_Click(object sender, EventArgs e)
        {

        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {

        }
    }
}
