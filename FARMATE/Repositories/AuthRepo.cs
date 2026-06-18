using FARMATE.Utils;
using Npgsql;
using System.Data;

namespace FARMATE.Repositories
{
    internal class AuthRepo
    {
        public DataRow LoginAdmin(
            string username,
            string password)
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT *
                FROM Atmin
                WHERE username=@username
                AND password=@password";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
                return dt.Rows[0];

            return null;
        }
    }
}