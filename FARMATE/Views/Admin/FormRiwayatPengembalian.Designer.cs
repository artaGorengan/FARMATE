namespace FARMATE.Views.Admin
{
    partial class FormRiwayatPengembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayatPengembalian));
            panelNavbar = new Panel();
            btnLogout = new Button();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            lblTerlambat = new Label();
            lblSelesai = new Label();
            lblSedangDisewa = new Label();
            lblPenyewaan = new Label();
            panelContent = new Panel();
            flowRiwayat = new FlowLayoutPanel();
            panelNavbar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Transparent;
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1898, 127);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1632, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(221, 45);
            btnLogout.TabIndex = 10;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDataUser
            // 
            btnDataUser.Location = new Point(1220, 52);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 9;
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(967, 52);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 8;
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.White;
            btnKelolaAlat.Location = new Point(676, 52);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(137, 34);
            btnKelolaAlat.TabIndex = 7;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // lblTerlambat
            // 
            lblTerlambat.AutoSize = true;
            lblTerlambat.Location = new Point(1583, 365);
            lblTerlambat.Name = "lblTerlambat";
            lblTerlambat.Size = new Size(22, 25);
            lblTerlambat.TabIndex = 1;
            lblTerlambat.Text = "0";
            lblTerlambat.Click += lblTerlambat_Click;
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(1161, 365);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(22, 25);
            lblSelesai.TabIndex = 1;
            lblSelesai.Text = "0";
            // 
            // lblSedangDisewa
            // 
            lblSedangDisewa.AutoSize = true;
            lblSedangDisewa.Location = new Point(705, 365);
            lblSedangDisewa.Name = "lblSedangDisewa";
            lblSedangDisewa.Size = new Size(22, 25);
            lblSedangDisewa.TabIndex = 1;
            lblSedangDisewa.Text = "0";
            // 
            // lblPenyewaan
            // 
            lblPenyewaan.AutoSize = true;
            lblPenyewaan.Location = new Point(236, 365);
            lblPenyewaan.Name = "lblPenyewaan";
            lblPenyewaan.Size = new Size(22, 25);
            lblPenyewaan.TabIndex = 1;
            lblPenyewaan.Text = "0";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(lblTerlambat);
            panelContent.Controls.Add(lblSelesai);
            panelContent.Controls.Add(lblSedangDisewa);
            panelContent.Controls.Add(lblPenyewaan);
            panelContent.Controls.Add(flowRiwayat);
            panelContent.Controls.Add(panelNavbar);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1898, 1024);
            panelContent.TabIndex = 1;
            // 
            // flowRiwayat
            // 
            flowRiwayat.AutoScroll = true;
            flowRiwayat.BackColor = Color.Transparent;
            flowRiwayat.FlowDirection = FlowDirection.TopDown;
            flowRiwayat.Location = new Point(114, 522);
            flowRiwayat.Name = "flowRiwayat";
            flowRiwayat.Size = new Size(1683, 450);
            flowRiwayat.TabIndex = 4;
            flowRiwayat.WrapContents = false;
            flowRiwayat.Paint += flowRiwayat_Paint;
            // 
            // FormRiwayatPengembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(panelContent);
            Name = "FormRiwayatPengembalian";
            Text = "FormRiwayatPengembalian";
            Load += FormRiwayatPengembalian_Load;
            panelNavbar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Panel panelContent;
        private FlowLayoutPanel flowRiwayat;
        private Label lblPenyewaan;
        private Label lblTerlambat;
        private Label lblSelesai;
        private Label lblSedangDisewa;
        private Button btnDataUser;
        private Button btnRiwayat;
        private Button btnKelolaAlat;
        private Button btnLogout;
    }
}