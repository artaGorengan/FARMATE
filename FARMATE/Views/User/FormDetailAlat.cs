using FARMATE.Controller;
using FARMATE.Session;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.User
{
    public partial class FormDetailAlat : Form
    {
        private int idAlat;
        private decimal hargaPerHari;
        private int jumlahHari = 1;
        private int stokTersedia;
        public FormDetailAlat(int id)
        {
            InitializeComponent();
            idAlat = id;
        }

        private void FormDetailAlat_Load(object sender, EventArgs e)
        {
            lblHari.Text = "1";
            LoadDetailAlat();
        }

        private void LoadDetailAlat()
        {
            AlatController controller =
                new AlatController();

            DataRow row =
                controller.GetDetailAlat(idAlat);

            if (row != null)
            {
                lblMerk.Text =
                    row["merk_alat"].ToString();

                lblHarga.Text =
                    "Rp " +
                    Convert.ToDecimal(
                        row["harga_perhari"])
                    .ToString("N0") +
                    " /hari";

                lblKategori.Text =
                    row["nama_kategori"].ToString();

                lblBBM.Text =
                    row["bahan_bakar"].ToString();

                rtbDeskripsi.Text =
                    row["deskripsi"].ToString();

                hargaPerHari =
                    Convert.ToDecimal(
                        row["harga_perhari"]);

                stokTersedia =
                    Convert.ToInt32(
                        row["stok_tersedia"]);

                string foto =
                    row["foto_alat"].ToString();

                if (File.Exists(foto))
                {
                    pbFoto.Image =
                        Image.FromFile(foto);
                }
            }

            HitungTotal();
        }

        private void SimpanPenyewaan()
        {
            if (dtpMulai.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Tanggal sewa tidak valid");
                return;
            }

            if (stokTersedia <= 0)
            {
                MessageBox.Show(
                    "Stok alat habis!");
                return;
            }

            AlatController controller =
                new AlatController();

            controller.SimpanPenyewaan(
                UserSession.UserID,
                idAlat,
                jumlahHari,
                hargaPerHari);

            MessageBox.Show(
                "Penyewaan berhasil dibuat");

            this.Close();
        }
        private void HitungTotal()
        {
            decimal total = hargaPerHari * jumlahHari;
            lblTotalHarga.Text = "Rp " + total.ToString("N0");
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            jumlahHari++;
            lblHari.Text = jumlahHari.ToString();
            HitungTotal();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (jumlahHari > 1)
            {
                jumlahHari--;
                lblHari.Text = jumlahHari.ToString();
                HitungTotal();
            }
        }
        private void btnSewa_Click(object sender, EventArgs e)
        {
            SimpanPenyewaan();
        }

        private void btnDaftarAlat_Click(object sender, EventArgs e)
        {
            FormDaftarAlat form = new FormDaftarAlat();
            form.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPenyewaan form = new FormRiwayatPenyewaan();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rtbDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDaftarAlat form = new FormDaftarAlat();
            form.Show();
            this.Hide();
        }
    }
}
