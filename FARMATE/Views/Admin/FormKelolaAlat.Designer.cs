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
            btnHapus.Location = new Point(10, 358);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(381, 121);
            btnHapus.TabIndex = 2;
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(15, 234);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(381, 117);
            btnEdit.TabIndex = 1;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(10, 118);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(381, 119);
            btnTambah.TabIndex = 0;
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(1630, 47);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(216, 48);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelNavbar
            // 
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
            btnDataUser.Location = new Point(1221, 47);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 2;
            btnDataUser.UseVisualStyleBackColor = false;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.Location = new Point(963, 47);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "\r\n";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.Transparent;
            btnKelolaAlat.Location = new Point(680, 38);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(147, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // flowPanen
            // 
            flowPanen.AutoScroll = true;
            flowPanen.BackColor = Color.Transparent;
            flowPanen.Location = new Point(74, 674);
            flowPanen.Name = "flowPanen";
            flowPanen.Size = new Size(1181, 200);
            flowPanen.TabIndex = 2;
            flowPanen.WrapContents = false;
            flowPanen.Paint += flowPanen_Paint;
            // 
            // flowTraktor
            // 
            flowTraktor.AutoScroll = true;
            flowTraktor.Controls.Add(lblTraktor);
            flowTraktor.Location = new Point(74, 367);
            flowTraktor.Name = "flowTraktor";
            flowTraktor.Size = new Size(1181, 200);
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
            flowDrone.Location = new Point(74, 83);
            flowDrone.Name = "flowDrone";
            flowDrone.Size = new Size(1181, 200);
            flowDrone.TabIndex = 0;
            flowDrone.WrapContents = false;
            flowDrone.Paint += flowDrone_Paint;
            // 
            // lblTotalAlat
            // 
            lblTotalAlat.AutoSize = true;
            lblTotalAlat.BackColor = Color.Transparent;
            lblTotalAlat.Location = new Point(1795, 301);
            lblTotalAlat.Name = "lblTotalAlat";
            lblTotalAlat.Size = new Size(22, 25);
            lblTotalAlat.TabIndex = 1;
            lblTotalAlat.Text = "0";
            // 
            // lblTotalDrone
            // 
            lblTotalDrone.AutoSize = true;
            lblTotalDrone.BackColor = Color.Transparent;
            lblTotalDrone.Location = new Point(1795, 487);
            lblTotalDrone.Name = "lblTotalDrone";
            lblTotalDrone.Size = new Size(22, 25);
            lblTotalDrone.TabIndex = 3;
            lblTotalDrone.Text = "0";
            // 
            // lblTotalTraktor
            // 
            lblTotalTraktor.AutoSize = true;
            lblTotalTraktor.BackColor = Color.Transparent;
            lblTotalTraktor.Location = new Point(1795, 695);
            lblTotalTraktor.Name = "lblTotalTraktor";
            lblTotalTraktor.Size = new Size(22, 25);
            lblTotalTraktor.TabIndex = 5;
            lblTotalTraktor.Text = "0";
            // 
            // lblTotalPanen
            // 
            lblTotalPanen.AutoSize = true;
            lblTotalPanen.BackColor = Color.Transparent;
            lblTotalPanen.Location = new Point(1795, 871);
            lblTotalPanen.Name = "lblTotalPanen";
            lblTotalPanen.Size = new Size(22, 25);
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