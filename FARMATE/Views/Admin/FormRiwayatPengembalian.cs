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
                    DateOnly tglSewa = (DateOnly)rd["tgl_sewa"];
                    DateOnly tglKembali = (DateOnly)rd["tgl_pengembalian"];
                    int durasi = tglKembali.DayNumber - tglSewa.DayNumber;
                    decimal denda = 0;

                    if (rd["status_sewa"].ToString() == "Sedang Disewa")
                    {
                        DateOnly batas =
                        (DateOnly)rd["tgl_pengembalian"];
                        DateOnly hariIni =
                        DateOnly.FromDateTime(
                        DateTime.Today);

                        if (hariIni > batas)
                        {
                            int telat = hariIni.DayNumber - batas.DayNumber;
                            denda = telat * 50000;
                        }

                    }

                    BuatCardRiwayat(
                    Convert.ToInt32(rd["id_sewa"]),
                    rd["nama_user"].ToString(),
                    rd["merk_alat"].ToString(),
                    durasi + " Hari",
                    tglSewa.ToString("dd/MM/yyyy"),
                    tglKembali.ToString("dd/MM/yyyy"),
                    "Rp " + denda.ToString("N0"),
                    rd["status_sewa"].ToString()
                    );


                }
            }
        }

      
        private void panelStatistik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowRiwayat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuatCardRiwayat(
        int idSewa,
        string nama,
        string alat,
        string durasi,
        string tglPinjam,
        string tglKembali,
        string denda,
        string status)
        {
            Panel card = new Panel();

            card.Width = 1300;
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

            Button btnKonfirmasi = new Button();

            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.Width = 100;
            btnKonfirmasi.Height = 35;

            if (status.ToString() == "Selesai")
            {
                btnKonfirmasi.Visible = false;
            }

            btnKonfirmasi.Location =
                new Point(1020, 12);

            btnKonfirmasi.Tag = idSewa;

            btnKonfirmasi.Click +=
                btnKonfirmasi_Click;

            card.Controls.Add(btnKonfirmasi);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblAlat);
            card.Controls.Add(lblDurasi);
            card.Controls.Add(lblPinjam);
            card.Controls.Add(lblKembali);
            card.Controls.Add(lblDenda);
            card.Controls.Add(lblStatus);

            flowRiwayat.Controls.Add(card);

            if (status == "Selesai")
            {
                btnKonfirmasi.Visible = false;
            }
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
