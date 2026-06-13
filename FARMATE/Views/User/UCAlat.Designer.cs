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
            pbFoto.Size = new Size(280, 165);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Location = new Point(9, 184);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(52, 25);
            lblMerk.TabIndex = 1;
            lblMerk.Text = "Merk";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(17, 221);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(84, 25);
            lblDeskripsi.TabIndex = 2;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(17, 273);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(75, 368);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(112, 34);
            btnDetail.TabIndex = 4;
            btnDetail.Text = "Lihat Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // UCAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDetail);
            Controls.Add(lblHarga);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblMerk);
            Controls.Add(pbFoto);
            Name = "UCAlat";
            Size = new Size(280, 420);
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
