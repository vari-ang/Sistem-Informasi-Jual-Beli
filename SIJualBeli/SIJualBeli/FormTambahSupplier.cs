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
    public partial class FormTambahSupplier : Form
    {
        FormDaftarSupplier frmDaftar;

        public FormTambahSupplier()
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
            Supplier pel = new Supplier(int.Parse(textBoxKodeSupplier.Text), textBoxNama.Text, textBoxAlamat.Text);

            // Panggil static method TambahData di class kategori
            string hasilTambah = Supplier.TambahData(pel);

            if (hasilTambah == "1")
            {
                MessageBox.Show("Supplier telah tersimpan.", "Informasi");

                frmDaftar.FormDaftarSupplier_Load(sender, e);
                FormTambahSupplier_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal menambah Supplier. Pesan kesalahan: " + hasilTambah);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            FormTambahSupplier_Load(sender, e);
        }

        private void FormTambahSupplier_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarSupplier)this.Owner;

            string kodeTerbaru;
            string hasilGenerate = Supplier.GenerateCode(out kodeTerbaru);

            if (hasilGenerate == "1")
            {
                textBoxKodeSupplier.Text = kodeTerbaru;

                // buat agar textBoxKodePegawai tidak bisa diakses
                textBoxKodeSupplier.Enabled = false;

                // arahkan cursor ke textBoxNamaPegawai
                textBoxNama.Focus();
            }
            else
            {
                MessageBox.Show("Gagal melakukan generate code. Pesan kesalahan: " + hasilGenerate);
            }

            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
        }
    }
}
