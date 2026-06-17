using FARMATE.Session;
using FARMATE.Utils;
using FARMATE.Views;
using FARMATE.Views.Admin;
using FARMATE.Views.User;
using Npgsql;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace FARMATE
{
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM Atmin WHERE username=@username AND password=@password";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    NpgsqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        UserSession.AdminID = Convert.ToInt32(rd["id_admin"]);

                        UserSession.Username = rd["username"].ToString();

                        UserSession.Role = "ADMIN";

                        FormKelolaAlat form = new FormKelolaAlat();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RepositionButtons()
        {
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 0, 0);
            btnLogin.Text = "";

            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeluar.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 0, 0);
            btnKeluar.Text = "";

        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Close();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

       
    }
}
