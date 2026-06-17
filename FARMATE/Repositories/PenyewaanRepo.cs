using FARMATE.Models;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FARMATE.Repositories
{
    internal class PenyewaanRepo
    {
        private const string SelectJoin = @"
            SELECT p.*, u.nama_user, u.username,
                   a.merk_alat AS nama_alat, a.harga_perhari
            FROM   Penyewaan p
            JOIN   Users u ON u.id_user = p.id_user
            JOIN   Alat  a ON a.id_alat = p.id_alat";

        public List<Penyewaan> GetAllForAdmin(string keyword = "")
        {
            var list = new List<Penyewaan>();
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = SelectJoin + @"
                WHERE @kw = '' OR u.nama_user ILIKE '%'||@kw||'%'
                               OR a.merk_alat ILIKE '%'||@kw||'%'
                ORDER BY p.tgl_sewa DESC";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kw", keyword);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        public List<Penyewaan> GetAktifByUser(int idUser)
        {
            var list = new List<Penyewaan>();
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = SelectJoin + @"
                WHERE p.id_user=@uid AND p.status_sewa='Aktif'
                ORDER BY p.tgl_sewa";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", idUser);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        public List<Penyewaan> GetRiwayatByUser(int idUser)
        {
            var list = new List<Penyewaan>();
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = SelectJoin + @"
                WHERE p.id_user=@uid
                ORDER BY p.tgl_sewa DESC";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", idUser);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        public Penyewaan? GetById(int id)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = SelectJoin + " WHERE p.id_sewa=@id LIMIT 1";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var rd = cmd.ExecuteReader();
            return rd.Read() ? Map(rd) : null;
        }

        public int Insert(Penyewaan p)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"INSERT INTO Penyewaan
                (id_user, id_alat, jumlah_unit, tgl_sewa, tgl_pengembalian, total_harga, status_sewa)
                VALUES(@uid, @aid, @jml, @tgl, @tglkembali, @total, 'Aktif')
                RETURNING id_sewa";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", p.IdUser);
            cmd.Parameters.AddWithValue("@aid", p.IdAlat);
            cmd.Parameters.AddWithValue("@jml", p.JumlahUnit);
            cmd.Parameters.AddWithValue("@tgl", p.TglSewa);
            cmd.Parameters.AddWithValue("@tglkembali", (object?)p.TglPengembalian ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@total", p.TotalHarga);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void UpdateStatus(int id, string status)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE Penyewaan SET status_sewa=@s WHERE id_sewa=@id", conn);
            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private Penyewaan Map(NpgsqlDataReader rd) => new Penyewaan
        {
            IdSewa = Convert.ToInt32(rd["id_sewa"]),
            IdUser = Convert.ToInt32(rd["id_user"]),
            IdAlat = Convert.ToInt32(rd["id_alat"]),
            JumlahUnit = rd["jumlah_unit"] == DBNull.Value ? 1 : Convert.ToInt32(rd["jumlah_unit"]),
            TglSewa = Convert.ToDateTime(rd["tgl_sewa"]),
            TglPengembalian = rd["tgl_pengembalian"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(rd["tgl_pengembalian"]),
            TotalHarga = Convert.ToDecimal(rd["total_harga"]),
            StatusSewa = rd["status_sewa"]?.ToString() ?? string.Empty,
            NamaUser = rd["nama_user"]?.ToString() ?? string.Empty,
            NamaAlat = rd["nama_alat"]?.ToString() ?? string.Empty,
            HargaPerHari = Convert.ToDecimal(rd["harga_perhari"])
        };

        public DataTable GetRiwayatUser(int userId, int kategoriId)
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                a.merk_alat,
                k.nama_kategori,
                p.tgl_sewa,
                p.tgl_pengembalian,
                p.status_sewa
                FROM Penyewaan p
                JOIN Alat a
                ON p.id_alat = a.id_alat
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori
                WHERE p.id_user=@user";

                if (kategoriId != 0)
                {
                    sql += " AND k.id_kategori=@kategori";
                }

                sql += " ORDER BY p.id_sewa DESC";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user", userId);

                if (kategoriId != 0)
                {
                    cmd.Parameters.AddWithValue(
                        "@kategori",
                        kategoriId);
                }

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        public DataTable GetStatistikUser(int userId)
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                COUNT(*) AS total,

                COUNT(*) FILTER
                (WHERE status_sewa='Sedang Disewa')
                AS sedang,

                COUNT(*) FILTER
                (WHERE status_sewa='Selesai')
                AS selesai

                FROM Penyewaan
                WHERE id_user=@user";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@user",
                    userId);

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        public DataTable GetKategori()
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                id_kategori,
                nama_kategori
                FROM KategoriAlat
                ORDER BY nama_kategori";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(sql, conn);

                da.Fill(dt);
            }

            return dt;
        }
    }

}
