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
    public partial class FormTambahKategoriBarang : Form
    {
        FormDaftarKategoriBarang frmDaftar;

        public FormTambahKategoriBarang()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            // Ciptakan objek yg akan ditambahkan
            Kategori k = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);
 
            // Panggil static method TambahData di class kategori
            string hasilTambah = Kategori.TambahData(k);

            if (hasilTambah == "1")
            {
                MessageBox.Show("Kategori telah tersimpan.", "Informasi");

                buttonKosongi_Click(sender, e);
                frmDaftar.FormDaftarKategoriBarang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal menambah kategori. Pesan kesalahan: " + hasilTambah);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahKategoriBarang_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarKategoriBarang)this.Owner;

            string kodeTerbaru;
            string hasilGenerate = Kategori.GenerateCode(out kodeTerbaru);

            if(hasilGenerate == "1")
            {
                textBoxKodeKategori.Text = kodeTerbaru;

                // buat agar textBoxKodeKategori tidak bisa diakses
                textBoxKodeKategori.Enabled = false;

                // arahkan cursor ke textBoxNamaKategori
                textBoxNamaKategori.Focus();
            }
            else
            {
                MessageBox.Show("Gagal melakukan generate code. Pesan kesalahan: " + hasilGenerate);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
        }
    }
}
