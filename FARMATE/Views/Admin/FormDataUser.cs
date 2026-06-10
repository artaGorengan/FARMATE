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
            BuatBarisUser(
        "Andi",
        "andi123",
        "andi@gmail.com",
        "08123456789",
        "Malang",
        "3");

            BuatBarisUser(
                "Budi",
                "budi77",
                "budi@gmail.com",
                "08111111111",
                "Blitar",
                "5");
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            FormKelolaAlat form = new FormKelolaAlat();
            form.Show();
            this.Hide();
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

        private void BuatBarisUser(
    string nama,
    string username,
    string email,
    string hp,
    string alamat,
    string totalSewa)
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

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            FormDataUser form = new FormDataUser();
            form.Show();
            this.Hide();
        }
    }
}
