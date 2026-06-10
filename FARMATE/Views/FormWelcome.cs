using FARMATE.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FARMATE.Views
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
          
        }
        private void RepositionButtons()
        {
            int formW = this.ClientSize.Width;
            int formH = this.ClientSize.Height;

            int btnW = (int)(formW * 0.2785);
            int btnH = (int)(formH * 0.2188);

            btnLoginAdmin.Size = new Size(btnW, btnH);
            btnLoginAdmin.Size = new Size(btnW, btnH);
            btnLoginAdmin.Location = new Point((int)(formW * 0.1521), (int)(formH * 0.6826));

            btnLoginUser.Size = new Size(btnW, btnH);
            btnLoginUser.Location = new Point((int)(formW * 0.5576), (int)(formH * 0.6826));

            btnLoginAdmin.BackColor = Color.Transparent;
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.FlatAppearance.BorderSize = 0;
            btnLoginAdmin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoginAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 0, 0);
            btnLoginAdmin.Text = "";

            btnLoginUser.BackColor = Color.Transparent;
            btnLoginUser.FlatStyle = FlatStyle.Flat;
            btnLoginUser.FlatAppearance.BorderSize = 0;
            btnLoginUser.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoginUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 0, 0);
            btnLoginUser.Text = "";
        }
        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            FormLoginUser form = new FormLoginUser();
            form.Show();
            this.Hide();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin form = new FormLoginAdmin();
            form.Show();
            this.Hide();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            RepositionButtons();

        }

        private void FormWelcome_Resize(object sender, EventArgs e)
        {
            RepositionButtons();
        }



    }
}
