using FARMATE.Models;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Repositories
{
    internal class PengembalianRepo
    {
        public List<Pengembalian> GetAllForAdmin()
        {
            var list = new List<Pengembalian>();
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"
                SELECT pg.*, u.nama_user, a.merk_alat AS nama_alat,
                       py.tgl_sewa, py.tgl_pengembalian
                FROM   Pengembalian pg
                JOIN   Penyewaan    py ON py.id_sewa  = pg.id_sewa
                JOIN   Users        u  ON u.id_user   = py.id_user
                JOIN   Alat         a  ON a.id_alat   = py.id_alat
                ORDER  BY pg.tanggal_kembali DESC";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        public void Insert(Pengembalian pg)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"INSERT INTO Pengembalian
                (id_sewa, tanggal_kembali, denda)
                VALUES(@sid, @tgl, @denda)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sid", pg.IdSewa);
            cmd.Parameters.AddWithValue("@tgl", pg.TanggalKembali);
            cmd.Parameters.AddWithValue("@denda", pg.Denda);
            cmd.ExecuteNonQuery();
        }

        private Pengembalian Map(NpgsqlDataReader rd) => new Pengembalian
        {
            IdKembali = Convert.ToInt32(rd["id_kembali"]),
            IdSewa = Convert.ToInt32(rd["id_sewa"]),
            TanggalKembali = Convert.ToDateTime(rd["tanggal_kembali"]),
            Denda = rd["denda"]?.ToString() ?? string.Empty,
            NamaUser = rd["nama_user"]?.ToString() ?? string.Empty,
            NamaAlat = rd["nama_alat"]?.ToString() ?? string.Empty,
            TglSewa = rd["tgl_sewa"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rd["tgl_sewa"]),
            TglPengembalian = rd["tgl_pengembalian"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(rd["tgl_pengembalian"])
        }
}
