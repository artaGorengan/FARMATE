namespace FARMATE.Views.User
{
    partial class FormDaftarAlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarAlat));
            panelNavbar = new Panel();
            btnLogout = new Button();
            btnRiwayat = new Button();
            btnDaftarAlat = new Button();
            cmbKategori = new ComboBox();
            flowAlat = new FlowLayoutPanel();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackgroundImage = (Image)resources.GetObject("panelNavbar.BackgroundImage");
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnDaftarAlat);
            panelNavbar.Controls.Add(cmbKategori);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1898, 110);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1645, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(186, 65);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(1159, 38);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 3;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnDaftarAlat
            // 
            btnDaftarAlat.Location = new Point(932, 38);
            btnDaftarAlat.Name = "btnDaftarAlat";
            btnDaftarAlat.Size = new Size(133, 34);
            btnDaftarAlat.TabIndex = 2;
            btnDaftarAlat.Text = "Daftar Alat";
            btnDaftarAlat.UseVisualStyleBackColor = true;
            btnDaftarAlat.Click += btnDaftarAlat_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(394, 38);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(295, 33);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // flowAlat
            // 
            flowAlat.AutoScroll = true;
            flowAlat.BackgroundImage = (Image)resources.GetObject("flowAlat.BackgroundImage");
            flowAlat.Dock = DockStyle.Fill;
            flowAlat.Location = new Point(0, 110);
            flowAlat.Name = "flowAlat";
            flowAlat.Size = new Size(1898, 914);
            flowAlat.TabIndex = 1;
            flowAlat.Paint += flowAlat_Paint;
            // 
            // FormDaftarAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(flowAlat);
            Controls.Add(panelNavbar);
            Name = "FormDaftarAlat";
            Text = "FormDaftarAlat";
            Load += FormDaftarAlat_Load;
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Button btnDaftarAlat;
        private ComboBox cmbKategori;
        private Button btnLogout;
        private Button btnRiwayat;
        private FlowLayoutPanel flowAlat;
    }
}