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
            panelSidebar = new Panel();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            panelTambahAlat = new Panel();
            btnPilihGambar = new Button();
            pbFotoAlat = new PictureBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            cmbBBM = new ComboBox();
            cmbKategori = new ComboBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            txtDeskripsi = new TextBox();
            txtMerk = new TextBox();
            lblBBM = new Label();
            lblStok = new Label();
            lblHarga = new Label();
            lblDeskripsi = new Label();
            lblMerk = new Label();
            lblKategori = new Label();
            btnLogout = new Button();
            panelNavbar = new Panel();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            panelContent = new Panel();
            panelStatistika = new Panel();
            panelPanen = new Panel();
            lblTotalPanen = new Label();
            lblJudulPanen = new Label();
            panelTraktor = new Panel();
            lblTotalTraktor = new Label();
            lblJudulTraktor = new Label();
            panelDrone = new Panel();
            lblTotalDrone = new Label();
            lblJudulDrone = new Label();
            panelTotalAlat = new Panel();
            lblTotalAlat = new Label();
            lblJudulTotal = new Label();
            flowPanen = new FlowLayoutPanel();
            lblPanen = new Label();
            flowTraktor = new FlowLayoutPanel();
            lblTraktor = new Label();
            flowDrone = new FlowLayoutPanel();
            lbldrone = new Label();
            panelSidebar.SuspendLayout();
            panelTambahAlat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).BeginInit();
            panelNavbar.SuspendLayout();
            panelContent.SuspendLayout();
            panelStatistika.SuspendLayout();
            panelPanen.SuspendLayout();
            panelTraktor.SuspendLayout();
            panelDrone.SuspendLayout();
            panelTotalAlat.SuspendLayout();
            flowPanen.SuspendLayout();
            flowTraktor.SuspendLayout();
            flowDrone.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnHapus);
            panelSidebar.Controls.Add(btnEdit);
            panelSidebar.Controls.Add(btnTambah);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(233, 741);
            panelSidebar.TabIndex = 0;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(62, 242);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(62, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(62, 136);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // panelTambahAlat
            // 
            panelTambahAlat.BackColor = SystemColors.Window;
            panelTambahAlat.BorderStyle = BorderStyle.FixedSingle;
            panelTambahAlat.Controls.Add(btnPilihGambar);
            panelTambahAlat.Controls.Add(pbFotoAlat);
            panelTambahAlat.Controls.Add(btnBatal);
            panelTambahAlat.Controls.Add(btnSimpan);
            panelTambahAlat.Controls.Add(cmbBBM);
            panelTambahAlat.Controls.Add(cmbKategori);
            panelTambahAlat.Controls.Add(txtStok);
            panelTambahAlat.Controls.Add(txtHarga);
            panelTambahAlat.Controls.Add(txtDeskripsi);
            panelTambahAlat.Controls.Add(txtMerk);
            panelTambahAlat.Controls.Add(lblBBM);
            panelTambahAlat.Controls.Add(lblStok);
            panelTambahAlat.Controls.Add(lblHarga);
            panelTambahAlat.Controls.Add(lblDeskripsi);
            panelTambahAlat.Controls.Add(lblMerk);
            panelTambahAlat.Controls.Add(lblKategori);
            panelTambahAlat.Location = new Point(0, 0);
            panelTambahAlat.Name = "panelTambahAlat";
            panelTambahAlat.Size = new Size(594, 333);
            panelTambahAlat.TabIndex = 3;
            panelTambahAlat.Visible = false;
            panelTambahAlat.Paint += panelTambahAlat_Paint;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.Location = new Point(68, 173);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(138, 34);
            btnPilihGambar.TabIndex = 15;
            btnPilihGambar.Text = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = true;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // pbFotoAlat
            // 
            pbFotoAlat.Location = new Point(40, 13);
            pbFotoAlat.Name = "pbFotoAlat";
            pbFotoAlat.Size = new Size(180, 140);
            pbFotoAlat.TabIndex = 14;
            pbFotoAlat.TabStop = false;
            pbFotoAlat.Click += pbFotoAlat_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(145, 259);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(72, 34);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(40, 259);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(88, 34);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbBBM
            // 
            cmbBBM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBBM.FormattingEnabled = true;
            cmbBBM.Location = new Point(444, 248);
            cmbBBM.Name = "cmbBBM";
            cmbBBM.Size = new Size(108, 33);
            cmbBBM.TabIndex = 11;
            cmbBBM.SelectedIndexChanged += cmbBBM_SelectedIndexChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(287, 41);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(92, 33);
            cmbKategori.TabIndex = 10;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(280, 248);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(99, 31);
            txtStok.TabIndex = 9;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(448, 148);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(104, 31);
            txtHarga.TabIndex = 8;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(287, 148);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(92, 31);
            txtDeskripsi.TabIndex = 7;
            // 
            // txtMerk
            // 
            txtMerk.Location = new Point(448, 41);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(104, 31);
            txtMerk.TabIndex = 6;
            // 
            // lblBBM
            // 
            lblBBM.AutoSize = true;
            lblBBM.Location = new Point(444, 220);
            lblBBM.Name = "lblBBM";
            lblBBM.Size = new Size(108, 25);
            lblBBM.TabIndex = 5;
            lblBBM.Text = "Bahan Bakar";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(295, 220);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(47, 25);
            lblStok.TabIndex = 4;
            lblStok.Text = "Stok";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(472, 120);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(295, 120);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(84, 25);
            lblDeskripsi.TabIndex = 2;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Location = new Point(472, 13);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(52, 25);
            lblMerk.TabIndex = 1;
            lblMerk.Text = "Merk";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(295, 13);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Kategori";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1175, 47);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(233, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1361, 130);
            panelNavbar.TabIndex = 1;
            panelNavbar.Paint += panelNavbar_Paint;
            // 
            // btnDataUser
            // 
            btnDataUser.Location = new Point(641, 47);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 2;
            btnDataUser.Text = "Data User";
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(443, 47);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.Location = new Point(262, 47);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(112, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.UseVisualStyleBackColor = true;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelTambahAlat);
            panelContent.Controls.Add(panelStatistika);
            panelContent.Controls.Add(flowPanen);
            panelContent.Controls.Add(flowTraktor);
            panelContent.Controls.Add(flowDrone);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(233, 130);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1361, 611);
            panelContent.TabIndex = 2;
            // 
            // panelStatistika
            // 
            panelStatistika.Controls.Add(panelPanen);
            panelStatistika.Controls.Add(panelTraktor);
            panelStatistika.Controls.Add(panelDrone);
            panelStatistika.Controls.Add(panelTotalAlat);
            panelStatistika.Dock = DockStyle.Right;
            panelStatistika.Location = new Point(1131, 0);
            panelStatistika.Name = "panelStatistika";
            panelStatistika.Size = new Size(230, 611);
            panelStatistika.TabIndex = 3;
            // 
            // panelPanen
            // 
            panelPanen.Controls.Add(lblTotalPanen);
            panelPanen.Controls.Add(lblJudulPanen);
            panelPanen.Location = new Point(17, 390);
            panelPanen.Name = "panelPanen";
            panelPanen.Size = new Size(201, 105);
            panelPanen.TabIndex = 1;
            // 
            // lblTotalPanen
            // 
            lblTotalPanen.AutoSize = true;
            lblTotalPanen.Location = new Point(90, 63);
            lblTotalPanen.Name = "lblTotalPanen";
            lblTotalPanen.Size = new Size(22, 25);
            lblTotalPanen.TabIndex = 7;
            lblTotalPanen.Text = "0";
            // 
            // lblJudulPanen
            // 
            lblJudulPanen.AutoSize = true;
            lblJudulPanen.Location = new Point(54, 16);
            lblJudulPanen.Name = "lblJudulPanen";
            lblJudulPanen.Size = new Size(84, 25);
            lblJudulPanen.TabIndex = 6;
            lblJudulPanen.Text = "Combine";
            // 
            // panelTraktor
            // 
            panelTraktor.Controls.Add(lblTotalTraktor);
            panelTraktor.Controls.Add(lblJudulTraktor);
            panelTraktor.Location = new Point(17, 258);
            panelTraktor.Name = "panelTraktor";
            panelTraktor.Size = new Size(201, 105);
            panelTraktor.TabIndex = 1;
            // 
            // lblTotalTraktor
            // 
            lblTotalTraktor.AutoSize = true;
            lblTotalTraktor.Location = new Point(90, 54);
            lblTotalTraktor.Name = "lblTotalTraktor";
            lblTotalTraktor.Size = new Size(22, 25);
            lblTotalTraktor.TabIndex = 5;
            lblTotalTraktor.Text = "0";
            // 
            // lblJudulTraktor
            // 
            lblJudulTraktor.AutoSize = true;
            lblJudulTraktor.Location = new Point(66, 7);
            lblJudulTraktor.Name = "lblJudulTraktor";
            lblJudulTraktor.Size = new Size(66, 25);
            lblJudulTraktor.TabIndex = 4;
            lblJudulTraktor.Text = "Traktor";
            // 
            // panelDrone
            // 
            panelDrone.Controls.Add(lblTotalDrone);
            panelDrone.Controls.Add(lblJudulDrone);
            panelDrone.Location = new Point(17, 131);
            panelDrone.Name = "panelDrone";
            panelDrone.Size = new Size(201, 105);
            panelDrone.TabIndex = 1;
            // 
            // lblTotalDrone
            // 
            lblTotalDrone.AutoSize = true;
            lblTotalDrone.Location = new Point(90, 47);
            lblTotalDrone.Name = "lblTotalDrone";
            lblTotalDrone.Size = new Size(22, 25);
            lblTotalDrone.TabIndex = 3;
            lblTotalDrone.Text = "0";
            // 
            // lblJudulDrone
            // 
            lblJudulDrone.AutoSize = true;
            lblJudulDrone.Location = new Point(71, 9);
            lblJudulDrone.Name = "lblJudulDrone";
            lblJudulDrone.Size = new Size(61, 25);
            lblJudulDrone.TabIndex = 2;
            lblJudulDrone.Text = "Drone";
            // 
            // panelTotalAlat
            // 
            panelTotalAlat.Controls.Add(lblTotalAlat);
            panelTotalAlat.Controls.Add(lblJudulTotal);
            panelTotalAlat.Location = new Point(17, 6);
            panelTotalAlat.Name = "panelTotalAlat";
            panelTotalAlat.Size = new Size(201, 105);
            panelTotalAlat.TabIndex = 0;
            // 
            // lblTotalAlat
            // 
            lblTotalAlat.AutoSize = true;
            lblTotalAlat.Location = new Point(80, 59);
            lblTotalAlat.Name = "lblTotalAlat";
            lblTotalAlat.Size = new Size(22, 25);
            lblTotalAlat.TabIndex = 1;
            lblTotalAlat.Text = "0";
            // 
            // lblJudulTotal
            // 
            lblJudulTotal.AutoSize = true;
            lblJudulTotal.Location = new Point(54, 23);
            lblJudulTotal.Name = "lblJudulTotal";
            lblJudulTotal.Size = new Size(85, 25);
            lblJudulTotal.TabIndex = 0;
            lblJudulTotal.Text = "Total Alat";
            // 
            // flowPanen
            // 
            flowPanen.AutoScroll = true;
            flowPanen.Controls.Add(lblPanen);
            flowPanen.Location = new Point(18, 369);
            flowPanen.Name = "flowPanen";
            flowPanen.Size = new Size(1107, 150);
            flowPanen.TabIndex = 2;
            flowPanen.WrapContents = false;
            flowPanen.Paint += flowPanen_Paint;
            // 
            // lblPanen
            // 
            lblPanen.AutoSize = true;
            lblPanen.Location = new Point(3, 0);
            lblPanen.Name = "lblPanen";
            lblPanen.Size = new Size(90, 25);
            lblPanen.TabIndex = 0;
            lblPanen.Text = "COMBINE";
            // 
            // flowTraktor
            // 
            flowTraktor.AutoScroll = true;
            flowTraktor.Controls.Add(lblTraktor);
            flowTraktor.Location = new Point(18, 177);
            flowTraktor.Name = "flowTraktor";
            flowTraktor.Size = new Size(1107, 169);
            flowTraktor.TabIndex = 1;
            flowTraktor.WrapContents = false;
            flowTraktor.Paint += flowTraktor_Paint;
            // 
            // lblTraktor
            // 
            lblTraktor.AutoSize = true;
            lblTraktor.Location = new Point(3, 0);
            lblTraktor.Name = "lblTraktor";
            lblTraktor.Size = new Size(87, 25);
            lblTraktor.TabIndex = 0;
            lblTraktor.Text = "TRAKTOR";
            // 
            // flowDrone
            // 
            flowDrone.AutoScroll = true;
            flowDrone.Controls.Add(lbldrone);
            flowDrone.Location = new Point(16, 6);
            flowDrone.Name = "flowDrone";
            flowDrone.Size = new Size(1109, 153);
            flowDrone.TabIndex = 0;
            flowDrone.WrapContents = false;
            flowDrone.Paint += flowDrone_Paint;
            // 
            // lbldrone
            // 
            lbldrone.AutoSize = true;
            lbldrone.Location = new Point(3, 0);
            lbldrone.Name = "lbldrone";
            lbldrone.Size = new Size(169, 25);
            lbldrone.TabIndex = 0;
            lbldrone.Text = "DRONE PERTANIAN";
            // 
            // FormKelolaAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 741);
            Controls.Add(panelContent);
            Controls.Add(panelNavbar);
            Controls.Add(panelSidebar);
            Name = "FormKelolaAlat";
            Text = "FormKelolaAlat";
            Load += FormKelolaAlat_Load;
            panelSidebar.ResumeLayout(false);
            panelTambahAlat.ResumeLayout(false);
            panelTambahAlat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).EndInit();
            panelNavbar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelStatistika.ResumeLayout(false);
            panelPanen.ResumeLayout(false);
            panelPanen.PerformLayout();
            panelTraktor.ResumeLayout(false);
            panelTraktor.PerformLayout();
            panelDrone.ResumeLayout(false);
            panelDrone.PerformLayout();
            panelTotalAlat.ResumeLayout(false);
            panelTotalAlat.PerformLayout();
            flowPanen.ResumeLayout(false);
            flowPanen.PerformLayout();
            flowTraktor.ResumeLayout(false);
            flowTraktor.PerformLayout();
            flowDrone.ResumeLayout(false);
            flowDrone.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelNavbar;
        private Panel panelContent;
        private FlowLayoutPanel flowPanen;
        private FlowLayoutPanel flowTraktor;
        private FlowLayoutPanel flowDrone;
        private Button btnLogout;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private Panel panelTambahAlat;
        private Label lblHarga;
        private Label lblDeskripsi;
        private Label lblMerk;
        private Label lblKategori;
        private Button btnSimpan;
        private ComboBox cmbBBM;
        private ComboBox cmbKategori;
        private TextBox txtStok;
        private TextBox txtHarga;
        private TextBox txtDeskripsi;
        private TextBox txtMerk;
        private Label lblBBM;
        private Label lblStok;
        private Button btnBatal;
        private Button btnPilihGambar;
        private PictureBox pbFotoAlat;
        private Button btnRiwayat;
        private Button btnKelolaAlat;
        private Button btnDataUser;
        private Label lblPanen;
        private Label lblTraktor;
        private Label lbldrone;
        private Panel panelStatistika;
        private Panel panelPanen;
        private Label lblTotalPanen;
        private Label lblJudulPanen;
        private Panel panelTraktor;
        private Label lblTotalTraktor;
        private Label lblJudulTraktor;
        private Panel panelDrone;
        private Label lblTotalDrone;
        private Label lblJudulDrone;
        private Panel panelTotalAlat;
        private Label lblTotalAlat;
        private Label lblJudulTotal;
    }
}