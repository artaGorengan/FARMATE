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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaAlat));
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            btnLogout = new Button();
            panelNavbar = new Panel();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            flowPanen = new FlowLayoutPanel();
            flowTraktor = new FlowLayoutPanel();
            lblTraktor = new Label();
            flowDrone = new FlowLayoutPanel();
            lblTotalAlat = new Label();
            lblTotalDrone = new Label();
            lblTotalTraktor = new Label();
            lblTotalPanen = new Label();
            panelSidebar = new Panel();
            panelContent = new Panel();
            panelNavbar.SuspendLayout();
            flowTraktor.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // btnHapus
            // 
            btnHapus.Image = (Image)resources.GetObject("btnHapus.Image");
            btnHapus.Location = new Point(12, 374);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(373, 121);
            btnHapus.TabIndex = 2;
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(-17, 255);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(402, 125);
            btnEdit.TabIndex = 1;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.ForeColor = Color.Crimson;
            btnTambah.Image = (Image)resources.GetObject("btnTambah.Image");
            btnTambah.Location = new Point(12, 149);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(373, 117);
            btnTambah.TabIndex = 0;
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(1616, 7);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(252, 114);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = SystemColors.ControlDark;
            panelNavbar.BackgroundImage = (Image)resources.GetObject("panelNavbar.BackgroundImage");
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1898, 130);
            panelNavbar.TabIndex = 1;
            panelNavbar.Paint += panelNavbar_Paint;
            // 
            // btnDataUser
            // 
            btnDataUser.BackColor = Color.Transparent;
            btnDataUser.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDataUser.ForeColor = Color.DarkOliveGreen;
            btnDataUser.Location = new Point(1221, 47);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(133, 34);
            btnDataUser.TabIndex = 2;
            btnDataUser.Text = "DATA USER";
            btnDataUser.UseVisualStyleBackColor = false;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.DarkOliveGreen;
            btnRiwayat.Location = new Point(963, 47);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(161, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "RIWAYAT";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.Transparent;
            btnKelolaAlat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = Color.DarkOliveGreen;
            btnKelolaAlat.Location = new Point(655, 46);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(191, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.Text = "KELOLA ALAT";
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // flowPanen
            // 
            flowPanen.AutoScroll = true;
            flowPanen.BackColor = Color.Transparent;
            flowPanen.Location = new Point(74, 638);
            flowPanen.Name = "flowPanen";
            flowPanen.Size = new Size(1181, 235);
            flowPanen.TabIndex = 2;
            flowPanen.WrapContents = false;
            flowPanen.Paint += flowPanen_Paint;
            // 
            // flowTraktor
            // 
            flowTraktor.AutoScroll = true;
            flowTraktor.Controls.Add(lblTraktor);
            flowTraktor.Location = new Point(74, 346);
            flowTraktor.Name = "flowTraktor";
            flowTraktor.Size = new Size(1181, 235);
            flowTraktor.TabIndex = 1;
            flowTraktor.WrapContents = false;
            flowTraktor.Paint += flowTraktor_Paint;
            // 
            // lblTraktor
            // 
            lblTraktor.AutoSize = true;
            lblTraktor.Location = new Point(3, 0);
            lblTraktor.Name = "lblTraktor";
            lblTraktor.Size = new Size(0, 25);
            lblTraktor.TabIndex = 0;
            // 
            // flowDrone
            // 
            flowDrone.AutoScroll = true;
            flowDrone.Location = new Point(74, 56);
            flowDrone.Name = "flowDrone";
            flowDrone.Size = new Size(1181, 235);
            flowDrone.TabIndex = 0;
            flowDrone.WrapContents = false;
            flowDrone.Paint += flowDrone_Paint;
            // 
            // lblTotalAlat
            // 
            lblTotalAlat.AutoSize = true;
            lblTotalAlat.BackColor = Color.Transparent;
            lblTotalAlat.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAlat.Location = new Point(1779, 300);
            lblTotalAlat.Name = "lblTotalAlat";
            lblTotalAlat.Size = new Size(31, 32);
            lblTotalAlat.TabIndex = 1;
            lblTotalAlat.Text = "0";
            // 
            // lblTotalDrone
            // 
            lblTotalDrone.AutoSize = true;
            lblTotalDrone.BackColor = Color.Transparent;
            lblTotalDrone.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDrone.Location = new Point(1782, 487);
            lblTotalDrone.Name = "lblTotalDrone";
            lblTotalDrone.Size = new Size(26, 28);
            lblTotalDrone.TabIndex = 3;
            lblTotalDrone.Text = "0";
            // 
            // lblTotalTraktor
            // 
            lblTotalTraktor.AutoSize = true;
            lblTotalTraktor.BackColor = Color.Transparent;
            lblTotalTraktor.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTraktor.Location = new Point(1780, 695);
            lblTotalTraktor.Name = "lblTotalTraktor";
            lblTotalTraktor.Size = new Size(31, 32);
            lblTotalTraktor.TabIndex = 5;
            lblTotalTraktor.Text = "0";
            // 
            // lblTotalPanen
            // 
            lblTotalPanen.AutoSize = true;
            lblTotalPanen.BackColor = Color.Transparent;
            lblTotalPanen.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPanen.Location = new Point(1781, 871);
            lblTotalPanen.Name = "lblTotalPanen";
            lblTotalPanen.Size = new Size(31, 32);
            lblTotalPanen.TabIndex = 7;
            lblTotalPanen.Text = "0";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.Controls.Add(btnTambah);
            panelSidebar.Controls.Add(btnEdit);
            panelSidebar.Controls.Add(btnHapus);
            panelSidebar.Location = new Point(-13, 161);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(404, 894);
            panelSidebar.TabIndex = 8;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(flowDrone);
            panelContent.Controls.Add(flowTraktor);
            panelContent.Controls.Add(flowPanen);
            panelContent.Location = new Point(397, 138);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1261, 888);
            panelContent.TabIndex = 9;
            // 
            // FormKelolaAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(lblTotalPanen);
            Controls.Add(panelNavbar);
            Controls.Add(lblTotalAlat);
            Controls.Add(lblTotalTraktor);
            Controls.Add(lblTotalDrone);
            Name = "FormKelolaAlat";
            Text = "FormKelolaAlat";
            Load += FormKelolaAlat_Load;
            panelNavbar.ResumeLayout(false);
            flowTraktor.ResumeLayout(false);
            flowTraktor.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelNavbar;
        private FlowLayoutPanel flowPanen;
        private FlowLayoutPanel flowTraktor;
        private FlowLayoutPanel flowDrone;
        private Button btnLogout;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private Button btnRiwayat;
        private Button btnKelolaAlat;
        private Button btnDataUser;
        private Label lblTraktor;
        private Label lblTotalAlat;
        private Label lblTotalDrone;
        private Label lblTotalTraktor;
        private Label lblTotalPanen;
        private Panel panelSidebar;
        private Panel panelContent;
    }
}