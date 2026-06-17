namespace FARMATE.Views.Admin
{
    partial class FormDataUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataUser));
            panelNavbar = new Panel();
            btnLogout = new Button();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            panelContainer = new Panel();
            flowUser = new FlowLayoutPanel();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Transparent;
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1898, 145);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(1626, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(260, 115);
            btnLogout.TabIndex = 3;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDataUser
            // 
            btnDataUser.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDataUser.ForeColor = Color.DarkOliveGreen;
            btnDataUser.Location = new Point(1191, 56);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(150, 34);
            btnDataUser.TabIndex = 2;
            btnDataUser.Text = "DATA USER";
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.DarkOliveGreen;
            btnRiwayat.Location = new Point(945, 56);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "RIWAYAT";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = Color.DarkOliveGreen;
            btnKelolaAlat.Location = new Point(659, 57);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(167, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.Text = "KELOLA ALAT";
            btnKelolaAlat.UseVisualStyleBackColor = true;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Location = new Point(55, 304);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1802, 708);
            panelContainer.TabIndex = 2;
            // 
            // flowUser
            // 
            flowUser.AutoScroll = true;
            flowUser.BackColor = Color.Transparent;
            flowUser.FlowDirection = FlowDirection.TopDown;
            flowUser.Location = new Point(142, 422);
            flowUser.Name = "flowUser";
            flowUser.Size = new Size(1676, 566);
            flowUser.TabIndex = 1;
            flowUser.WrapContents = false;
            flowUser.Paint += flowUser_Paint;
            // 
            // FormDataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(flowUser);
            Controls.Add(panelContainer);
            Controls.Add(panelNavbar);
            Name = "FormDataUser";
            Text = "FormDataUser";
            Load += FormDataUser_Load;
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Panel panelContainer;
        private Button btnKelolaAlat;
        private Button btnDataUser;
        private Button btnRiwayat;
        private Button btnLogout;
        private FlowLayoutPanel flowUser;
    }
}