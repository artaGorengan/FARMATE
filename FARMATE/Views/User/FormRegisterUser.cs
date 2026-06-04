using FARMATE.Utils;
using FARMATE.Views.User;
using Npgsql;

namespace FARMATE.Views.Auth
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password tidak sama");
                return;
            }

            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string passwordHash = Helper.HashPassword(txtPassword.Text);
                    

                    string query = @"INSERT INTO Users( nama_user,  username, password,email, no_telepon,  alamat)
                    VALUES  ( @nama, @username, @password,  @email,    @telepon,  @alamat )";
               
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", passwordHash);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telepon", txtNoHp.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registrasi berhasil");

                    FormLoginUser form = new FormLoginUser();

                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRegisterUser_Load(object sender, EventArgs e)
        {

        }
    }
}
