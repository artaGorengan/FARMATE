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
    public partial class FormDataUser : Form
    {
        public FormDataUser()
        {
            InitializeComponent();
        }

        private void FormDataUser_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void LoadDataUser()
        {
            flowUser.Controls.Clear();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                u.nama_user,
                u.username,
                u.email,
                u.no_telepon,
                u.alamat,
                COUNT(p.id_sewa) AS total_sewa
                FROM Users u
                LEFT JOIN Penyewaan p
                ON u.id_user = p.id_user
                GROUP BY
                u.id_user,
                u.nama_user,
                u.username,
                u.email,
                u.no_telepon,
                u.alamat";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    UCDataUser row = new UCDataUser();
                    row.SetData(
                    rd["nama_user"].ToString(),
                    rd["username"].ToString(),
                    rd["email"].ToString(),
                    rd["no_telepon"].ToString(),
                    rd["alamat"].ToString(),
                    rd["total_sewa"].ToString());

                    flowUser.Controls.Add(row);
                }
            }
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPengembalian form = new FormRiwayatPengembalian();
            form.Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
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

        private void flowUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
