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
    public partial class FormUtama : Form
    {
        public List<Barang> listBarangStokSedikit = new List<Barang>();
        public int selectedIndexStokSedikit = -1;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            // Ubah form ini (FormUtama) menjadi fullscreen
            this.WindowState = FormWindowState.Maximized;

            // Ubah form utama menjadi MdiParen (MdiContainer)
            this.IsMdiContainer = true;

            // Agar FromUtama tidak bisa diakses sebelum proses login dilakukan
            this.Enabled = false;

            // tampilkan FormLogin terlebih dahulu sebelum bisa mengakses sistem
            FormLogin frmLogin = new FormLogin();
            frmLogin.Owner = this; // FormLogin bukan MdiChild dari FormUtama
            frmLogin.Show();
        }
    
        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form form = Application.OpenForms["FormDaftarBarang"];

             if (form == null)
             {
                 FormDaftarBarang frm = new FormDaftarBarang();
                 frm.MdiParent = this;
                 frm.Show(); 
             }
             else
             {
                 form.Show();
                 form.BringToFront();
             }
        }

        private void kategoriBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKategoriBarang"];

            if (form == null)
            {
                FormDaftarKategoriBarang frm = new FormDaftarKategoriBarang();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
            
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPelanggan"];

            if (form == null)
            {
                FormDaftarPelanggan frm = new FormDaftarPelanggan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }         
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarSupplier"];

            if (form == null)
            {
                FormDaftarSupplier frmSupplier = new FormDaftarSupplier();
                frmSupplier.MdiParent = this;
                frmSupplier.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarPegawai"];

            if (form == null)
            {
                FormDaftarPegawai frmPegawai = new FormDaftarPegawai();
                frmPegawai.MdiParent = this;
                frmPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void jabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarJabatan"];

            if (form == null)
            {
                FormDaftarJabatan frmJabatan = new FormDaftarJabatan();
                frmJabatan.MdiParent = this;
                frmJabatan.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        public void PengaturanHakAksesMenu(Jabatan pJabatan)
        {
            if (pJabatan.IdJabatan == "J1") // Jika jabatannya Pegawai Pembelian
            {
                masterToolStripMenuItem.Visible = false;
                penjualanToolStripMenuItem.Visible = false;
                pembelianToolStripMenuItem.Visible = true;
                stokBarangSedikitToolStripMenuItem.Visible = true;
                laporanToolStripMenuItem.Visible = false;
                penjualanToolStripMenuItem.Visible = false;
                pembelianToolStripMenuItem.Visible = true;
            }
            else if (pJabatan.IdJabatan == "J2") // jika jabatannya Kasir
            {
                masterToolStripMenuItem.Visible = false;
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = false;
                stokBarangSedikitToolStripMenuItem.Visible = false;
                laporanToolStripMenuItem.Visible = false;
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = false;
            }
            else if (pJabatan.IdJabatan == "J3") // jika jabatannya Manajer
            {
                masterToolStripMenuItem.Visible = true;
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = true;
                stokBarangSedikitToolStripMenuItem.Visible = true;
                laporanToolStripMenuItem.Visible = true;
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = true;
            }
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarNotaJual"];

            if (form == null)
            {
                FormDaftarNotaJual frmNotaJual = new FormDaftarNotaJual();
                frmNotaJual.MdiParent = this;
                frmNotaJual.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        public void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarNotaBeli"];

            if (form == null)
            {
                FormDaftarNotaBeli frmNotaBeli = new FormDaftarNotaBeli();
                frmNotaBeli.MdiParent = this;
                frmNotaBeli.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanBarang"];

            if (form == null)
            {
                FormLaporanBarang frm = new FormLaporanBarang();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanKategoriBarang"];

            if (form == null)
            {
                FormLaporanKategoriBarang frm = new FormLaporanKategoriBarang();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pelangganToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanPelanggan"];

            if (form == null)
            {
                FormLaporanPelanggan frm = new FormLaporanPelanggan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanSupplier"];

            if (form == null)
            {
                FormLaporanSupplier frm = new FormLaporanSupplier();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanPegawai"];

            if (form == null)
            {
                FormLaporanPegawai frm = new FormLaporanPegawai();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pembelianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanNotaBeli"];

            if (form == null)
            {
                FormLaporanNotaBeli frm = new FormLaporanNotaBeli();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLaporanNotaJual"];

            if (form == null)
            {
                FormLaporanNotaJual frm = new FormLaporanNotaJual();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
