using FARMATE.Models;
using FARMATE.Repositories;
using FARMATE.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Services
{
    internal class AlatService
    {
        private readonly AlatRepo _repo = new AlatRepo();

        public List<Alat> GetAll(string keyword = "") => _repo.GetAll(keyword);
        public List<Alat> GetTersedia() => _repo.GetTersedia();
        public Alat? GetById(int id) => _repo.GetById(id);

        //implementasi abstract 
        public (bool ok, string msg) Tambah(Alat a)
        {
            if (string.IsNullOrWhiteSpace(a.MerkAlat)) return (false, "Merk/Nama alat wajib diisi.");
            if (a.IdKategori <= 0) return (false, "Kategori wajib dipilih.");
            if (a.HargaPerhari <= 0) return (false, "Harga sewa harus lebih dari 0.");
            if (a.StokTotal < 0) return (false, "Stok tidak boleh negatif.");
            a.StokTersedia = a.StokTotal;
            _repo.Insert(a, UserSession.AdminID);
            return (true, "Alat berhasil ditambahkan.");
        }

        public (bool ok, string msg) Edit(Alat a)
        {
            if (string.IsNullOrWhiteSpace(a.MerkAlat)) return (false, "Merk/Nama alat wajib diisi.");
            if (a.HargaPerhari <= 0) return (false, "Harga sewa harus lebih dari 0.");
            _repo.Update(a);
            return (true, "Alat berhasil diperbarui.");
        }

        public (bool ok, string msg) Hapus(int id)
        {
            if (id <= 0) return (false, "ID alat tidak valid.");
            _repo.Delete(id);
            return (true, "Alat berhasil dihapus.");
        }
    }
}
