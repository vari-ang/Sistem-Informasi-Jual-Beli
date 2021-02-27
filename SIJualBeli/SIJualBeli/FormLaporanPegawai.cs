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
    public partial class FormLaporanPegawai : Form
    {
        List<Pegawai> listHasilData = new List<Pegawai>();

        public FormLaporanPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormatDataGrid()
        {
            dataGridViewPegawai.Columns.Clear();

            dataGridViewPegawai.Columns.Add("KodePegawai", "Kode Pegawai");
            dataGridViewPegawai.Columns.Add("Nama", "Nama");
            dataGridViewPegawai.Columns.Add("TglLahir", "Tanggal Lahir");
            dataGridViewPegawai.Columns.Add("Alamat", "Alamat");
            dataGridViewPegawai.Columns.Add("Gaji", "Gaji");
            dataGridViewPegawai.Columns.Add("Username", "Username");
            dataGridViewPegawai.Columns.Add("IdJabatan", "Id Jabatan");
            dataGridViewPegawai.Columns.Add("NamaJabatan", "Nama Jabatan");

            dataGridViewPegawai.Columns["KodePegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["TglLahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["Gaji"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["IdJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPegawai.Columns["NamaJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewPegawai.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewPegawai.Columns["Gaji"].DefaultCellStyle.Format = "0,###";
        }

        private void FormLaporanPegawai_Load(object sender, EventArgs e)
        {
            labelTanggal.Text = DateTime.Now.ToShortDateString();

            FormatDataGrid();

            string hasilBaca = Pegawai.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewPegawai.Rows.Clear();

                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewPegawai.Rows.Add(listHasilData[i].KodePegawai, listHasilData[i].Nama, listHasilData[i].TglLahir.ToShortDateString(),
                        listHasilData[i].Alamat, listHasilData[i].Gaji, listHasilData[i].Username, listHasilData[i].Jabatan.IdJabatan,
                        listHasilData[i].Jabatan.NamaJabatan);
                }
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = Pegawai.CetakNota("", "", "daftar_pegawai.txt");

            if (hasilCetak == "1")
            {
                MessageBox.Show("Laporan Pegawai telah tercetak");
            }
            else
            {
                MessageBox.Show("Laporan Pegawai gagal dicetak. Pesan kesalahan: " + hasilCetak);
            }
        }
    }
}
