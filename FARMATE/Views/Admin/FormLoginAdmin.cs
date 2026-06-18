using FARMATE.Controller;
using FARMATE.Session;
using FARMATE.Utils;
using FARMATE.Views;
using FARMATE.Views.Admin;
using FARMATE.Views.User;
using Npgsql;
using System.Data;
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
                AdminController controller = new AdminController();


                DataRow admin = controller.Login(txtUsername.Text, txtPassword.Text);
                if (admin != null)
                {
                    UserSession.AdminID = Convert.ToInt32(admin["id_admin"]);
                    UserSession.Username = admin["username"].ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
