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
            LoadStatistik();
            LoadRiwayat();
        }

        private void LoadStatistik()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                COUNT(*) AS total,
                COUNT(*) FILTER
                (WHERE status_sewa='Sedang Disewa')
                AS sedang,
                COUNT(*) FILTER
                (WHERE status_sewa='Selesai')
                AS selesai
                FROM Penyewaan";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);


                NpgsqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read())
                {
                    lblPenyewaan.Text = rd["total"].ToString();
                    lblSedangDisewa.Text = rd["sedang"].ToString();        
                    lblSelesai.Text = rd["selesai"].ToString();
                }
            }

            HitungTerlambat();
        }

        private void HitungTerlambat()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM Penyewaan
                WHERE
                status_sewa='Sedang Disewa'
                AND tgl_pengembalian <
                CURRENT_DATE";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                lblTerlambat.Text = cmd.ExecuteScalar().ToString();

            }
        }
        private void LoadRiwayat()
        {
            flowRiwayat.Controls.Clear();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                p.id_sewa,
                u.nama_user,
                a.merk_alat,
                p.tgl_sewa,
                p.tgl_pengembalian,
                p.total_harga,
                p.status_sewa
                FROM Penyewaan p
                JOIN Users u
                ON p.id_user = u.id_user
                JOIN Alat a
                ON p.id_alat = a.id_alat
                ORDER BY p.id_sewa DESC";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    DateOnly tglSewa =
        (DateOnly)rd["tgl_sewa"];

                    DateOnly tglKembali =
                        (DateOnly)rd["tgl_pengembalian"];

                    int durasi =
                        tglKembali.DayNumber -
                        tglSewa.DayNumber;

                    UCRiwayatPengembalian card =
                        new UCRiwayatPengembalian();

                    card.SetData(
                        Convert.ToInt32(rd["id_sewa"]),
                        rd["nama_user"].ToString(),
                        rd["merk_alat"].ToString(),
                        durasi + " Hari",
                        tglSewa.ToString("dd/MM/yyyy"),
                        tglKembali.ToString("dd/MM/yyyy"),
                        "-",
                        rd["status_sewa"].ToString()
                    );

                    card.KonfirmasiClicked +=
                        Card_KonfirmasiClicked;

                    flowRiwayat.Controls.Add(card);

                }
            }
        }

                private void Card_KonfirmasiClicked(object sender, EventArgs e)
                {
                  UCRiwayatPengembalian card = (UCRiwayatPengembalian)sender;

                     KonfirmasiPengembalian(card.IdSewa);
                }

        private void panelStatistik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowRiwayat_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void KonfirmasiPengembalian(int idSewa)
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                NpgsqlTransaction trans = conn.BeginTransaction();


                try
                {
                    string sqlAlat = @"
                    SELECT id_alat
                    FROM Penyewaan
                    WHERE id_sewa=@id";

                    NpgsqlCommand cmdAlat = new NpgsqlCommand(sqlAlat, conn);


                    cmdAlat.Transaction = trans;
                    cmdAlat.Parameters.AddWithValue("@id", idSewa);
                    int idAlat = Convert.ToInt32(cmdAlat.ExecuteScalar());

                    string sqlTanggal = @"
                    SELECT tgl_pengembalian
                    FROM Penyewaan
                    WHERE id_sewa=@id";

                    NpgsqlCommand cmdTanggal = new NpgsqlCommand(sqlTanggal, conn);
                    cmdTanggal.Transaction = trans;
                    cmdTanggal.Parameters.AddWithValue("@id", idSewa);
                    DateOnly batasKembali = (DateOnly)

                    cmdTanggal.ExecuteScalar();

                    decimal denda = 0;

                    DateOnly hariIni = DateOnly.FromDateTime(DateTime.Today);
                    if (hariIni > batasKembali)
                    {
                        int hariTelat = hariIni.DayNumber - batasKembali.DayNumber;
                        denda = hariTelat * 50000;
                    }

                    string sqlInsert = @"
                    INSERT INTO Pengembalian
                    (
                        id_sewa,
                        tanggal_kembali,
                        denda
                    )
                        VALUES
                    (
                        @sewa,
                        @tgl,
                        @denda
                    )";

                    NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, conn);
                    cmdInsert.Transaction = trans;
                    cmdInsert.Parameters.AddWithValue("@sewa", idSewa);
                    cmdInsert.Parameters.AddWithValue("@tgl", DateTime.Today);
                    cmdInsert.Parameters.AddWithValue("@denda", denda);
                    cmdInsert.ExecuteNonQuery();

                    string sqlUpdateSewa = @"
                    UPDATE Penyewaan
                    SET status_sewa='Selesai'
                    WHERE id_sewa=@id";

                    NpgsqlCommand cmdSewa = new NpgsqlCommand(sqlUpdateSewa, conn);
                    cmdSewa.Transaction = trans;

                    cmdSewa.Parameters.AddWithValue("@id", idSewa);
                    cmdSewa.ExecuteNonQuery();

                    string sqlUpdateStok = @"
                    UPDATE Alat
                    SET stok_tersedia =
                    stok_tersedia + 1
                    WHERE id_alat=@alat";

                    NpgsqlCommand cmdStok = new NpgsqlCommand(sqlUpdateStok, conn);
                    cmdStok.Transaction = trans;

                    cmdStok.Parameters.AddWithValue("@alat", idAlat);
                    cmdStok.ExecuteNonQuery();
                    trans.Commit();

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
                catch (Exception ex)
                {
                    trans.Rollback();

                    MessageBox.Show(ex.Message);

                }
            }
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

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idSewa = Convert.ToInt32(btn.Tag);
            KonfirmasiPengembalian(idSewa);


        }
    }
}
