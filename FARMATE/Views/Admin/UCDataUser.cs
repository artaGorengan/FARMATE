using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.Admin
{
    public partial class UCDataUser : UserControl
    {
        public UCDataUser()
        {
            InitializeComponent();
        }

        private void UCDataUser_Load(object sender, EventArgs e)
        {

        }

        public void SetData(
    string nama,
    string username,
    string email,
    string noHp,
    string alamat,
    string totalSewa)
        {
            lblNama.Text = nama;
            lblUsername.Text = username;
            lblEmail.Text = email;
            lblNoHp.Text = noHp;
            lblAlamat.Text = alamat;
            lblTotal.Text = totalSewa;
        }
    }
}
