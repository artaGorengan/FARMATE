using FARMATE.Controller;
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
            cmbKategori.SelectedIndexChanged +=
        cmbKategori_SelectedIndexChanged;
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

            if (cmbKategori.SelectedValue != null &&
                !(cmbKategori.SelectedValue is DataRowView))
            {
                idKategori =
                    Convert.ToInt32(
                        cmbKategori.SelectedValue);
            }

            RiwayatController controller =
                new RiwayatController();

            DataTable dt =
                controller.GetRiwayatUser(
                    UserSession.UserID,
                    idKategori);

            foreach (DataRow row in dt.Rows)
            {
                UCRiwayat uc =
                    new UCRiwayat();

                DateOnly tglSewa =
                    (DateOnly)row["tgl_sewa"];

                DateOnly tglKembali =
                    (DateOnly)row["tgl_pengembalian"];

                int durasi =
                    tglKembali.DayNumber -
                    tglSewa.DayNumber;

                uc.SetData(
                    row["merk_alat"].ToString(),
                    row["nama_kategori"].ToString(),
                    durasi + " Hari",
                    tglSewa.ToString("dd/MM/yyyy"),
                    tglKembali.ToString("dd/MM/yyyy"),
                    "Rp0",
                    row["status_sewa"].ToString()
                );

                flowRiwayat.Controls.Add(uc);
            }
        }

        private void LoadStatistik()
        {
            RiwayatController controller =
                new RiwayatController();

            DataTable dt =
                controller.GetStatistikUser(
                    UserSession.UserID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblTotalPenyewaan.Text =
                    row["total"].ToString();

                lblSedangDisewa.Text =
                    row["sedang"].ToString();

                lblSelesai.Text =
                    row["selesai"].ToString();

                lblTerlambat.Text = "0";
            }
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
        private void panelDaftar_Paint(object sender, PaintEventArgs e)
        {

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
