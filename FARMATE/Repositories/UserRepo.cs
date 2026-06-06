using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FARMATE.Models;

namespace FARMATE.Repositories
{
    internal class Login
    {
        public User? GetByEmailAndPassword(string email, string passwordHash)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = "SELECT * FROM Users WHERE email=@email AND password=@password LIMIT 1";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", passwordHash);
            using var rd = cmd.ExecuteReader();
            return rd.Read() ? Map(rd) : null;
        }

        public bool IsEmailTaken(string email)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Users WHERE email=@e", conn);
            cmd.Parameters.AddWithValue("@e", email);
            return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
        }

        public void Register(User u, string passwordHash)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"INSERT INTO Users (nama_user, username, password, email, no_telepon, alamat)
                           VALUES (@nama, @uname, @pass, @email, @hp, @alamat)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", u.Nama);
            cmd.Parameters.AddWithValue("@uname", u.Username);
            cmd.Parameters.AddWithValue("@pass", passwordHash);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@hp", u.NoHp);
            cmd.Parameters.AddWithValue("@alamat", u.Alamat);
            cmd.ExecuteNonQuery();
        }

        public List<User> GetAllUsers()
        {
            var list = new List<User>();
            using var conn = Koneksi.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM Users ORDER BY id_user", conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        private User Map(NpgsqlDataReader rd) => new User
        {
            IdUser = Convert.ToInt32(rd["id_user"]),
            Nama = rd["nama_user"]?.ToString() ?? string.Empty,
            Username = rd["username"]?.ToString() ?? string.Empty,
            Email = rd["email"]?.ToString() ?? string.Empty,
            NoHp = rd["no_telepon"]?.ToString() ?? string.Empty,
            Alamat = rd["alamat"]?.ToString() ?? string.Empty
        };
    }
}
