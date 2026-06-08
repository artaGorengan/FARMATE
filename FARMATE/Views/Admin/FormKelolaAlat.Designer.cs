namespace FARMATE.Views.Admin
{
    partial class FormKelolaAlat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnLogout = new Button();
            panelMenu = new Panel();
            panelContent = new Panel();
            panelHeader = new Panel();
            panelTambahAlat = new Panel();
            lblStok = new Label();
            lblDeskripsi = new Label();
            blbHarga = new Label();
            lblMerk = new Label();
            lblBahanBakar = new Label();
            lblKategori = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            cmbBahanBakar = new ComboBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            txtDeskripsi = new TextBox();
            txtMerk = new TextBox();
            cmbKategori = new ComboBox();
            panelDaftarAlat = new Panel();
            flowPanen = new FlowLayoutPanel();
            panelEditAlat = new Panel();
            flowTraktor = new FlowLayoutPanel();
            flowDrone = new FlowLayoutPanel();
            lblPanen = new Label();
            lblTraktor = new Label();
            lblDrone = new Label();
            openFileDialog1 = new OpenFileDialog();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            panelTambahAlat.SuspendLayout();
            panelDaftarAlat.SuspendLayout();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(23, 83);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(23, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(23, 172);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(23, 342);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnTambah);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnEdit);
            panelMenu.Controls.Add(btnHapus);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(160, 722);
            panelMenu.TabIndex = 5;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelTambahAlat);
            panelContent.Controls.Add(panelHeader);
            panelContent.Controls.Add(panelDaftarAlat);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(160, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1072, 722);
            panelContent.TabIndex = 7;
            panelContent.Paint += panelContent_Paint;
            // 
            // panelHeader
            // 
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1072, 65);
            panelHeader.TabIndex = 0;
            // 
            // panelTambahAlat
            // 
            panelTambahAlat.Controls.Add(lblStok);
            panelTambahAlat.Controls.Add(lblDeskripsi);
            panelTambahAlat.Controls.Add(blbHarga);
            panelTambahAlat.Controls.Add(lblMerk);
            panelTambahAlat.Controls.Add(lblBahanBakar);
            panelTambahAlat.Controls.Add(lblKategori);
            panelTambahAlat.Controls.Add(btnBatal);
            panelTambahAlat.Controls.Add(btnSimpan);
            panelTambahAlat.Controls.Add(cmbBahanBakar);
            panelTambahAlat.Controls.Add(txtStok);
            panelTambahAlat.Controls.Add(txtHarga);
            panelTambahAlat.Controls.Add(txtDeskripsi);
            panelTambahAlat.Controls.Add(txtMerk);
            panelTambahAlat.Controls.Add(cmbKategori);
            panelTambahAlat.Location = new Point(0, 58);
            panelTambahAlat.Name = "panelTambahAlat";
            panelTambahAlat.Size = new Size(467, 443);
            panelTambahAlat.TabIndex = 2;
            panelTambahAlat.Visible = false;
            panelTambahAlat.Paint += panelTambahAlat_Paint;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(243, 166);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(47, 25);
            lblStok.TabIndex = 13;
            lblStok.Text = "Stok";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(37, 165);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(84, 25);
            lblDeskripsi.TabIndex = 12;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // blbHarga
            // 
            blbHarga.AutoSize = true;
            blbHarga.Location = new Point(259, 97);
            blbHarga.Name = "blbHarga";
            blbHarga.Size = new Size(60, 25);
            blbHarga.TabIndex = 11;
            blbHarga.Text = "Harga";
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Location = new Point(36, 95);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(52, 25);
            lblMerk.TabIndex = 10;
            lblMerk.Text = "Merk";
            // 
            // lblBahanBakar
            // 
            lblBahanBakar.AutoSize = true;
            lblBahanBakar.Location = new Point(263, 18);
            lblBahanBakar.Name = "lblBahanBakar";
            lblBahanBakar.Size = new Size(108, 25);
            lblBahanBakar.TabIndex = 9;
            lblBahanBakar.Text = "Bahan Bakar";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(29, 18);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 8;
            lblKategori.Text = "Kategori";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(332, 255);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(88, 34);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(213, 255);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(92, 34);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbBahanBakar
            // 
            cmbBahanBakar.FormattingEnabled = true;
            cmbBahanBakar.Location = new Point(263, 57);
            cmbBahanBakar.Name = "cmbBahanBakar";
            cmbBahanBakar.Size = new Size(182, 33);
            cmbBahanBakar.TabIndex = 5;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(242, 193);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(165, 31);
            txtStok.TabIndex = 4;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(257, 124);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(150, 31);
            txtHarga.TabIndex = 3;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(29, 193);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(182, 31);
            txtDeskripsi.TabIndex = 2;
            // 
            // txtMerk
            // 
            txtMerk.Location = new Point(38, 124);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(150, 31);
            txtMerk.TabIndex = 1;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(29, 57);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(182, 33);
            cmbKategori.TabIndex = 0;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // panelDaftarAlat
            // 
            panelDaftarAlat.Controls.Add(flowPanen);
            panelDaftarAlat.Controls.Add(panelEditAlat);
            panelDaftarAlat.Controls.Add(flowTraktor);
            panelDaftarAlat.Controls.Add(flowDrone);
            panelDaftarAlat.Controls.Add(lblPanen);
            panelDaftarAlat.Controls.Add(lblTraktor);
            panelDaftarAlat.Controls.Add(lblDrone);
            panelDaftarAlat.Dock = DockStyle.Fill;
            panelDaftarAlat.Location = new Point(0, 0);
            panelDaftarAlat.Name = "panelDaftarAlat";
            panelDaftarAlat.Size = new Size(1072, 722);
            panelDaftarAlat.TabIndex = 1;
            panelDaftarAlat.Paint += panelDaftarAlat_Paint;
            // 
            // flowPanen
            // 
            flowPanen.AutoScroll = true;
            flowPanen.Location = new Point(48, 414);
            flowPanen.Name = "flowPanen";
            flowPanen.Size = new Size(987, 140);
            flowPanen.TabIndex = 6;
            flowPanen.WrapContents = false;
            flowPanen.Paint += flowPanen_Paint;
            // 
            // panelEditAlat
            // 
            panelEditAlat.Location = new Point(314, 478);
            panelEditAlat.Name = "panelEditAlat";
            panelEditAlat.Size = new Size(385, 167);
            panelEditAlat.TabIndex = 3;
            panelEditAlat.Paint += panelEditAlat_Paint;
            // 
            // flowTraktor
            // 
            flowTraktor.AutoScroll = true;
            flowTraktor.Location = new Point(47, 252);
            flowTraktor.Name = "flowTraktor";
            flowTraktor.Size = new Size(988, 130);
            flowTraktor.TabIndex = 5;
            flowTraktor.WrapContents = false;
            flowTraktor.Paint += flowTraktor_Paint;
            // 
            // flowDrone
            // 
            flowDrone.AutoScroll = true;
            flowDrone.Location = new Point(45, 58);
            flowDrone.Name = "flowDrone";
            flowDrone.Size = new Size(990, 150);
            flowDrone.TabIndex = 4;
            flowDrone.WrapContents = false;
            flowDrone.Paint += flowDrone_Paint;
            // 
            // lblPanen
            // 
            lblPanen.AutoSize = true;
            lblPanen.Location = new Point(36, 385);
            lblPanen.Name = "lblPanen";
            lblPanen.Size = new Size(114, 25);
            lblPanen.TabIndex = 3;
            lblPanen.Text = "ALAT PANEN";
            // 
            // lblTraktor
            // 
            lblTraktor.AutoSize = true;
            lblTraktor.Location = new Point(39, 211);
            lblTraktor.Name = "lblTraktor";
            lblTraktor.Size = new Size(87, 25);
            lblTraktor.TabIndex = 2;
            lblTraktor.Text = "TRAKTOR";
            // 
            // lblDrone
            // 
            lblDrone.AutoSize = true;
            lblDrone.Location = new Point(39, 23);
            lblDrone.Name = "lblDrone";
            lblDrone.Size = new Size(72, 25);
            lblDrone.TabIndex = 1;
            lblDrone.Text = "DRONE";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "[Pilih Gambar]";
            openFileDialog1.Title = "[Pilih Gambar]";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // FormKelolaAlat
            // 
            ClientSize = new Size(1232, 722);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Name = "FormKelolaAlat";
            Load += FormKelolaAlat_Load;
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelTambahAlat.ResumeLayout(false);
            panelTambahAlat.PerformLayout();
            panelDaftarAlat.ResumeLayout(false);
            panelDaftarAlat.PerformLayout();
            ResumeLayout(false);
            // 
            // FormKelolaAlat

        }

        #endregion
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnLogout;
        private Panel panelMenu;
        private Panel panelContent;
        private Panel panelHeader;
        private Panel panelEditAlat;
        private Panel panelTambahAlat;
        private Panel panelDaftarAlat;
        private TextBox txtHarga;
        private TextBox txtDeskripsi;
        private TextBox txtMerk;
        private ComboBox cmbKategori;
        private ComboBox cmbBahanBakar;
        private TextBox txtStok;
        private Button btnSimpan;
        private Button btnBatal;
        private Label lblBahanBakar;
        private Label lblKategori;
        private Label lblStok;
        private Label lblDeskripsi;
        private Label blbHarga;
        private Label lblMerk;
        private Label lblDrone;
        private FlowLayoutPanel flowDrone;
        private Label lblPanen;
        private Label lblTraktor;
        private FlowLayoutPanel flowPanen;
        private FlowLayoutPanel flowTraktor;
        private OpenFileDialog openFileDialog1;
    }
}