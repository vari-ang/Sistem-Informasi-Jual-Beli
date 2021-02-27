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
    public partial class FormUbahPelanggan : Form
    {
        FormDaftarPelanggan frmDaftar;
        List<Pelanggan> listHasilData = new List<Pelanggan>();

        public FormUbahPelanggan()
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            Pelanggan pel = new Pelanggan(int.Parse(textBoxKodePelanggan.Text), textBoxNama.Text, textBoxAlamat.Text, textBoxTelepon.Text);

            // Panggil static method UbahData di class kategori
            string hasilUbah = Pelanggan.UbahData(pel);

            if (hasilUbah == "1")
            {
                MessageBox.Show("Data Pelanggan telah diubah.", "Informasi");

                buttonKosongi_Click(sender, e);
                frmDaftar.FormDaftarPelanggan_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal mengubah Pelanggan. Pesan kesalahan: " + hasilUbah);
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

        private void FormUbahPelanggan_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarPelanggan)this.Owner;
        }
    }
}
