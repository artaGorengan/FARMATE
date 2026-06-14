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

namespace FARMATE.Views.User
{
    public partial class FormRiwayatPenyewaan : Form
    {
        public FormRiwayatPenyewaan()
        {
            InitializeComponent();
        }

        private void FormRiwayatPenyewaan_Load(object sender, EventArgs e)
        {
            LoadRiwayat();
            LoadStatistik();
            LoadKategori();
        }

        private void LoadRiwayat()
        {
            flowRiwayat.Controls.Clear();

            int idKategori = 0;

            if (cmbKategori.SelectedValue != null
                && !(cmbKategori.SelectedValue
                is DataRowView))
            {
                idKategori = Convert.ToInt32(cmbKategori.SelectedValue);

            }



            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                a.merk_alat,
                k.nama_kategori,
                p.tgl_sewa,
                p.tgl_pengembalian,
                p.status_sewa
                FROM Penyewaan p
                JOIN Alat a
                ON p.id_alat = a.id_alat
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori
                WHERE p.id_user=@user";

                if (idKategori != 0)
                {
                    sql += " AND k.id_kategori=@kategori";
                }

                sql += " ORDER BY p.id_sewa DESC";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", UserSession.UserID);
                if (idKategori != 0)
                {
                    cmd.Parameters.AddWithValue("@kategori", idKategori);
                }

                NpgsqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    UCRiwayat uc = new UCRiwayat();

                    DateOnly tglSewa =
                        (DateOnly)rd["tgl_sewa"];

                    DateOnly tglKembali =
                        (DateOnly)rd["tgl_pengembalian"];

                    int durasi =
                        tglKembali.DayNumber -
                        tglSewa.DayNumber;

                    uc.SetData(
                        rd["merk_alat"].ToString(),
                        rd["nama_kategori"].ToString(),
                        durasi + " Hari",
                        tglSewa.ToString("dd/MM/yyyy"),
                        tglKembali.ToString("dd/MM/yyyy"),
                        "Rp0",
                        rd["status_sewa"].ToString()
                    );

                    flowRiwayat.Controls.Add(uc);
                }
            }
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
                FROM Penyewaan
                WHERE id_user=@user";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", UserSession.UserID);
                NpgsqlDataReader rd =
                    cmd.ExecuteReader();

                if (rd.Read())
                {
                    lblTotalPenyewaan.Text = rd["total"].ToString();
                    lblSedangDisewa.Text = rd["sedang"].ToString();
                    lblSelesai.Text = rd["selesai"].ToString();
                    lblTerlambat.Text = "0";
                }
            }
        }



        private void panelDaftar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedValue == null)
                return;

            if (cmbKategori.SelectedValue
                is DataRowView)
                return;

            LoadRiwayat();
        }

        private void LoadKategori()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                id_kategori,
                nama_kategori
                FROM KategoriAlat
                ORDER BY nama_kategori";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.NewRow();


                row["id_kategori"] = 0;
                row["nama_kategori"] = "Semua Kategori";
                dt.Rows.InsertAt(row, 0);

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "id_kategori";

            }
        }

        private void lblDaftarAlat_Click(object sender, EventArgs e)
        {
            FormDaftarAlat form = new FormDaftarAlat();
            form.Show();
            this.Hide();
        }

        private void lblRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPenyewaan form = new FormRiwayatPenyewaan();
            form.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Hide();
        }

        private void flowRiwayat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalPenyewaan_Click(object sender, EventArgs e)
        {

        }
    }
}
