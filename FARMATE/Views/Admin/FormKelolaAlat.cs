using FARMATE.Models;
using FARMATE.Session;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public FormKelolaAlat()
        {
            InitializeComponent();
        }


        private void btnDataUser_Click(object sender, EventArgs e)
        {
            FormDataUser form = new FormDataUser();
            form.Show();
            this.Hide();
        }

        private void btnRiwayatPengembalian_Click(object sender, EventArgs e)
        {
            FormRiwayatPengembalian form = new FormRiwayatPengembalian();

            form.Show();
            this.Hide();
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            panelDaftarAlat.Visible = false;
            panelTambahAlat.Visible = true;
        }

        private void FormKelolaAlat_Load(object sender, EventArgs e)
        {
            panelDaftarAlat.Visible = true;
            panelTambahAlat.Visible = false;

            cmbBahanBakar.Items.Add("Solar");
            cmbBahanBakar.Items.Add("Listrik");

            LoadKategori();
            LoadDataAlat();
            LoadStatistik();

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            panelTambahAlat.Visible = false;

            panelDaftarAlat.Visible = true;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadKategori()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id_kategori, nama_kategori FROM KategoriAlat";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "id_kategori";
            }
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

        }
        private void TambahAlat()
        {
            using (var conn = Koneksi.GetConnection())
            {


                conn.Open();
                string sql = @"INSERT INTO Alat (id_admin, id_kategori, merk_alat, deskripsi, harga_perhari, stok_total, stok_tersedia, bahan_bakar)
                                VALUES 
                               (@admin, @kategori, @merk, @deskripsi, @harga, @stoktotal, @stoktersedia, @bbm)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@admin", UserSession.AdminID);
                cmd.Parameters.AddWithValue("@kategori", Convert.ToInt32(cmbKategori.SelectedValue));
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stoktotal", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@stoktersedia", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@bbm", cmbBahanBakar.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alat berhasil ditambahkan");
            panelTambahAlat.Visible = false;
            panelDaftarAlat.Visible = true;

            BersihkanForm();
            LoadDataAlat();
            LoadStatistik();
        }

        private void BersihkanForm()
        {
            txtMerk.Clear();

            txtDeskripsi.Clear();

            txtHarga.Clear();

            txtStok.Clear();

            cmbKategori.SelectedIndex = -1;

            cmbBahanBakar.SelectedIndex = -1;
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
               k.nama_kategori, 
               a.harga_perhari, 
               a.stok_tersedia 
               FROM Alat a 
               JOIN KategoriAlat k 
               ON a.id_kategori = k.id_kategori 
               ORDER BY a.id_alat";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                NpgsqlDataReader rd = cmd.ExecuteReader();
                flowDrone.Controls.Clear();
                flowTraktor.Controls.Clear();
                flowPanen.Controls.Clear();

                while (rd.Read())
                {
                    string kategori = rd["nama_kategori"].ToString();


                    if (kategori == "Drone Pertanian")

                    {

                        BuatCardAlat(
                            flowDrone,
                            Convert.ToInt32(rd["id_alat"]),
                            rd["merk_alat"].ToString(),
                            kategori,
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
                            kategori,
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
                            kategori,
                            rd["harga_perhari"].ToString(),
                            rd["stok_tersedia"].ToString()
                        );
                    }

                }

            }

        }
        private void BuatCardAlat(FlowLayoutPanel panel, int idAlat, string merk, string kategori, string harga, string stok)
        {
            Panel card = new Panel();
            card.Tag = idAlat;

            card.Click += Card_Click;



            card.Width = 220;
            card.Height = 130;

            card.BorderStyle = BorderStyle.FixedSingle;
            PictureBox pb = new PictureBox();
            pb.Width = 250;
            pb.Height = 120;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblMerk = new Label();
            lblMerk.Text = merk;
            lblMerk.Location = new Point(10, 10);

            Label lblKategori = new Label();
            lblKategori.Text = kategori;
            lblKategori.Location = new Point(10, 40);

            Label lblHarga = new Label();
            lblHarga.Text = "Rp " + harga;
            lblHarga.Location = new Point(10, 70);

            Label lblStok = new Label();
            lblStok.Text = "Stok : " + stok;
            lblStok.Location = new Point(10, 100);

            card.Controls.Add(lblMerk);
            card.Controls.Add(lblKategori);
            card.Controls.Add(lblHarga);
            card.Controls.Add(lblStok);

            panel.Controls.Add(card);
        }



        private void panelTambahAlat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT id_kategori, nama_kategori
                FROM KategoriAlat
                ORDER BY
                CASE
                WHEN nama_kategori = 'Drone Pertanian' THEN 1
                WHEN nama_kategori = 'Traktor' THEN 2
                WHEN nama_kategori = 'Mesin Panen' THEN 3
                END";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kategori berhasil ditambahkan");
        }

        private void flowLayoutPanelAlat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowDrone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowTraktor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanen_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Card_Click(object sender, EventArgs e)
        {
            if (selectedCard != null)
                selectedCard.BackColor = Color.White;

            selectedCard = (Panel)sender;

            selectedCard.BackColor = Color.LightGreen;

            selectedIdAlat = Convert.ToInt32(selectedCard.Tag);

            Panel card = (Panel)sender;
            selectedIdAlat = Convert.ToInt32(card.Tag);

        }


        private void LoadDataAlatTerpilih()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT *
                FROM Alat
                WHERE id_alat=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedIdAlat);

                NpgsqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    txtMerk.Text = rd["merk_alat"].ToString();
                    txtDeskripsi.Text = rd["deskripsi"].ToString();
                    txtHarga.Text = rd["harga_perhari"].ToString();
                    txtStok.Text = rd["stok_total"].ToString();
                    cmbBahanBakar.Text = rd["bahan_bakar"].ToString();

                    panelTambahAlat.Visible = true;
                    panelDaftarAlat.Visible = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE Alat
                SET
                merk_alat=@merk,
                deskripsi=@deskripsi,
                harga_perhari=@harga,
                stok_total=@stok,
                stok_tersedia=@stok,
                bahan_bakar=@bbm
                WHERE id_alat=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedIdAlat);
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@bbm", cmbBahanBakar.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil diupdate");

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
                WHERE id_alat=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idAlat);

                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtMerk.Text = rd["merk_alat"].ToString();
                    txtDeskripsi.Text = rd["deskripsi"].ToString();
                    txtHarga.Text = rd["harga_perhari"].ToString();
                    txtStok.Text = rd["stok_total"].ToString();
                    cmbBahanBakar.Text = rd["bahan_bakar"].ToString();
                    cmbKategori.SelectedValue = rd["id_kategori"];

                    panelDaftarAlat.Visible = false;
                    panelTambahAlat.Visible = true;

                    isEditMode = true;

                    btnSimpan.Text = "Update";



                }
            }
        }

        private void UpdateAlat()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE Alat
                SET
                id_kategori=@kategori,
                merk_alat=@merk,
                deskripsi=@deskripsi,
                harga_perhari=@harga,
                stok_total=@stok,
                stok_tersedia=@stok,
                bahan_bakar=@bbm
                WHERE id_alat=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedIdAlat);
                cmd.Parameters.AddWithValue("@kategori", Convert.ToInt32(cmbKategori.SelectedValue));
                cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@bbm", cmbBahanBakar.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil diupdate");

            isEditMode = false;
            selectedIdAlat = 0;

            btnSimpan.Text = "Simpan";

            BersihkanForm();

            panelTambahAlat.Visible = false;
            panelDaftarAlat.Visible = true;

            LoadDataAlat();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();

            form.Show();

            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdAlat == 0)
            {
                MessageBox.Show("Pilih alat terlebih dahulu");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Yakin ingin menghapus alat ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Alat WHERE id_alat=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", selectedIdAlat);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil dihapus");
            selectedIdAlat = 0;

            LoadDataAlat();
            LoadStatistik();
        }

        private void panelEditAlat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
        }

        private void LoadStatistik()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                // Total Alat
                string sqlAlat =
                    "SELECT COUNT(*) FROM Alat";

                NpgsqlCommand cmdAlat =
                    new NpgsqlCommand(sqlAlat, conn);

                lblTotalAlat.Text =
                    cmdAlat.ExecuteScalar().ToString();

                // Total User
                string sqlUser =
                    "SELECT COUNT(*) FROM Users";

                NpgsqlCommand cmdUser =
                    new NpgsqlCommand(sqlUser, conn);

                lblTotalUser.Text =
                    cmdUser.ExecuteScalar().ToString();

                // Total Penyewaan
                string sqlSewa =
                    "SELECT COUNT(*) FROM Penyewaan";

                NpgsqlCommand cmdSewa =
                    new NpgsqlCommand(sqlSewa, conn);

                lblTotalSewa.Text =
                    cmdSewa.ExecuteScalar().ToString();
            }
        }

        private void panelDaftarAlat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
