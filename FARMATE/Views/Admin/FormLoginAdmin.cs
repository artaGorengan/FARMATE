using FARMATE.Utils;
using FARMATE.Views.Admin;
using FARMATE.Views.User;
using Npgsql;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using FARMATE.Session;

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

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string passwordHash = Helper.HashPassword(txtPassword.Text);

                    string query = @"SELECT * FROM Admin WHERE username=@username AND password=@password";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", passwordHash);

                    NpgsqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        UserSession.AdminID = Convert.ToInt32(rd["id_admin"]);

                        UserSession.Username = rd["username"].ToString();

                        UserSession.Role = "ADMIN";

                        FormDashboardAdmin form = new FormDashboardAdmin();
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
