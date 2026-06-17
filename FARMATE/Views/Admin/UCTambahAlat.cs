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

namespace FARMATE.Views.Admin
{
    public partial class UCTambahAlat : UserControl
    {
        private bool isEditMode = false;
        private int selectedIdAlat = 0;
        private string fotoPath = "";
        public event Action OnBatal;
        public UCTambahAlat()
        {
            InitializeComponent();
            LoadKategori();
            LoadBBM();
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
                cmd.Parameters.AddWithValue("@deskripsi", RTBDeskripsi.Text);
                cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("@bbm", cmbBBM.Text);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data berhasil diupdate");
            isEditMode = false;
            btnSimpan.Text = "Simpan";
            ClearForm();
        }
        private void TambahAlat()
        {
            try
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
                    cmd.Parameters.AddWithValue("@kategori", Convert.ToInt32(cmbKategori.SelectedValue));
                    cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", RTBDeskripsi.Text);
                    cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                    cmd.Parameters.AddWithValue("@stoktotal", int.Parse(txtStok.Text));
                    cmd.Parameters.AddWithValue("@stoktersedia", int.Parse(txtStok.Text));
                    cmd.Parameters.AddWithValue("@bbm", cmbBBM.Text);
                    cmd.Parameters.AddWithValue("@foto", fotoPath);
                    MessageBox.Show(fotoPath);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Alat berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearForm();
        }
        public void LoadDataEdit(int idAlat)
        {

            selectedIdAlat = idAlat;

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT *
                FROM Alat
                WHERE id_alat=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@id", idAlat);

                NpgsqlDataReader rd = cmd.ExecuteReader();


                if (rd.Read())
                {
                    txtMerk.Text = rd["merk_alat"].ToString();
                    RTBDeskripsi.Text = rd["deskripsi"].ToString();
                    txtHarga.Text = rd["harga_perhari"].ToString();
                    txtStok.Text = rd["stok_total"].ToString();
                    cmbBBM.Text = rd["bahan_bakar"].ToString();
                    cmbKategori.SelectedValue = rd["id_kategori"];
                    fotoPath = rd["foto_alat"].ToString();
                    if (System.IO.File.Exists(fotoPath))
                    {
                        pbFotoAlat.Image =
                            Image.FromFile(fotoPath);
                    }

                    isEditMode = true;

                    btnSimpan.Text =
                        "Update";
                }
            }
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
                FROM KategoriAlat;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "id_kategori";

            }
        }
        private void LoadBBM()
        {
            cmbBBM.Items.Clear();
            cmbBBM.Items.Add("Solar");
            cmbBBM.Items.Add("Listrik");
            cmbBBM.Items.Add("Tidak Ada");
        }
        private void UCTambahAlat_Load(object sender, EventArgs e)
        {

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
      
        private void ClearForm()
        {
            txtMerk.Clear();
            RTBDeskripsi.Clear();
            txtHarga.Clear();
            txtStok.Clear();

            cmbKategori.SelectedIndex = -1;
            cmbBBM.SelectedIndex = -1;

            pbFotoAlat.Image = null;

            fotoPath = "";
        }
        public event Action OnSimpanBerhasil;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtMerk.Text == "" ||
            txtHarga.Text == ""    ||
            txtStok.Text == ""     ||
            cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi data terlebih dahulu");
                return;
            }

            if (isEditMode)
            {
                UpdateAlat();
            }
            else
            {
                TambahAlat();
            }

            OnSimpanBerhasil?.Invoke();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            OnBatal?.Invoke();
        }
    
    }
}
