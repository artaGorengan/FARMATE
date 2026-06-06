using FARMATE.Models;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Repositories
{
    internal class AlatRepo
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
    }
}
