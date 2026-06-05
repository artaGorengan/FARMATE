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
            this.Size = new Size(800, 500);

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

        }

       
    }
}
