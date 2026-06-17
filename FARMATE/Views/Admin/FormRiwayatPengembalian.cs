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
using FARMATE.Controller;

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
            LoadStatistik();
            LoadRiwayat();
        }
        private void LoadRiwayat()
        {
            flowRiwayat.Controls.Clear();

            PengembalianController controller =
                new PengembalianController();

            DataTable dt =
                controller.GetRiwayat();

            foreach (DataRow row in dt.Rows)
            {
                DateOnly tglSewa =
                    (DateOnly)row["tgl_sewa"];

                DateOnly tglKembali =
                    (DateOnly)row["tgl_pengembalian"];

                int durasi =
                    tglKembali.DayNumber -
                    tglSewa.DayNumber;

                UCRiwayatPengembalian card =
                    new UCRiwayatPengembalian();

                card.SetData(
                    Convert.ToInt32(row["id_sewa"]),
                    row["nama_user"].ToString(),
                    row["merk_alat"].ToString(),
                    durasi + " Hari",
                    tglSewa.ToString("dd/MM/yyyy"),
                    tglKembali.ToString("dd/MM/yyyy"),
                    "-",
                    row["status_sewa"].ToString()
                );

                card.KonfirmasiClicked +=
                    Card_KonfirmasiClicked;

                flowRiwayat.Controls.Add(card);
            }
        }
        private void LoadStatistik()
        {
            PengembalianController controller =
                new PengembalianController();

            DataRow row =
                controller.GetStatistik();

            lblPenyewaan.Text =
                row["total"].ToString();

            lblSedangDisewa.Text =
                row["sedang"].ToString();

            lblSelesai.Text =
                row["selesai"].ToString();

            lblTerlambat.Text =
                controller.GetJumlahTerlambat()
                .ToString();
        }

        private void Card_KonfirmasiClicked(
    object sender,
    EventArgs e)
        {
            UCRiwayatPengembalian card =
                (UCRiwayatPengembalian)sender;

            PengembalianController controller =
                new PengembalianController();

            decimal denda =
                controller.KonfirmasiPengembalian(
                    card.IdSewa);

            if (denda > 0)
            {
                MessageBox.Show(
                    "Pengembalian berhasil dikonfirmasi\n\n" +
                    "Terdapat denda sebesar Rp " +
                    denda.ToString("N0"),
                    "Denda Keterlambatan");
            }
            else
            {
                MessageBox.Show(
                    "Pengembalian berhasil dikonfirmasi\n\n" +
                    "Tidak ada denda.",
                    "Informasi");
            }

            LoadRiwayat();
            LoadStatistik();
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
        private void btnKonfirmasi_Click(
    object sender,
    EventArgs e)
        {
            Button btn = (Button)sender;

            int idSewa =
                Convert.ToInt32(btn.Tag);

            PengembalianController controller =
                new PengembalianController();

            decimal denda =
                controller.KonfirmasiPengembalian(
                    idSewa);

            LoadRiwayat();
            LoadStatistik();
        }
        private void panelStatistik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowRiwayat_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblTerlambat_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
