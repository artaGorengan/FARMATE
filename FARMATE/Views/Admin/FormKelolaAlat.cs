using FARMATE.Models;
using FARMATE.Session;
using FARMATE.Utils;
using FARMATE.Views.User;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.Admin
{
    public partial class FormKelolaAlat : Form
    {
        private int selectedIdAlat = 0;

        private UCAlatCard selectedCard = null;
        public FormKelolaAlat()
        {
            InitializeComponent();
        }
        private void FormKelolaAlat_Load(object sender, EventArgs e)
        {
            LoadDataAlat();
            LoadStatistik();
        }

        private UCTambahAlat ucTambah;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedIdAlat == 0)
            {
                MessageBox.Show("Pilih alat terlebih dahulu");
                return;
            }
            TampilTambahAlat();
            ucTambah.LoadDataEdit(selectedIdAlat);
        }
        private void TampilTambahAlat()
        {
            ucTambah = new UCTambahAlat();
            ucTambah.Dock = DockStyle.Fill;
            ucTambah.OnSimpanBerhasil += () =>
            {
                this.Controls.Remove(ucTambah);
                LoadDataAlat();
                LoadStatistik();
                TampilHalamanUtama();
            };

            ucTambah.OnBatal += () =>
            {
                this.Controls.Remove(ucTambah);
                TampilHalamanUtama();
            };

            SembunyikanHalamanUtama();
            this.Controls.Add(ucTambah);
            ucTambah.BringToFront();
        }

        private void SembunyikanHalamanUtama()
        {
            panelSidebar.Visible = false;
            panelNavbar.Visible = false;
            panelContent.Visible = false;
        }

        private void TampilHalamanUtama()
        {
            panelSidebar.Visible = true;
            panelNavbar.Visible = true;
            panelContent.Visible = true;
        }
        private void flowDrone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadDataAlat()
        {
            flowDrone.Controls.Clear();
            flowTraktor.Controls.Clear();
            flowPanen.Controls.Clear();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                a.id_alat,
                a.merk_alat,
                a.harga_perhari,
                a.stok_tersedia,
                a.foto_alat,
                k.nama_kategori
                FROM Alat a
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    string kategori =
                        rd["nama_kategori"].ToString();

                    if (kategori == "Drone Pertanian")
                    {
                        UCAlatCard card = new UCAlatCard();
                        card.SetData(
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );

                        card.CardClicked += Card_Click;

                        flowDrone.Controls.Add(card);
                    }

                    else if (kategori == "Traktor")
                    {
                        UCAlatCard card = new UCAlatCard();
                        card.SetData(
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );

                        card.CardClicked += Card_Click;
                        flowTraktor.Controls.Add(card);
                    }

                    else if (kategori == "Mesin Panen")
                    {
                        UCAlatCard card = new UCAlatCard();


                        card.SetData(
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );

                        card.CardClicked += Card_Click;
                        flowPanen.Controls.Add(card);
                    }
                }
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (selectedCard != null)
                selectedCard.SetSelected(false);
            selectedCard =  (UCAlatCard)sender;
            selectedCard.SetSelected(true);
            selectedIdAlat = selectedCard.IdAlat;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdAlat == 0)
            {
                MessageBox.Show("Pilih alat terlebih dahulu");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus alat ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (hasil == DialogResult.No)
                return;

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Alat WHERE id_alat=@id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedIdAlat);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alat berhasil dihapus");

            selectedIdAlat = 0;

            LoadDataAlat();
            LoadStatistik();
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

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            FormKelolaAlat form = new FormKelolaAlat();
            form.Show();
            this.Hide();
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            FormDataUser form = new FormDataUser();
            form.Show();
            this.Hide();
        }

        private void LoadStatistik()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                // Total Alat 
                string sqlTotal = "SELECT COUNT(*) FROM Alat";
                lblTotalAlat.Text = new NpgsqlCommand(sqlTotal, conn)
                    .ExecuteScalar()
                    .ToString();


                // Drone
                string sqlDrone = @"
                SELECT COUNT(*)
                FROM Alat a
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori
                WHERE k.nama_kategori='Drone Pertanian'";

                lblTotalDrone.Text = new NpgsqlCommand(sqlDrone, conn)
                    .ExecuteScalar()
                    .ToString();


                // Traktor
                string sqlTraktor = @"
                SELECT COUNT(*)
                FROM Alat a
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori
                WHERE k.nama_kategori='Traktor'";

                lblTotalTraktor.Text = new NpgsqlCommand(sqlTraktor, conn)
                    .ExecuteScalar()
                    .ToString();


                // Mesin Panen
                string sqlPanen = @"
                SELECT COUNT(*)
                FROM Alat a
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori
                WHERE k.nama_kategori='Mesin Panen'";

                lblTotalPanen.Text = new NpgsqlCommand(sqlPanen, conn)
                    .ExecuteScalar()
                    .ToString();
            }
        }

        private void flowTraktor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TampilTambahAlat();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
