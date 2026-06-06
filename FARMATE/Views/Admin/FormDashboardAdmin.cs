using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.Admin
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            FormKelolaAlat form = new FormKelolaAlat();
            form.Show();
            this.Hide();
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            FormDataUser form = new FormDataUser();
            form.Show();
            this.Hide();
        }

        private void btnRiwayatPengembalian_Click(object sender, EventArgs e)
        {
            FormRiwayatPengembalian form = new FormRiwayatPengembalian();

            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();

            form.Show();

            this.Close();
        }
    }
}
