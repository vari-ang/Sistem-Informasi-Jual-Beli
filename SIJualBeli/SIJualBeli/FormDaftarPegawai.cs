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
    public partial class FormDaftarPegawai : Form
    {
        private List<Pegawai> listHasilData = new List<Pegawai>();

        public FormDaftarPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai frm = new FormTambahPegawai();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPegawai frm = new FormUbahPegawai();
            frm.Owner = this;
            frm.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPegawai frm = new FormHapusPegawai();
            frm.Owner = this;
            frm.Show();
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

        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            comboBoxCari.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();

            listHasilData.Clear();
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

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxCari.Text == "Kode Pegawai")
            {
                kriteria = "P.KodePegawai";
            }
            else if (comboBoxCari.Text == "Nama")
            {
                kriteria = "P.Nama";
            }
            else if (comboBoxCari.Text == "Tanggal Lahir")
            {
                kriteria = "P.TglLahir";
            }
            else if (comboBoxCari.Text == "Alamat")
            {
                kriteria = "P.Alamat";
            }
            else if (comboBoxCari.Text == "Gaji")
            {
                kriteria = "P.Gaji";
            }
            else if (comboBoxCari.Text == "Username")
            {
                kriteria = "P.Username";
            }
            else if (comboBoxCari.Text == "Id Jabatan")
            {
                kriteria = "J.IdJabatan";
            }
            else if (comboBoxCari.Text == "Nama Jabatan")
            {
                kriteria = "J.Nama";
            }

            string hasilBaca = Pegawai.BacaData(kriteria, textBoxCari.Text, listHasilData);

            if (hasilBaca == "1")
            {
                dataGridViewPegawai.Rows.Clear();

                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewPegawai.Rows.Add(listHasilData[i].KodePegawai, listHasilData[i].Nama, listHasilData[i].TglLahir,
                        listHasilData[i].Alamat, listHasilData[i].Gaji, listHasilData[i].Username, listHasilData[i].Jabatan.IdJabatan,
                        listHasilData[i].Jabatan.NamaJabatan);
                }
            }
        }
    }
}
