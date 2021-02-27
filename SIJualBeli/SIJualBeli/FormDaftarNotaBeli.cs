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
    public partial class FormDaftarNotaBeli : Form
    {
        FormUtama frmUtama;
        List<NotaBeli> listHasilData = new List<NotaBeli>();

        string kriteria = "";

        public FormDaftarNotaBeli()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaBeli frm = new FormTambahNotaBeli();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            // cetak nota beli yang memenuhi kriteria pencarian user
            // simpan di file dengan nama daftar nota_beli.txt
            string hasilCetak = NotaBeli.CetakNota(kriteria, textBoxCari.Text, "daftar_nota_beli.txt");

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
            else if (comboBoxCari.Text == "Kode Supplier")
            {
                kriteria = "N.KodeSupplier";
            }
            else if (comboBoxCari.Text == "Nama Supplier")
            {
                kriteria = "Sup.Nama";
            }
            else if (comboBoxCari.Text == "Alamat Supplier")
            {
                kriteria = "Sup.Alamat";
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
            string hasilBaca = NotaBeli.BacaData(kriteria, textBoxCari.Text, listHasilData);

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

        public void FormDaftarNotaBeli_Load(object sender, EventArgs e)
        {
            comboBoxCari.DropDownStyle = ComboBoxStyle.DropDownList;

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

            frmUtama = (FormUtama)this.MdiParent;

            if(frmUtama.selectedIndexStokSedikit != -1)
            {
                // Buka form tambah nota beli
                buttonTambah_Click(sender, e);
            }
        }
    }
}
