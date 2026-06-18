using FARMATE.Controller;
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
            AlatController controller = new AlatController();
            controller.UpdateAlat(
                selectedIdAlat,
                Convert.ToInt32(cmbKategori.SelectedValue),
                txtMerk.Text,
                RTBDeskripsi.Text,
                decimal.Parse(txtHarga.Text),
                int.Parse(txtStok.Text),
                cmbBBM.Text
            );

            MessageBox.Show("Data berhasil diupdate");
            isEditMode = false;
            btnSimpan.Text = "Simpan";
            ClearForm();
        }
        private void TambahAlat()
        {
            try
            {
                AlatController controller = new AlatController();
                controller.TambahAlat(
                    UserSession.AdminID,
                    Convert.ToInt32(cmbKategori.SelectedValue),
                    txtMerk.Text,
                    RTBDeskripsi.Text,
                    decimal.Parse(txtHarga.Text),
                    int.Parse(txtStok.Text),
                    cmbBBM.Text,
                    fotoPath
                );

                MessageBox.Show("Alat berhasil ditambahkan");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDataEdit(int idAlat)
        {
            selectedIdAlat = idAlat;

            AlatController controller = new AlatController();
            DataRow row = controller.GetAlatById(idAlat);


            if (row != null)
            {
                txtMerk.Text = row["merk_alat"].ToString();
                RTBDeskripsi.Text = row["deskripsi"].ToString();
                txtHarga.Text = row["harga_perhari"].ToString();
                txtStok.Text = row["stok_total"].ToString();
                cmbBBM.Text = row["bahan_bakar"].ToString();
                cmbKategori.SelectedValue = row["id_kategori"];
                fotoPath = row["foto_alat"].ToString();
                if (System.IO.File.Exists(fotoPath))
                {
                    pbFotoAlat.Image = Image.FromFile(fotoPath);
                }

                isEditMode = true;
                btnSimpan.Text = "";
            }
        }
        private void LoadKategori()
        {
            AlatController controller = new AlatController();
            DataTable dt = controller.GetKategori();


            cmbKategori.DataSource = dt;
            cmbKategori.DisplayMember = "nama_kategori";
            cmbKategori.ValueMember = "id_kategori";
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
