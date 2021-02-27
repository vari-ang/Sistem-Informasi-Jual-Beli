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
    public partial class FormTambahPegawai : Form
    {
        FormDaftarPegawai frmDaftar;
        private List<Jabatan> listDataJabatan = new List<Jabatan>();

        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarPegawai)this.Owner;

            textBoxKodePegawai.Enabled = false; 
            textBoxNamaPegawai.MaxLength = 45;
            textBoxAlamat.MaxLength = 250;
            textBoxGaji.TextAlign = HorizontalAlignment.Right;

            textBoxNamaPegawai.Text = "";
            textBoxAlamat.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxGaji.Text = "0";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangPassword.Text = "";
            comboBoxJabatan.SelectedIndex = -1;

            string kodeTerbaru;
            string hasilGenerate = Pegawai.GenerateCode(out kodeTerbaru);

            if (hasilGenerate == "1")
            {
                textBoxKodePegawai.Text = kodeTerbaru;

                // buat agar textBoxKodePegawai tidak bisa diakses
                textBoxKodePegawai.Enabled = false;

                // arahkan cursor ke textBoxNamaPegawai
                textBoxNamaPegawai.Focus();
            }
            else
            {
                MessageBox.Show("Gagal melakukan generate code. Pesan kesalahan: " + hasilGenerate);
            }

            listDataJabatan.Clear();
            string hasilBaca = Jabatan.BacaData("", "", listDataJabatan);

            if (hasilBaca == "1")
            {
                comboBoxJabatan.Items.Clear();
                for (int i = 0; i < listDataJabatan.Count; i++)
                {
                    // Tampilkan dengan format kode kategori - nama kategori
                    comboBoxJabatan.Items.Add(listDataJabatan[i].IdJabatan + " . " + listDataJabatan[i].NamaJabatan);
                }
            }
            else
            {
                MessageBox.Show("Data Kategori barang gagal ditampilkan. Pesan kesalahan: " + hasilBaca);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            int indexDipilihUser = comboBoxJabatan.SelectedIndex;
            Jabatan j = listDataJabatan[indexDipilihUser];

            if(textBoxPassword.Text == textBoxUlangPassword.Text)
            {
                int kodePegawai = int.Parse(textBoxKodePegawai.Text);
                Pegawai p = new Pegawai(kodePegawai, textBoxNamaPegawai.Text, textBoxUsername.Text, textBoxPassword.Text, 
                    dateTimePickerTanggalLahir.Value.Date, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), j);

                string hasilTambah = Pegawai.TambahData(p);

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Pegawai telah tersimpan.", "Informasi");

                    FormTambahPegawai_Load(sender, e);                
                    frmDaftar.FormDaftarPegawai_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menambah pegawai. Pesan kesalahan: " + hasilTambah);
                }
            }
            else
            {
                MessageBox.Show("Nilai password dan ulang password tidak sama");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            FormTambahPegawai_Load(sender, e);
        }
    }
}
