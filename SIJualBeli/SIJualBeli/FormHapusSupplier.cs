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
    public partial class FormHapusSupplier : Form
    {
        FormDaftarSupplier frmDaftar;
        List<Supplier> listHasilData = new List<Supplier>();

        public FormHapusSupplier()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeSupplier.Text = "";
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
        }

        private void FormHapusSupplier_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarSupplier)this.Owner;

            textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
        }

        private void textBoxKodeSupplier_TextChanged(object sender, EventArgs e)
        {
            listHasilData.Clear();

            string hasilBaca = Supplier.BacaData("KodeSupplier", textBoxKodeSupplier.Text, listHasilData);
            if (hasilBaca == "1")
            {
                if (listHasilData.Count > 0)
                {
                    textBoxNama.Text = listHasilData[0].Nama;
                    textBoxAlamat.Text = listHasilData[0].Alamat;

                    textBoxNama.Focus();
                }
            }
            else
            {
                textBoxNama.Text = "";
                textBoxAlamat.Text = "";
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            // Pastikan dulu kepada user apakah akan menghapus data
            DialogResult konfirmasi = MessageBox.Show("Data supplier akan terhapus. Apakah Anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == System.Windows.Forms.DialogResult.Yes) // Jika user yakin menghapus data
            {
                int kode = int.Parse(textBoxKodeSupplier.Text);
                string nama = textBoxNama.Text;
                string alamat = textBoxAlamat.Text;

                Supplier sup = new Supplier(kode, nama, alamat);

                // Panggil static method HapusData di class kategori
                string hasilHapus = Supplier.HapusData(sup);

                if (hasilHapus == "1")
                {
                    MessageBox.Show("Supplier telah dihapus.", "Informasi");

                    buttonKosongi_Click(sender, e);
                    frmDaftar.FormDaftarSupplier_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus supplier. Pesan kesalahan : " + hasilHapus);
                }
            }
        }
    }
}
