
using FARMATE.Views.User;
using FARMATE.Models;
using FARMATE.Repositories;

namespace FARMATE.Views.Auth
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
        }
        private void FormRegisterUser_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password tidak sama");
                return;
            }

            try
            {
                Login repo = new Login();

                Models.User user = new Models.User
                {
                    Nama = txtNama.Text,
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    NoHp = txtNoHp.Text,
                    Alamat = txtAlamat.Text
                };

                repo.Register(user, txtPassword.Text);

                MessageBox.Show("Registrasi berhasil");

                FormLoginUser form = new FormLoginUser();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void lblAlamat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            FormWelcome form = new FormWelcome();
            form.Show();
            this.Hide();
        }
    }
}
