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
            btnLogout = new Button();
            panelNavbar = new Panel();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            panelContent = new Panel();
            panelContainer = new Panel();
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
            panelContent.Controls.Add(panelContainer);
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
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Window;
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1131, 611);
            panelContainer.TabIndex = 3;
            panelContainer.Visible = false;
            panelContainer.Paint += panelContainer_Paint;
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
        private Panel panelContainer;
    }
}