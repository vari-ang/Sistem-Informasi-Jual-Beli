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
    public partial class FormUbahPegawai : Form
    {
        FormDaftarPegawai frmDaftar;
        private List<Pegawai> listHasilData = new List<Pegawai>();

        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarPegawai)this.Owner;

            textBoxNamaPegawai.MaxLength = 45;
            textBoxAlamat.MaxLength = 150;
            textBoxUsername.MaxLength = 16;
            textBoxPassword.MaxLength = 16;

            textBoxKodePegawai.Text = "";
            textBoxNamaPegawai.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxAlamat.Text = "";
            textBoxGaji.Text = "0";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxJabatan.Text = "";
            textBoxJabatan.Enabled = false;

            textBoxUsername.Enabled = false;

            textBoxKodePegawai.Focus();

            textBoxGaji.TextAlign = HorizontalAlignment.Right;
        }

        private void textBoxKodePegawai_TextChanged(object sender, EventArgs e)
        {
            listHasilData.Clear();

            string hasilBaca = Pegawai.BacaData("KodePegawai", textBoxKodePegawai.Text, listHasilData);
            if (hasilBaca == "1")
            {
                if (listHasilData.Count > 0)
                {
                    textBoxNamaPegawai.Text = listHasilData[0].Nama;
                    dateTimePickerTanggalLahir.Value = listHasilData[0].TglLahir;
                    textBoxAlamat.Text = listHasilData[0].Alamat;
                    textBoxGaji.Text = listHasilData[0].Gaji.ToString();
                    textBoxUsername.Text = listHasilData[0].Username;
                    textBoxPassword.Text = listHasilData[0].Password;

                    textBoxJabatan.Text = listHasilData[0].Jabatan.IdJabatan + " - " + listHasilData[0].Jabatan.NamaJabatan;
                    textBoxNamaPegawai.Focus();
                }
            }
            else
            {
                textBoxNamaPegawai.Text = "";
                dateTimePickerTanggalLahir.Value = DateTime.Now;
                textBoxAlamat.Text = "";
                textBoxGaji.Text = "0";
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string idJabatan = textBoxJabatan.Text.Substring(0, 2);
            string namaJabatan = textBoxJabatan.Text.Substring(5, textBoxJabatan.Text.Length - 5);

            Jabatan jabatan = new Jabatan(idJabatan, namaJabatan);

            Pegawai p = new Pegawai(int.Parse(textBoxKodePegawai.Text), textBoxNamaPegawai.Text, textBoxUsername.Text, 
                textBoxPassword.Text, dateTimePickerTanggalLahir.Value, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), jabatan);

            string hasilUbah = Pegawai.UbahData(p);

            if (hasilUbah == "1")
            {
                MessageBox.Show("Data pegawai telah terubah", "Informasi");

                FormUbahPegawai_Load(sender, e);
                frmDaftar.FormDaftarPegawai_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal mengubah data pegawai. Pesan kesalahan: " + hasilUbah);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            FormUbahPegawai_Load(sender, e);
        }
    }
}
