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
    public partial class FormHapusPelanggan : Form
    {
        FormDaftarPelanggan frmDaftar;
        List<Pelanggan> listHasilData = new List<Pelanggan>();

        public FormHapusPelanggan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodePelanggan.Text = "";
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelepon.Text = "";
        }

        private void FormHapusPelanggan_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarPelanggan)this.Owner;

            textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxTelepon.Enabled = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            // Pastikan dulu kepada user apakah akan menghapus data
            DialogResult konfirmasi = MessageBox.Show("Data pelanggan akan terhapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) // Jika user yakin menghapus data
            {
                int kode = int.Parse(textBoxKodePelanggan.Text);
                string nama = textBoxNama.Text;
                string alamat = textBoxAlamat.Text;
                string telepon = textBoxTelepon.Text;

                Pelanggan pel = new Pelanggan(kode, nama, alamat, telepon);

                // Panggil static method HapusData di class kategori
                string hasilHapus = Pelanggan.HapusData(pel);

                if (hasilHapus == "1")
                {
                    MessageBox.Show("Pelanggan telah dihapus.", "Informasi");

                    buttonKosongi_Click(sender, e);
                    frmDaftar.FormDaftarPelanggan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus pelanggan. Pesan kesalahan : " + hasilHapus);
                }
            }
        }

        private void textBoxKodePelanggan_TextChanged(object sender, EventArgs e)
        {
            listHasilData.Clear();

            string hasilBaca = Pelanggan.BacaData("KodePelanggan", textBoxKodePelanggan.Text, listHasilData);
            if (hasilBaca == "1")
            {
                if (listHasilData.Count > 0)
                {
                    textBoxNama.Text = listHasilData[0].Nama;
                    textBoxAlamat.Text = listHasilData[0].Alamat;
                    textBoxTelepon.Text = listHasilData[0].Telepon;

                    textBoxNama.Focus();
                }
            }
            else
            {
                textBoxNama.Text = "";
                textBoxAlamat.Text = "";
                textBoxTelepon.Text = "";
            }
        }
    }
}
