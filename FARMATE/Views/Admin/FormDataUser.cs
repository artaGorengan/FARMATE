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
        private void BuatBarisUser(string nama, string username, string email, string hp, string alamat, string totalSewa)
        {
            Panel row = new Panel();

            row.Width = 1200;
            row.Height = 45;

            Label lblNama = new Label();
            lblNama.Text = nama;
            lblNama.Location = new Point(30, 15);

            Label lblUsername = new Label();
            lblUsername.Text = username;
            lblUsername.Location = new Point(230, 15);

            Label lblEmail = new Label();
            lblEmail.Text = email;
            lblEmail.Location = new Point(430, 15);

            Label lblHp = new Label();
            lblHp.Text = hp;
            lblHp.Location = new Point(630, 15);

            Label lblAlamat = new Label();
            lblAlamat.Text = alamat;
            lblAlamat.Location = new Point(850, 15);

            Label lblTotal = new Label();
            lblTotal.Text = totalSewa;
            lblTotal.Location = new Point(1080, 15);

            row.Controls.Add(lblNama);
            row.Controls.Add(lblUsername);
            row.Controls.Add(lblEmail);
            row.Controls.Add(lblHp);
            row.Controls.Add(lblAlamat);
            row.Controls.Add(lblTotal);

            flowUser.Controls.Add(row);
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
