using FARMATE.Models;
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


        private void BtnDetail_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idAlat = Convert.ToInt32(btn.Tag);
            FormDetailAlat form = new FormDetailAlat(idAlat);
            form.ShowDialog();
            


        }

        private void Card_DetailClicked(object sender, EventArgs e)
        {
            UCAlat card = (UCAlat)sender;
            FormDetailAlat form = new FormDetailAlat(card.IdAlat);
            form.Show();
           
        }
        private void LoadDataAlat()
        {
            flowAlat.Controls.Clear();
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT *
                FROM Alat";

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;

                int kategori = 0;

                if (cmbKategori.SelectedValue != null &&
                    !(cmbKategori.SelectedValue is DataRowView))
                {
                    kategori = Convert.ToInt32(cmbKategori.SelectedValue);
                }

                if (kategori != 0)
                {
                    sql += " WHERE id_kategori = @kategori";
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                }

                cmd.CommandText = sql;
                NpgsqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    UCAlat card = new UCAlat();
                    card.SetData(
                        Convert.ToInt32(rd["id_alat"]),
                        rd["merk_alat"].ToString(),
                        rd["deskripsi"].ToString(),
                        Convert.ToDecimal(rd["harga_perhari"]),
                        rd["foto_alat"].ToString()
                    );

                    card.DetailClicked += Card_DetailClicked;

                    flowAlat.Controls.Add(card);
                }
            }
        }
        private void FormDaftarAlat_Load(object sender, EventArgs e)
        {

            LoadKategori();
            cmbKategori.SelectedIndex = 0;
            LoadDataAlat();
          
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
                ORDER BY id_kategori";

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
     
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbKategori.SelectedValue == null)
                return;

            if (cmbKategori.SelectedValue is DataRowView)
                return;
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
    }

}
