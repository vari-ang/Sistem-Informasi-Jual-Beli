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
    public partial class FormLaporanSupplier : Form
    {
        List<Supplier> listHasilData = new List<Supplier>();

        public FormLaporanSupplier()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hasilCetak = Supplier.CetakNota("", "", "daftar_supplier.txt");

            if (hasilCetak == "1")
            {
                MessageBox.Show("Laporan Supplier telah tercetak");
            }
            else
            {
                MessageBox.Show("Laporan Supplier gagal dicetak. Pesan kesalahan: " + hasilCetak);
            }
        }

        private void FormLaporanSupplier_Load(object sender, EventArgs e)
        {
            // Tampilkan semua data Supplier
            string hasilBaca = Supplier.BacaData("", "", listHasilData);

            if (hasilBaca == "1")
            {
                // Tampilkan hasil data di dataGridView
                dataGridViewSupplier.DataSource = listHasilData;
            }
            else
            {
                // Kosongi dataGridView
                dataGridViewSupplier.DataSource = null;
            }
        }
    }
}
