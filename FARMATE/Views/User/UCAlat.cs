using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace FARMATE.Views.User
{
    public partial class UCAlat : UserControl
    {
        public UCAlat()
        {
            InitializeComponent();
        }


        public int IdAlat;
        public event EventHandler DetailClicked;

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailClicked?.Invoke(this, EventArgs.Empty);

        }

        public void SetData(
    int idAlat,
    string merk,
    string deskripsi,
    decimal harga,
    string foto)
        {
            IdAlat = idAlat;

            lblMerk.Text = merk;

            lblDeskripsi.Text = deskripsi;

            lblHarga.Text =
                "Rp " +
                harga.ToString("N0") +
                " /hari";

            if (File.Exists(foto))
            {
                pbFoto.Image =
                    Image.FromFile(foto);
            }
        }

        private void UCAlat_Load(object sender, EventArgs e)
        {

        }
    }
}
