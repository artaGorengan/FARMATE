using FARMATE.Models;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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
        };

        public DataTable GetRiwayat()
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                p.id_sewa,
                u.nama_user,
                a.merk_alat,
                p.tgl_sewa,
                p.tgl_pengembalian,
                p.total_harga,
                p.status_sewa
                FROM Penyewaan p
                JOIN Users u
                ON p.id_user = u.id_user
                JOIN Alat a
                ON p.id_alat = a.id_alat
                ORDER BY p.id_sewa DESC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt;
        }

        public DataRow GetStatistik()
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                COUNT(*) AS total,
                COUNT(*) FILTER
                (
                    WHERE status_sewa='Sedang Disewa'
                ) AS sedang,
                COUNT(*) FILTER
                (
                    WHERE status_sewa='Selesai'
                ) AS selesai
                FROM Penyewaan";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt.Rows[0];
        }

        public int GetJumlahTerlambat()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM Penyewaan
                WHERE status_sewa='Sedang Disewa'
                AND tgl_pengembalian < CURRENT_DATE";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());

            }
        }

        public decimal KonfirmasiPengembalian(int idSewa)
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                NpgsqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sqlAlat = @"
                    SELECT id_alat
                    FROM Penyewaan
                    WHERE id_sewa=@id";

                    NpgsqlCommand cmdAlat = new NpgsqlCommand(sqlAlat, conn);
                    cmdAlat.Transaction = trans;
                    cmdAlat.Parameters.AddWithValue("@id", idSewa);

                    int idAlat = Convert.ToInt32(cmdAlat.ExecuteScalar());
                    string sqlTanggal = @"
                    SELECT tgl_pengembalian
                    FROM Penyewaan
                    WHERE id_sewa=@id";

                    NpgsqlCommand cmdTanggal = new NpgsqlCommand(sqlTanggal, conn);


                    cmdTanggal.Transaction = trans;
                    cmdTanggal.Parameters.AddWithValue("@id", idSewa);

                    DateOnly batasKembali = (DateOnly)cmdTanggal.ExecuteScalar();
                    decimal denda = 0;

                    DateOnly hariIni = DateOnly.FromDateTime(DateTime.Today);
                    if (hariIni > batasKembali)
                    {
                        int hariTelat = hariIni.DayNumber - batasKembali.DayNumber;
                        denda = hariTelat * 50000;
                    }

                    string sqlInsert = @"
                    INSERT INTO Pengembalian
                    (
                        id_sewa,
                        tanggal_kembali,
                        denda
                    )
                    VALUES
                    (
                        @sewa,
                        @tgl,
                        @denda
                    )";

                    NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, conn);
                    cmdInsert.Transaction = trans;

                    cmdInsert.Parameters.AddWithValue("@sewa", idSewa);
                    cmdInsert.Parameters.AddWithValue("@tgl", DateTime.Today);
                    cmdInsert.Parameters.AddWithValue("@denda", denda);

                    cmdInsert.ExecuteNonQuery();

                    string sqlUpdateSewa = @"
                    UPDATE Penyewaan
                    SET status_sewa='Selesai'
                    WHERE id_sewa=@id";

                    NpgsqlCommand cmdSewa = new NpgsqlCommand(sqlUpdateSewa, conn);
                    cmdSewa.Transaction = trans;
                    cmdSewa.Parameters.AddWithValue("@id", idSewa);

                    cmdSewa.ExecuteNonQuery();

                    string sqlUpdateStok = @"
                    UPDATE Alat
                    SET stok_tersedia =
                    stok_tersedia + 1
                    WHERE id_alat=@alat";

                    NpgsqlCommand cmdStok = new NpgsqlCommand(sqlUpdateStok, conn);
                    cmdStok.Transaction = trans;
                    cmdStok.Parameters.AddWithValue("@alat", idAlat);
                    cmdStok.ExecuteNonQuery();
                    trans.Commit();
                    return denda;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }


}
