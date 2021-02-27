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
    public partial class FormHapusPegawai : Form
    {
        FormDaftarPegawai frmDaftar;
        private List<Pegawai> listHasilData = new List<Pegawai>();

        public FormHapusPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHapusPegawai_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarPegawai)this.Owner;

            textBoxKodePegawai.Enabled = true;
            textBoxNamaPegawai.Enabled = false;
            dateTimePickerTanggalLahir.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxGaji.Enabled = false;
            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxJabatan.Enabled = false;
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
            // Pastikan dulu kepada user apakah akan menghapus data
            DialogResult konfirmasi = MessageBox.Show("Data pegawai akan terhapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) // Jika user yakin menghapus data
            {
                string idJabatan = textBoxJabatan.Text.Substring(1, 2);
                string namaJabatan = textBoxJabatan.Text.Substring(6, textBoxJabatan.Text.Length - 6);

                Jabatan jabatan = new Jabatan(idJabatan, namaJabatan);

                Pegawai p = new Pegawai(int.Parse(textBoxKodePegawai.Text), textBoxNamaPegawai.Text, textBoxUsername.Text,
                    textBoxPassword.Text, dateTimePickerTanggalLahir.Value.Date, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), jabatan);

                // Panggil static method HapusData di class kategori
                //string hasilHapus = Pegawai.HapusData(p);

                string hasilHapus = Jabatan.HapusData(jabatan);

                if (hasilHapus == "1")
                {
                    MessageBox.Show("Pegawai telah dihapus.", "Informasi");

                    buttonKosongi_Click(sender, e);
                    frmDaftar.FormDaftarPegawai_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus pegawai. Pesan kesalahan : " + hasilHapus);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodePegawai.Text = "";
            textBoxNamaPegawai.Text = "";
            textBoxAlamat.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxGaji.Text = "0";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxJabatan.Text = "";
        }
    }
}
