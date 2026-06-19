using FARMATE.Models;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FARMATE.Repositories
{
    internal class AlatRepo : BaseRepo
    {
        public List<Alat> GetAll(string keyword = "")
        {
            var list = new List<Alat>();
            using var conn = Koneksi.GetConnection();
            conn.Open(); 
            string sql = @"
                SELECT a.*, k.nama_kategori
                FROM   Alat a
                JOIN   KategoriAlat k ON k.id_kategori = a.id_kategori
                WHERE  @kw = '' OR a.merk_alat ILIKE '%'||@kw||'%'
                               OR k.nama_kategori ILIKE '%'||@kw||'%'
                ORDER  BY a.id_alat";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kw", keyword);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        public List<Alat> GetTersedia()
        {
            var list = new List<Alat>();
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"
                SELECT a.*, k.nama_kategori
                FROM   Alat a
                JOIN   KategoriAlat k ON k.id_kategori = a.id_kategori
                WHERE  a.stok_tersedia > 0
                ORDER  BY a.id_alat";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read()) list.Add(Map(rd));
            return list;
        }

        public Alat? GetById(int id)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"
                SELECT a.*, k.nama_kategori
                FROM   Alat a
                JOIN   KategoriAlat k ON k.id_kategori = a.id_kategori
                WHERE  a.id_alat = @id LIMIT 1";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var rd = cmd.ExecuteReader();
            return rd.Read() ? Map(rd) : null;
        }
        //query dari implementasi abstract
        public void Insert(Alat a, int idAdmin)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"INSERT INTO Alat
                (id_admin, id_kategori, merk_alat, deskripsi, harga_perhari, stok_total, stok_tersedia, bahan_bakar)
                VALUES(@admin, @kat, @merk, @desk, @harga, @stokTotal, @stokTersedia, @bbm)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@admin", idAdmin);
            cmd.Parameters.AddWithValue("@kat", a.IdKategori);
            cmd.Parameters.AddWithValue("@merk", a.MerkAlat);
            cmd.Parameters.AddWithValue("@desk", a.Deskripsi);
            cmd.Parameters.AddWithValue("@harga", a.HargaPerhari);
            cmd.Parameters.AddWithValue("@stokTotal", a.StokTotal);
            cmd.Parameters.AddWithValue("@stokTersedia", a.StokTersedia);
            cmd.Parameters.AddWithValue("@bbm", a.BahanBakar);
            cmd.ExecuteNonQuery();
        }

        public void Update(Alat a)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = @"UPDATE Alat SET
                id_kategori=@kat, merk_alat=@merk, deskripsi=@desk,
                harga_perhari=@harga, stok_total=@stokTotal,
                stok_tersedia=@stokTersedia, bahan_bakar=@bbm
                WHERE id_alat=@id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", a.IdAlat);
            cmd.Parameters.AddWithValue("@kat", a.IdKategori);
            cmd.Parameters.AddWithValue("@merk", a.MerkAlat);
            cmd.Parameters.AddWithValue("@desk", a.Deskripsi);
            cmd.Parameters.AddWithValue("@harga", a.HargaPerhari);
            cmd.Parameters.AddWithValue("@stokTotal", a.StokTotal);
            cmd.Parameters.AddWithValue("@stokTersedia", a.StokTersedia);
            cmd.Parameters.AddWithValue("@bbm", a.BahanBakar);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM Alat WHERE id_alat=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private Alat Map(NpgsqlDataReader rd) => new Alat
        {
            IdAlat = Convert.ToInt32(rd["id_alat"]),
            IdAdmin = Convert.ToInt32(rd["id_admin"]),
            IdKategori = Convert.ToInt32(rd["id_kategori"]),
            MerkAlat = rd["merk_alat"]?.ToString() ?? string.Empty,
            Deskripsi = rd["deskripsi"]?.ToString() ?? string.Empty,
            HargaPerhari = rd["harga_perhari"] == DBNull.Value ? 0 : Convert.ToDecimal(rd["harga_perhari"]),
            StokTotal = rd["stok_total"] == DBNull.Value ? 0 : Convert.ToInt32(rd["stok_total"]),
            StokTersedia = rd["stok_tersedia"] == DBNull.Value ? 0 : Convert.ToInt32(rd["stok_tersedia"]),
            BahanBakar = rd["bahan_bakar"]?.ToString() ?? string.Empty,
            NamaKategori = rd["nama_kategori"]?.ToString() ?? string.Empty
        };

        public DataTable GetAllAlat()
        {
            DataTable dt = new DataTable();

            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            SELECT
            a.id_alat,
            a.merk_alat,
            a.harga_perhari,
            a.stok_tersedia,
            a.foto_alat,
            k.nama_kategori
            FROM Alat a
            JOIN KategoriAlat k
            ON a.id_kategori = k.id_kategori";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public void HapusAlat(int idAlat)
        {
            try
            {
                using var conn = Koneksi.GetConnection();
                conn.Open();

                string sql =
                    "DELETE FROM Alat WHERE id_alat=@id";

                using var cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", idAlat);

                int hasil = cmd.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetStatistik()
        {
            DataTable dt = new DataTable();

            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            SELECT
            (SELECT COUNT(*) FROM Alat) total_alat,
            (SELECT COUNT(*)
            FROM Alat a
            JOIN KategoriAlat k
            ON a.id_kategori=k.id_kategori
            WHERE k.nama_kategori='Drone Pertanian')
            drone,

            (SELECT COUNT(*)
            FROM Alat a
            JOIN KategoriAlat k
            ON a.id_kategori=k.id_kategori
            WHERE k.nama_kategori='Traktor')
            traktor,

            (SELECT COUNT(*)
            FROM Alat a
            JOIN KategoriAlat k
            ON a.id_kategori=k.id_kategori
            WHERE k.nama_kategori='Mesin Panen')
            panen";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetKategori()
        {
            DataTable dt = new DataTable();

            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            SELECT
            id_kategori,
            nama_kategori
            FROM KategoriAlat";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public void TambahAlat(int adminId, int kategori, string merk, string deskripsi, decimal harga, int stok, string bbm, string foto)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            INSERT INTO Alat
            (
            id_admin,
            id_kategori,
            merk_alat,
            deskripsi,
            harga_perhari,
            stok_total,
            stok_tersedia,
            bahan_bakar,
            foto_alat
            )
            VALUES
            (
            @admin,
            @kategori,
            @merk,
            @deskripsi,
            @harga,
            @stoktotal,
            @stoktersedia,
            @bbm,
            @foto
            )";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@admin", adminId);
            cmd.Parameters.AddWithValue("@kategori", kategori);
            cmd.Parameters.AddWithValue("@merk", merk);
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stoktotal", stok);
            cmd.Parameters.AddWithValue("@stoktersedia", stok);
            cmd.Parameters.AddWithValue("@bbm", bbm);
            cmd.Parameters.AddWithValue("@foto", foto);
            cmd.ExecuteNonQuery();
        }

        public void UpdateAlat(int idAlat, int kategori, string merk, string deskripsi, decimal harga, int stok, string bbm)
        {
            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            UPDATE Alat
            SET
            id_kategori=@kategori,
            merk_alat=@merk,
            deskripsi=@deskripsi,
            harga_perhari=@harga,
            stok_total=@stok,
            stok_tersedia=@stok,
            bahan_bakar=@bbm
            WHERE id_alat=@id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idAlat);
            cmd.Parameters.AddWithValue("@kategori", kategori);
            cmd.Parameters.AddWithValue("@merk", merk);
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@bbm", bbm);
            cmd.ExecuteNonQuery();
        }

        public DataRow GetAlatById(int idAlat)
        {
            DataTable dt = new DataTable();

            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            SELECT *
            FROM Alat
            WHERE id_alat=@id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idAlat);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                return dt.Rows[0];

            return null;
        }

        public DataTable GetKategoriUser()
        {
            DataTable dt = new DataTable();

            using var conn = Koneksi.GetConnection();
            conn.Open();

            string sql = @"
            SELECT
            id_kategori,
            nama_kategori
            FROM KategoriAlat
            ORDER BY id_kategori";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetDaftarAlat(int kategori)
        {
            DataTable dt = new DataTable();

            using var conn = Koneksi.GetConnection();
            conn.Open();
            string sql = "SELECT * FROM Alat";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            if (kategori != 0)
            {
                sql += " WHERE id_kategori=@kategori";
                cmd.Parameters.AddWithValue("@kategori", kategori);
            }

            cmd.CommandText = sql;

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public DataRow GetDetailAlat(int idAlat)
        {
            DataTable dt = new DataTable();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                a.*,
                k.nama_kategori
                FROM Alat a
                JOIN KategoriAlat k
                ON a.id_kategori = k.id_kategori
                WHERE a.id_alat = @id";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idAlat);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
                return dt.Rows[0];

            return null;
        }

        public void SimpanPenyewaan(
            int userId,
            int alatId,
            int jumlahHari,
            decimal hargaPerHari)
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();

                NpgsqlTransaction trans =
                    conn.BeginTransaction();

                try
                {
                    DateTime tglSewa = DateTime.Today;
                    DateTime tglKembali = tglSewa.AddDays(jumlahHari);
                    decimal total = hargaPerHari * jumlahHari;
                    string sql = @"
                    INSERT INTO Penyewaan
                    (
                    id_user,
                    id_alat,
                    jumlah_unit,
                    tgl_sewa,
                    tgl_pengembalian,
                    total_harga,
                    status_sewa
                    )
                    VALUES
                    (
                    @user,
                    @alat,
                    @jumlah,
                    @tglsewa,
                    @tglkembali,
                    @total,
                    @status
                    )";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Transaction = trans;

                    cmd.Parameters.AddWithValue("@user", userId);
                    cmd.Parameters.AddWithValue("@alat", alatId);
                    cmd.Parameters.AddWithValue("@jumlah", 1);
                    cmd.Parameters.AddWithValue("@tglsewa", tglSewa);
                    cmd.Parameters.AddWithValue("@tglkembali", tglKembali);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@status", "Sedang Disewa");

                    cmd.ExecuteNonQuery();

                    string sqlUpdate = @"
                    UPDATE Alat
                    SET stok_tersedia = stok_tersedia - 1
                    WHERE id_alat = @id";

                    NpgsqlCommand cmdUpdate = new NpgsqlCommand(sqlUpdate, conn);
                    cmdUpdate.Transaction = trans;
                    cmdUpdate.Parameters.AddWithValue("@id", alatId);
                    cmdUpdate.ExecuteNonQuery();
                    trans.Commit();
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
