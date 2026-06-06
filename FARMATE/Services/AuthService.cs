using FARMATE.Session;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FARMATE.Models;
using FARMATE.Repositories;

namespace FARMATE.Services
{
    internal class AuthService
    {
        private readonly Login _userRepo = new Login();

        // ── LOGIN ADMIN ────────────────────────────────────────────────
        public (bool ok, string msg) LoginAdmin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return (false, "Username dan password tidak boleh kosong.");

            string hash = Helper.HashPassword(password);
            try
            {
                using var conn = Koneksi.GetConnection();
                conn.Open();
                string sql = "SELECT * FROM Atmin WHERE username=@u AND password=@p LIMIT 1";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", hash);
                using var rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    UserSession.AdminID = Convert.ToInt32(rd["id_admin"]);
                    UserSession.Username = rd["username"]?.ToString() ?? string.Empty;
                    UserSession.Role = "ADMIN";
                    return (true, "Login berhasil.");
                }
            }
            catch (Exception ex) { return (false, ex.Message); }
            return (false, "Username atau password salah.");
        }

        // ── LOGIN USER ─────────────────────────────────────────────────
        public (bool ok, string msg) LoginUser(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return (false, "Email dan password tidak boleh kosong.");

            string hash = Helper.HashPassword(password);
            User? u = _userRepo.GetByEmailAndPassword(email, hash);
            if (u == null) return (false, "Email atau password salah.");

            UserSession.UserID = u.IdUser;
            UserSession.Username = u.Username;
            UserSession.Role = "USER";
            return (true, $"Selamat datang, {u.Username}!");
        }

        // ── REGISTER USER ──────────────────────────────────────────────
        public (bool ok, string msg) RegisterUser(
            string nama, string username, string noHp, string alamat,
            string email, string password, string konfirmasi)
        {
            if (string.IsNullOrWhiteSpace(nama)) return (false, "Nama wajib diisi.");
            if (string.IsNullOrWhiteSpace(username)) return (false, "Username wajib diisi.");
            if (string.IsNullOrWhiteSpace(email)) return (false, "Email wajib diisi.");
            if (string.IsNullOrWhiteSpace(password)) return (false, "Password wajib diisi.");
            if (password != konfirmasi) return (false, "Password tidak cocok.");
            if (password.Length < 6) return (false, "Password minimal 6 karakter.");
            if (_userRepo.IsEmailTaken(email)) return (false, "Email sudah terdaftar.");

            _userRepo.Register(new User
            {
                Nama = nama,
                Username = username,
                NoHp = noHp,
                Alamat = alamat,
                Email = email
            }, Helper.HashPassword(password));

            return (true, "Akun berhasil dibuat!");
        }

        public void Logout()
        {
            UserSession.UserID = 0;
            UserSession.AdminID = 0;
            UserSession.Username = string.Empty;
            UserSession.Role = string.Empty;
        }
    }
}
