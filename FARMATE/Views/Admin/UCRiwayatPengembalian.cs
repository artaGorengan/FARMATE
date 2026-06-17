using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.Admin
{
    public partial class UCRiwayatPengembalian : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdSewa { get; set; }

        public event EventHandler KonfirmasiClicked;
        public UCRiwayatPengembalian()
        {
            InitializeComponent();
        }

        public void SetData(int idSewa, string nama, string alat, string durasi, string tglPinjam, string tglKembali, string denda, string status)
        {
            IdSewa = idSewa;

            lblNama.Text = nama;
            lblAlat.Text = alat;
            lblDurasi.Text = durasi;
            lblTanggalPinjam.Text = tglPinjam;
            lblTanggalKembali.Text = tglKembali;
            lblDenda.Text = denda;
            lblStatus.Text = status;

            btnKonfirmasi.Visible = status != "Selesai";
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            KonfirmasiClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UCRiwayatPengembalian_Load(object sender, EventArgs e)
        {

        }

        private void lblTanggalPinjam_Click(object sender, EventArgs e)
        {

        }
    }
}
