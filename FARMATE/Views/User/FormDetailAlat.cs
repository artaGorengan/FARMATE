using FARMATE.Session;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT
            a.*,
            k.nama_kategori
        FROM Alat a
        JOIN KategoriAlat k
            ON a.id_kategori = k.id_kategori
        WHERE a.id_alat = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", idAlat);

                NpgsqlDataReader rd =
                    cmd.ExecuteReader();

                if (rd.Read())
                {
                    lblMerk.Text =
                        rd["merk_alat"].ToString();

                    lblHarga.Text =
                        "Rp " +
                        Convert.ToDecimal(
                            rd["harga_perhari"])
                        .ToString("N0")
                        + " /hari";

                    lblKategori.Text =
                        rd["nama_kategori"].ToString();

                    lblBBM.Text =
                        rd["bahan_bakar"].ToString();

                    rtbDeskripsi.Text =
                        rd["deskripsi"].ToString();

                    hargaPerHari =
                        Convert.ToDecimal(
                            rd["harga_perhari"]);
                    stokTersedia =
    Convert.ToInt32(
    rd["stok_tersedia"]);


                    string foto =
                        rd["foto_alat"].ToString();

                    if (File.Exists(foto))
                    {
                        pbFoto.Image =
                            Image.FromFile(foto);
                    }
                }
            }

            HitungTotal();
        }
        private void HitungTotal()
        {
            decimal total =
                hargaPerHari * jumlahHari;

            lblTotalHarga.Text =
                "Rp " +
                total.ToString("N0");
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            jumlahHari++;

            lblHari.Text =
                jumlahHari.ToString();

            HitungTotal();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (jumlahHari > 1)
            {
                jumlahHari--;

                lblHari.Text =
                    jumlahHari.ToString();

                HitungTotal();
            }
        }

        private void SimpanPenyewaan()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
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


                string sql = @"
        INSERT INTO Penyewaan
        (
            id_user,
            id_alat,
            jumlah_unit,
            tgl_sewa,
            tgl_pengembalian,
            total_harga,
            status_sewa
        )
        VALUES
        (
            @user,
            @alat,
            @jumlah,
            @tglsewa,
            @tglkembali,
            @total,
            @status
        )";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);


                DateTime tglSewa = dtpMulai.Value.Date;


                DateTime tglKembali = tglSewa.AddDays(jumlahHari);


                decimal total = hargaPerHari * jumlahHari;


                cmd.Parameters.AddWithValue("@user", UserSession.UserID);
                cmd.Parameters.AddWithValue("@alat", idAlat);
                cmd.Parameters.AddWithValue("@jumlah", 1);
                cmd.Parameters.AddWithValue("@tglsewa", tglSewa);
                cmd.Parameters.AddWithValue("@tglkembali", tglKembali);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@status", "Sedang Disewa");
                cmd.ExecuteNonQuery();

                string sqlUpdate = @"
UPDATE Alat
SET stok_tersedia =
    stok_tersedia - 1
WHERE id_alat = @id";

                NpgsqlCommand cmdUpdate =
                    new NpgsqlCommand(
                        sqlUpdate,
                        conn);

                cmdUpdate.Parameters.AddWithValue(
                    "@id",
                    idAlat);

                cmdUpdate.ExecuteNonQuery();
                stokTersedia--;
            }

            MessageBox.Show(
                "Penyewaan berhasil dibuat");

            this.Close();


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
    }
}
