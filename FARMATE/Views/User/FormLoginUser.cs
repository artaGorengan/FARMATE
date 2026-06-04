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
using FARMATE.Session;

namespace FARMATE.Views.User
{
    public partial class FormLoginUser : Form
    {
        public FormLoginUser()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterUser form = new FormRegisterUser();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string passwordHash = Helper.HashPassword(txtPassword.Text);
                   

                    string query = @"SELECT * FROM Users WHERE email=@email AND password=@password";
                       NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                   
                       cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                       cmd.Parameters.AddWithValue("@password", passwordHash);

                        
                    

                    NpgsqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        UserSession.UserID = Convert.ToInt32(rd["id_user"]);
                        UserSession.Username = rd["username"].ToString();
                        UserSession.Role = "USER";

                        MessageBox.Show("Login berhasil");

                        FormDashboardUser form = new FormDashboardUser();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Email atau Password salah");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
