using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FARMATE.Views.Admin
{
    public partial class UCAlatCard : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public int IdAlat { get; set; }
        public event EventHandler CardClicked;
        public UCAlatCard()
        {
            InitializeComponent();
            this.Click += UC_Click;
            lblMerk.Click += UC_Click;
            lblHarga.Click += UC_Click;
            lblStok.Click += UC_Click;
        }

        public void SetData(int idAlat, string merk, string harga, string stok, string foto)
        {
            IdAlat = idAlat;
            lblMerk.Text = merk;
            lblHarga.Text = "Rp " + harga;
            lblStok.Text = "Stok : " + stok;
            try
            {
                pbFotoAlat.Image =
                    Image.FromFile(foto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UC_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetSelected(bool selected)
        {
            if (selected)
                BackColor = Color.DarkOliveGreen;
            else
                BackColor = Color.White;
        }

        private void UCAlatCard_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Click += UC_Click;
            }
        }

        public event Action OnBatal;
        private void btnBatal_Click(object sender, EventArgs e)
        {
            OnBatal?.Invoke();
        }

        private void pbFotoAlat_Click(object sender, EventArgs e)
        {

        }
    }
}
