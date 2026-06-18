using FARMATE.Controller;
using FARMATE.Models;
using FARMATE.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FARMATE.Repositories;


namespace FARMATE.Views.User
{
    public partial class FormDaftarAlat : Form
    {
        public FormDaftarAlat()
        {
            InitializeComponent();           
        }
        private void FormDaftarAlat_Load(object sender, EventArgs e)
        {
            LoadKategori();
            cmbKategori.SelectedIndex = 0;
            LoadDataAlat();
        }
        private void LoadDataAlat()
        {
            flowAlat.Controls.Clear();

            int kategori = 0;

            if (cmbKategori.SelectedValue != null &&
                !(cmbKategori.SelectedValue is DataRowView))
            {
                kategori =
                    Convert.ToInt32(
                        cmbKategori.SelectedValue);
            }

            AlatController controller = new AlatController();
            DataTable dt = controller.GetDaftarAlat(kategori);

            foreach (DataRow row in dt.Rows)
            {
                UCAlat card = new UCAlat();
                card.SetData(
                    Convert.ToInt32(row["id_alat"]),
                    row["merk_alat"].ToString(),
                    row["deskripsi"].ToString(),
                    Convert.ToDecimal(row["harga_perhari"]),
                    row["foto_alat"].ToString()
                );

                card.DetailClicked += Card_DetailClicked;
                flowAlat.Controls.Add(card);
            }
        }
        private void LoadKategori()
        {
            AlatController controller = new AlatController();
            DataTable dt = controller.GetKategoriUser();
            DataRow row = dt.NewRow();
            row["id_kategori"] = 0;
            row["nama_kategori"] = "Semua Kategori";

            dt.Rows.InsertAt(row, 0);

            cmbKategori.DataSource = dt;
            cmbKategori.DisplayMember = "nama_kategori";
            cmbKategori.ValueMember = "id_kategori";
        }

        private void Card_DetailClicked(object sender, EventArgs e)
        {
            UCAlat card = (UCAlat)sender;
            FormDetailAlat form = new FormDetailAlat(card.IdAlat);
            form.Show();
        }
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idAlat = Convert.ToInt32(btn.Tag);
            FormDetailAlat form = new FormDetailAlat(idAlat);
            form.ShowDialog();
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

        private void flowAlat_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
