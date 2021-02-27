﻿using System;
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
    public partial class FormUbahSupplier : Form
    {
        FormDaftarSupplier frmDaftar;
        List<Supplier> listHasilData = new List<Supplier>();

        public FormUbahSupplier()
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier(int.Parse(textBoxKodeSupplier.Text), textBoxNama.Text, textBoxAlamat.Text);

            // Panggil static method UbahData di class kategori
            string hasilUbah = Supplier.UbahData(sup);

            if (hasilUbah == "1")
            {
                MessageBox.Show("Data Supplier telah diubah.", "Informasi");

                frmDaftar.FormDaftarSupplier_Load(sender, e);
                buttonKosongi_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal mengubah Supplier. Pesan kesalahan: " + hasilUbah);
            }
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

        private void FormUbahSupplier_Load(object sender, EventArgs e)
        {
            frmDaftar = (FormDaftarSupplier)this.Owner;
        }
    }
}
