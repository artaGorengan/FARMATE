using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.User
{
    public partial class UCRiwayat : UserControl
    {
        public UCRiwayat()
        {
            InitializeComponent();
        }
        private void UCRiwayat_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string alat, string kategori, string durasi, string pinjam, string kembali, string denda, string status)
        {
            lblAlat.Text = alat;
            lblKategori.Text = kategori;
            lblDurasi.Text = durasi;
            lblTanggalPinjam.Text = pinjam;
            lblTanggalKembali.Text = kembali;
            lblDenda.Text = denda;
            lblStatus.Text = status;

            if (status == "Selesai")
            {
                lblStatus.ForeColor = Color.Green;
            }
            else if (status == "Sedang Disewa")
            {
                lblStatus.ForeColor = Color.Orange;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void lblDenda_Click(object sender, EventArgs e)
        {

        }
    }
}
