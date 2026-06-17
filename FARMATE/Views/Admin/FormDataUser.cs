using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FARMATE.Controller;

namespace FARMATE.Views.Admin
{
    public partial class FormDataUser : Form
    {
        public FormDataUser()
        {
            InitializeComponent();
        }

        private void FormDataUser_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void LoadDataUser()
        {
            flowUser.Controls.Clear();

            DataUserController controller = new DataUserController();
            DataTable dt = controller.GetDataUser();
            foreach (DataRow rowData in dt.Rows)
            {
                UCDataUser row =
                    new UCDataUser();

                row.SetData(
                    rowData["nama_user"].ToString(),
                    rowData["username"].ToString(),
                    rowData["email"].ToString(),
                    rowData["no_telepon"].ToString(),
                    rowData["alamat"].ToString(),
                    rowData["total_sewa"].ToString()
                );

                flowUser.Controls.Add(row);
            }
        }
        
        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPengembalian form = new FormRiwayatPengembalian();
            form.Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Hide();
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

        private void flowUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
