using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PenjualanPembelian; // Import JualBeli_LIB

namespace SIJualBeli
{
    public partial class FormLogin : Form
    {
        public List<Pegawai> listHasilData = new List<Pegawai>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Height = 50 + panelLogin.Height;

            // Beri nilai awal server dan database
            textBoxServer.Text = "localhost";
            textBoxDatabase.Text = "si_jual_beli";

            textBoxPassword.PasswordChar = Convert.ToChar("*");
        }

        private void linkLabelPengaturan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = 50 + panelLogin.Height + panelPengaturan.Height;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxServer.Text != "" && textBoxDatabase.Text != "")
            {
                this.Height = 50 + panelLogin.Height;
            }
            else
            {
                MessageBox.Show("Nama server dan nama database tidak boleh dikosongi");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text != "")
            {
                // Create objek bertipe Koneksi dengan memanggil constructor berparameter milik class Koneksi
                Koneksi k = new Koneksi(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

                string hasilConnect = k.Connect(); // panggil method Conenct milik class Koneksi

                if(hasilConnect == "sukses")
                {
                    FormUtama frmUtama = (FormUtama)this.Owner;
                    frmUtama.Enabled = true; // Agar form utama bisa diakses
                    MessageBox.Show("Selamat datang di sistem penjualan pembelian", "Info"); // tampilkan ucapan selamat datang

                    listHasilData.Clear();
                    string hasilCariPegawai = Pegawai.BacaData("username", textBoxUsername.Text, listHasilData);
                    if (hasilCariPegawai == "1")
                    {
                        if (listHasilData.Count > 0)
                        {
                            frmUtama.Enabled = true;

                            frmUtama.labelKodePegawai.Text = listHasilData[0].KodePegawai.ToString();
                            frmUtama.labelNamaPegawai.Text = listHasilData[0].Nama;
                            frmUtama.labelJabatanPegawai.Text = listHasilData[0].Jabatan.NamaJabatan;

                            // panggil method pengaturan hak akses
                            frmUtama.PengaturanHakAksesMenu(listHasilData[0].Jabatan);

                            this.Close(); // Tutup form login
                        }
                        else
                        {
                            MessageBox.Show("Username tidak ditemukan.");
                        }
                    }

                    // Cari barang yang memiliki stok < 10 (mau habis)
                    frmUtama.listBarangStokSedikit = Barang.CariStokSedikit();

                    for (int i = 0; i <= frmUtama.listBarangStokSedikit.Count - 1; i++)
                    {
                        Barang brgSedikit = frmUtama.listBarangStokSedikit[i];
                        frmUtama.stokBarangSedikitToolStripMenuItem.DropDownItems.Add(brgSedikit.Nama + " (" + brgSedikit.Stok + ")");
                    }

                    frmUtama.stokBarangSedikitToolStripMenuItem.DropDownItemClicked += (s, ev) => {
                        // Dapatkan nama barang yang diklik
                        string namaBrgStokSedikit = ev.ClickedItem.Text.Substring(0, ev.ClickedItem.Text.Length - 4).ToString();

                        // Cari index barang stok sedikit yang diklik
                        for (int j = 0; j <= frmUtama.listBarangStokSedikit.Count - 1; j++)
                        {
                            if (frmUtama.listBarangStokSedikit[j].Nama == namaBrgStokSedikit)
                            {
                                frmUtama.selectedIndexStokSedikit = j;
                                break;
                            }
                        }

                        // Buka form nota beli
                        frmUtama.pembelianToolStripMenuItem_Click(s, ev);
                    };
                }
                else // Jika gagal
                {
                    MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + hasilConnect, "Kesalahan");
                }
            }
            else
            {
                MessageBox.Show("Username tidak boleh dikosongi", "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
