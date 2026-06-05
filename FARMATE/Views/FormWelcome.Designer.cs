namespace FARMATE.Views
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            btnLoginUser = new Button();
            btnLoginAdmin = new Button();
            SuspendLayout();
            // 
            // btnLoginUser
            // 
            btnLoginUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoginUser.Location = new Point(353, 308);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(171, 95);
            btnLoginUser.TabIndex = 0;
            btnLoginUser.Text = "User";
            btnLoginUser.UseVisualStyleBackColor = true;
            btnLoginUser.Click += btnLoginUser_Click;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(97, 308);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(171, 95);
            btnLoginAdmin.TabIndex = 1;
            btnLoginAdmin.Text = "Admin";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(643, 447);
            Controls.Add(btnLoginAdmin);
            Controls.Add(btnLoginUser);
            Name = "FormWelcome";
            Text = "FormWelcome";
            Load += FormWelcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoginUser;
        private Button btnLoginAdmin;
    }
}