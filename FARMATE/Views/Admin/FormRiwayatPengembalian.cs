using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace FARMATE.Views.Admin
{
    public partial class FormRiwayatPengembalian : Form
    {
        public FormRiwayatPengembalian()
        {
            InitializeComponent();
        }

        private void FormRiwayatPengembalian_Load(object sender, EventArgs e)
        {
            lblPenyewaan.Text = "15";
            lblSedangDisewa.Text = "3";
            lblSelesai.Text = "10";
            lblTerlambat.Text = "2";

            BuatCardRiwayat(
           "Andi",
           "DJI Agras T50",
           "3 Hari",
           "01/06/2026",
           "04/06/2026",
           "0",
           "Selesai");


        }

        private void panelStatistik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowRiwayat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuatCardRiwayat(
        string nama,
        string alat,
        string durasi,
        string tglPinjam,
        string tglKembali,
        string denda,
        string status)
        {
            Panel card = new Panel();

            card.Width = 1150;
            card.Height = 60;
            card.BorderStyle = BorderStyle.FixedSingle;

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.Location = new Point(20, 20);
            lblNama.AutoSize = true;

            Label lblAlat = new Label();
            lblAlat.Text = alat;
            lblAlat.Location = new Point(220, 20);
            lblAlat.AutoSize = true;

            Label lblDurasi = new Label();
            lblDurasi.Text = durasi;
            lblDurasi.Location = new Point(420, 20);
            lblDurasi.AutoSize = true;

            Label lblPinjam = new Label();
            lblPinjam.Text = tglPinjam;
            lblPinjam.Location = new Point(560, 20);
            lblPinjam.AutoSize = true;

            Label lblKembali = new Label();
            lblKembali.Text = tglKembali;
            lblKembali.Location = new Point(720, 20);
            lblKembali.AutoSize = true;

            Label lblDenda = new Label();
            lblDenda.Text = denda;
            lblDenda.Location = new Point(900, 20);
            lblDenda.AutoSize = true;

            Label lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.Location = new Point(1050, 20);
            lblStatus.AutoSize = true;

            card.Controls.Add(lblNama);
            card.Controls.Add(lblAlat);
            card.Controls.Add(lblDurasi);
            card.Controls.Add(lblPinjam);
            card.Controls.Add(lblKembali);
            card.Controls.Add(lblDenda);
            card.Controls.Add(lblStatus);

            flowRiwayat.Controls.Add(card);
        }

        private void lblTerlambat_Click(object sender, EventArgs e)
        {

        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            FormKelolaAlat form = new FormKelolaAlat();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPengembalian form = new FormRiwayatPengembalian();
            form.Show();
            this.Hide();
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            FormDataUser form = new FormDataUser();
            form.Show();
            this.Hide();
        }
    }
}
