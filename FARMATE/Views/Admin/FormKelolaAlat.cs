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
using FARMATE.Controller;

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

        private void LoadDataAlat()
        {
            flowDrone.Controls.Clear();
            flowTraktor.Controls.Clear();
            flowPanen.Controls.Clear();

            AlatController controller =
                new AlatController();

            DataTable dt =
                controller.GetAllAlat();

            foreach (DataRow row in dt.Rows)
            {
                string kategori =
                    row["nama_kategori"].ToString();

                UCAlatCard card =
                    new UCAlatCard();

                card.SetData(
                    Convert.ToInt32(row["id_alat"]),
                    row["merk_alat"].ToString(),
                    row["harga_perhari"].ToString(),
                    row["stok_tersedia"].ToString(),
                    row["foto_alat"].ToString()
                );

                card.CardClicked += Card_Click;

                if (kategori == "Drone Pertanian")
                    flowDrone.Controls.Add(card);

                else if (kategori == "Traktor")
                    flowTraktor.Controls.Add(card);

                else if (kategori == "Mesin Panen")
                    flowPanen.Controls.Add(card);
            }
        }
        private void LoadStatistik()
        {
            AlatController controller =
                new AlatController();

            DataTable dt =
                controller.GetStatistik();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblTotalAlat.Text =
                    row["total_alat"].ToString();

                lblTotalDrone.Text =
                    row["drone"].ToString();

                lblTotalTraktor.Text =
                    row["traktor"].ToString();

                lblTotalPanen.Text =
                    row["panen"].ToString();
            }
        }
        private void Card_Click(object sender, EventArgs e)
        {
            if (selectedCard != null)
            selectedCard.SetSelected(false);
            selectedCard = (UCAlatCard)sender;
            selectedCard.SetSelected(true);
            selectedIdAlat = selectedCard.IdAlat;
        }
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

            AlatController controller =
     new AlatController();

            controller.HapusAlat(
                selectedIdAlat);
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            TampilTambahAlat();
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

        private void flowTraktor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void flowDrone_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
