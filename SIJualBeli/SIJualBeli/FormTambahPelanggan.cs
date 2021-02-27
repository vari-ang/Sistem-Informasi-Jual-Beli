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
    public partial class FormTambahPelanggan : Form
    {
        FormDaftarPelanggan frmDaftar;

        public FormTambahPelanggan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            // Ciptakan objek yg akan ditambahkan
            Pelanggan pel = new Pelanggan(int.Parse(textBoxKodePelanggan.Text), textBoxNama.Text, textBoxAlamat.Text, textBoxTelepon.Text);

            // Panggil static method TambahData di class kategori
            string hasilTambah = Pelanggan.TambahData(pel);

            if (hasilTambah == "1")
            {
                MessageBox.Show("Pelanggan telah tersimpan.", "Informasi");

                frmDaftar.FormDaftarPelanggan_Load(sender, e);
                FormTambahPelanggan_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal menambah pelanggan. Pesan kesalahan: " + hasilTambah);
            }
        }
        
        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan_Load(sender, e);
        }

        private void FormTambahPelanggan_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarPelanggan)this.Owner;

            string kodeTerbaru;
            string hasilGenerate = Pelanggan.GenerateCode(out kodeTerbaru);

            if (hasilGenerate == "1")
            {
                textBoxKodePelanggan.Text = kodeTerbaru;

                // buat agar textBoxKodePegawai tidak bisa diakses
                textBoxKodePelanggan.Enabled = false;

                // arahkan cursor ke textBoxNamaPegawai
                textBoxNama.Focus();
            }
            else
            {
                MessageBox.Show("Gagal melakukan generate code. Pesan kesalahan: " + hasilGenerate);
            }

            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelepon.Text = "";
        }
    }
}
