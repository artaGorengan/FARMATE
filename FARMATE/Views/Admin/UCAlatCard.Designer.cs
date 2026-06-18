namespace FARMATE.Views.Admin
{
    partial class UCAlatCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAlatCard));
            pbFotoAlat = new PictureBox();
            lblMerk = new Label();
            lblHarga = new Label();
            lblStok = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).BeginInit();
            SuspendLayout();
            // 
            // pbFotoAlat
            // 
            pbFotoAlat.BackgroundImageLayout = ImageLayout.Zoom;
            pbFotoAlat.Location = new Point(0, 0);
            pbFotoAlat.Name = "pbFotoAlat";
            pbFotoAlat.Size = new Size(367, 122);
            pbFotoAlat.TabIndex = 0;
            pbFotoAlat.TabStop = false;
            pbFotoAlat.Click += pbFotoAlat_Click;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMerk.Location = new Point(14, 125);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(54, 21);
            lblMerk.TabIndex = 1;
            lblMerk.Text = "Merk";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.DarkGreen;
            lblHarga.Location = new Point(14, 175);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(65, 21);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStok.Location = new Point(14, 150);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(49, 21);
            lblStok.TabIndex = 3;
            lblStok.Text = "Stok";
            // 
            // UCAlatCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(lblStok);
            Controls.Add(lblHarga);
            Controls.Add(lblMerk);
            Controls.Add(pbFotoAlat);
            Name = "UCAlatCard";
            Size = new Size(367, 227);
            Load += UCAlatCard_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFotoAlat;
        private Label lblMerk;
        private Label lblHarga;
        private Label lblStok;
    }
}
