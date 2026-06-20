using FARMATE.Utils;
using FARMATE.Views.Auth;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FARMATE.Repositories;
using FARMATE.Models;

namespace FARMATE.Views.User
{
    public partial class FormLoginUser : Form
    {
        public FormLoginUser()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login repo = new Login();

                Models.User user = repo.GetByEmailAndPassword(txtEmail.Text, txtPassword.Text);
                if (user != null)
                {
                    UserSession.UserID = user.IdUser;
                    UserSession.Username = user.Username;
                    UserSession.Role = "USER";
                    FormDaftarAlat form = new FormDaftarAlat();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email atau Password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterUser form = new FormRegisterUser();
            form.Show();
            this.Hide();
        }
        private void FormLoginUser_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
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
