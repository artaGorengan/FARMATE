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
        private bool isEditMode = false;
        private Panel selectedCard = null;

        private string fotoPath = "";


        public FormKelolaAlat()
        {
            InitializeComponent();
        }
        private void FormKelolaAlat_Load(object sender, EventArgs e)
        {
            Panel card = new Panel();

            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Drone Pertanian");
            cmbKategori.Items.Add("Traktor");
            cmbKategori.Items.Add("Mesin Panen");

            cmbBBM.Items.Clear();
            cmbBBM.Items.Add("Solar");
            cmbBBM.Items.Add("Listrik");

            LoadDataAlat();
        }
        private void flowDrone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            panelTambahAlat.Visible = true;
            panelTambahAlat.BringToFront();

            txtMerk.Clear();
            txtDeskripsi.Clear();
            txtHarga.Clear();
            txtStok.Clear();

            cmbKategori.SelectedIndex = -1;
            cmbBBM.SelectedIndex = -1;

            pbFotoAlat.Image = null;

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

            panelTambahAlat.Visible = false;

        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoPath = ofd.FileName;
                pbFotoAlat.Image = Image.FromFile(fotoPath);
            }
        }

        private void pbFotoAlat_Click(object sender, EventArgs e)
        {

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
                ORDER BY
                CASE
                WHEN nama_kategori = 'Drone Pertanian' THEN 1
                WHEN nama_kategori = 'Traktor' THEN 2
                WHEN nama_kategori = 'Mesin Panen' THEN 3
                END";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);


                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "id_kategori";
            }
        }
        private void TambahAlat()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO Alat
                (id_admin,id_kategori,merk_alat, deskripsi,harga_perhari,stok_total,stok_tersedia, bahan_bakar,foto_alat )
                VALUES
                (@admin, @kategori,@merk,@deskripsi,@harga,@stoktotal, @stoktersedia,@bbm,@foto)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@admin", UserSession.AdminID);

                int idKategori = 0;

                if (cmbKategori.Text == "Drone Pertanian")
                    idKategori = 1;
                else if (cmbKategori.Text == "Traktor")
                    idKategori = 2;
                else if (cmbKategori.Text == "Mesin Panen")
                    idKategori = 3;

                cmd.Parameters.AddWithValue("@kategori", idKategori);
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stoktotal", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@stoktersedia", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@bbm", cmbBBM.Text);
                cmd.Parameters.AddWithValue("@foto", fotoPath);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alat berhasil ditambahkan");
        }
        private void BuatCardAlat(FlowLayoutPanel panel, int idAlat, string merk, string harga, string stok)
        {
            Panel card = new Panel();
            card.Tag = idAlat;
            card.Click += Card_Click;

            card.Width = 220;
            card.Height = 120;
            card.BorderStyle = BorderStyle.FixedSingle;

            Label lblMerk = new Label();
            lblMerk.Text = merk;
            lblMerk.Location = new Point(10, 10);
            lblMerk.AutoSize = true;
            lblMerk.AutoSize = true;

            Label lblHarga = new Label();
            lblHarga.Text = "Rp " + harga;
            lblHarga.Location = new Point(10, 40);
            lblHarga.AutoSize = true;

            Label lblStok = new Label();
            lblStok.Text = "Stok : " + stok;
            lblStok.Location = new Point(10, 70);
            lblStok.AutoSize = true;

            card.Controls.Add(lblMerk);
            card.Controls.Add(lblHarga);
            card.Controls.Add(lblStok);

            panel.Controls.Add(card);
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
                        BuatCardAlat(
                            flowDrone,
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );
                    }

                    else if (kategori == "Traktor")
                    {
                        BuatCardAlat(
                            flowTraktor,
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );
                    }

                    else if (kategori == "Mesin Panen")
                    {
                        BuatCardAlat(
                            flowPanen,
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );
                    }
                }
            }
        }

        private void UpdateAlat()
        {
            int idKategori = 0;

            if (cmbKategori.Text == "Drone Pertanian")
                idKategori = 1;
            else if (cmbKategori.Text == "Traktor")
                idKategori = 2;
            else if (cmbKategori.Text == "Mesin Panen")
                idKategori = 3;

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE Alat
                SET
                id_kategori = @kategori,
                merk_alat = @merk,
                deskripsi = @deskripsi,
                harga_perhari = @harga,
                stok_total = @stok,
                stok_tersedia = @stok,
                bahan_bakar = @bbm
                WHERE id_alat = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", selectedIdAlat);
                cmd.Parameters.AddWithValue("@kategori", idKategori);
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@harga",
                    decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stok",
                    int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@bbm",
                    cmbBBM.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil diupdate");

            isEditMode = false;

            btnSimpan.Text = "Simpan";
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (isEditMode)
            {
                UpdateAlat();
            }
            else
            {
                TambahAlat();
            }


            panelTambahAlat.Visible = false;

            LoadDataAlat();
        }

        private void LoadDataEdit(int idAlat)
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
        SELECT *
        FROM Alat
        WHERE id_alat = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", idAlat);

                NpgsqlDataReader rd =
                    cmd.ExecuteReader();

                if (rd.Read())
                {
                    txtMerk.Text =
                        rd["merk_alat"].ToString();

                    txtDeskripsi.Text =
                        rd["deskripsi"].ToString();

                    txtHarga.Text =
                        rd["harga_perhari"].ToString();

                    txtStok.Text =
                        rd["stok_total"].ToString();

                    cmbBBM.Text =
                        rd["bahan_bakar"].ToString();

                    int idKategori =
                        Convert.ToInt32(rd["id_kategori"]);

                    if (idKategori == 1)
                        cmbKategori.Text = "Drone Pertanian";
                    else if (idKategori == 2)
                        cmbKategori.Text = "Traktor";
                    else if (idKategori == 3)
                        cmbKategori.Text = "Mesin Panen";

                    panelTambahAlat.Visible = true;

                    isEditMode = true;

                    btnSimpan.Text = "Update";
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedIdAlat == 0)
            {
                MessageBox.Show("Pilih alat terlebih dahulu");
                return;
            }

            LoadDataEdit(selectedIdAlat);
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            if (selectedCard != null)
                selectedCard.BackColor = Color.White;

            selectedCard = card;

            selectedCard.BackColor = Color.LightGreen;

            selectedIdAlat =
                Convert.ToInt32(card.Tag);
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

                string sql =
                    "DELETE FROM Alat WHERE id_alat=@id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id",
                    selectedIdAlat);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alat berhasil dihapus");

            selectedIdAlat = 0;

            LoadDataAlat();
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
    }

}
