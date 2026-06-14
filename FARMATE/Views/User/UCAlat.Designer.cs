namespace FARMATE.Views.User
{
    partial class UCAlat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAlat));
            pbFoto = new PictureBox();
            lblMerk = new Label();
            lblDeskripsi = new Label();
            lblHarga = new Label();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(0, 0);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(275, 199);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMerk.ForeColor = Color.DarkOliveGreen;
            lblMerk.Location = new Point(17, 213);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(56, 25);
            lblMerk.TabIndex = 1;
            lblMerk.Text = "Merk";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeskripsi.ForeColor = Color.DarkOliveGreen;
            lblDeskripsi.Location = new Point(17, 238);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(89, 25);
            lblDeskripsi.TabIndex = 2;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.DarkOliveGreen;
            lblHarga.Location = new Point(17, 307);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(64, 25);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.Transparent;
            btnDetail.Location = new Point(64, 355);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(149, 41);
            btnDetail.TabIndex = 4;
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // UCAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnDetail);
            Controls.Add(lblHarga);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblMerk);
            Controls.Add(pbFoto);
            Name = "UCAlat";
            Size = new Size(275, 415);
            Load += UCAlat_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFoto;
        private Label lblMerk;
        private Label lblDeskripsi;
        private Label lblHarga;
        private Button btnDetail;
    }
}
