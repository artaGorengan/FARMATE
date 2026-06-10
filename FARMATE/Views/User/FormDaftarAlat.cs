using FARMATE.Utils;
using FARMATE.Views.Admin;
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
    public partial class FormDaftarAlat : Form
    {
        public FormDaftarAlat()
        {
            InitializeComponent();
        }

        private void BuatCardAlat(
    int idAlat,
    string merk,
    string deskripsi,
    decimal harga,
    string foto)
        {
            Panel card = new Panel();

            card.Width = 280;
            card.Height = 420;

            card.BackColor = Color.White;

            card.Tag = idAlat;

            PictureBox pb = new PictureBox();

            pb.Width = 280;
            pb.Height = 180;

            pb.SizeMode =
                PictureBoxSizeMode.StretchImage;

            if (System.IO.File.Exists(foto))
                pb.Image = Image.FromFile(foto);

            Label lblMerk = new Label();

            lblMerk.Text = merk;
            lblMerk.Font =
                new Font("Poppins", 12, FontStyle.Bold);

            lblMerk.Location =
                new Point(20, 200);

            lblMerk.AutoSize = true;

            Label lblDesk = new Label();

            lblDesk.Text = deskripsi;

            lblDesk.Location =
                new Point(20, 240);

            lblDesk.Size =
                new Size(220, 50);

            Label lblHarga = new Label();

            lblHarga.Text =
                "Rp " + harga.ToString("N0") + " /hari";

            lblHarga.Location =
                new Point(20, 310);

            lblHarga.AutoSize = true;

            Button btnDetail = new Button();

            btnDetail.Text = "Lihat Detail";

            btnDetail.Width = 150;
            btnDetail.Height = 40;

            btnDetail.Location =
                new Point(65, 350);

            btnDetail.Tag = idAlat;



            card.Controls.Add(pb);
            card.Controls.Add(lblMerk);
            card.Controls.Add(lblDesk);
            card.Controls.Add(lblHarga);
            card.Controls.Add(btnDetail);

            flowAlat.Controls.Add(card);
        }

        private void LoadDataAlat()
        {
            if (cmbKategori.SelectedValue == null)
                return;

            if (cmbKategori.SelectedValue is DataRowView)
                return;

            int idKategori =
    Convert.ToInt32(
    cmbKategori.SelectedValue);

            flowAlat.Controls.Clear();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT *
        FROM Alat";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                NpgsqlDataReader rd =
                    cmd.ExecuteReader();

                while (rd.Read())
                {
                    BuatCardAlat(
                        Convert.ToInt32(rd["id_alat"]),
                        rd["merk_alat"].ToString(),
                        rd["deskripsi"].ToString(),
                        Convert.ToDecimal(rd["harga_perhari"]),
                        rd["foto_alat"].ToString()

                    );
                }
            }
        }

        private void FormDaftarAlat_Load(object sender, EventArgs e)
        {

            LoadKategori();

        }

        private void flowAlat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadKategori()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT id_kategori,
                 nama_kategori
          FROM KategoriAlat
          ORDER BY nama_kategori";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbKategori.DataSource = dt;

                cmbKategori.DisplayMember =
                    "nama_kategori";

                cmbKategori.ValueMember =
                    "id_kategori";
            }
        }
        private void BuatCardAlat(
    int idAlat,
    string merk,
    string deskripsi,
    string harga,
    string gambarPath)
        {
            Panel card = new Panel();
            card.Width = 280;
            card.Height = 420;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Tag = idAlat;

            // Gambar
            PictureBox pb = new PictureBox();
            pb.Width = 280;
            pb.Height = 180;
            pb.Location = new Point(0, 0);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!string.IsNullOrEmpty(gambarPath) && File.Exists(gambarPath))
            {
                pb.Image = Image.FromFile(gambarPath);
            }

            // Merk
            Label lblMerk = new Label();
            lblMerk.Text = merk;
            lblMerk.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblMerk.Location = new Point(20, 200);
            lblMerk.AutoSize = true;

            // Deskripsi
            Label lblDeskripsi = new Label();
            lblDeskripsi.Text = deskripsi;
            lblDeskripsi.Location = new Point(20, 240);
            lblDeskripsi.Size = new Size(220, 50);

            // Harga
            Label lblHarga = new Label();
            lblHarga.Text = "Rp " + harga + " /hari";
            lblHarga.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblHarga.ForeColor = Color.DarkGreen;
            lblHarga.Location = new Point(20, 300);
            lblHarga.AutoSize = true;

            // Button Detail
            Button btnDetail = new Button();
            btnDetail.Text = "Lihat Detail";
            btnDetail.Width = 150;
            btnDetail.Height = 40;
            btnDetail.Location = new Point(60, 350);
            btnDetail.Tag = idAlat;

            card.Controls.Add(pb);
            card.Controls.Add(lblMerk);
            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(lblHarga);
            card.Controls.Add(btnDetail);

            flowAlat.Controls.Add(card);
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbKategori.SelectedValue == null)
                return;

            if (cmbKategori.SelectedValue is DataRowView)
                return;

            MessageBox.Show(cmbKategori.SelectedValue.ToString());


            LoadDataAlat();
        }

        private void btnDaftarAlat_Click(object sender, EventArgs e)
        {
            FormDaftarAlat form = new FormDaftarAlat();
            form.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat form = new FormRiwayat();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Hide();
        }
    }

}
