using FARMATE.Models;
using FARMATE.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Services
{
    internal class PenyewaanService
    {
        private readonly PenyewaanRepo _repo = new PenyewaanRepo();
        private readonly AlatRepo _alatRepo = new AlatRepo();

        public List<Penyewaan> GetAllAdmin(string keyword = "") => _repo.GetAllForAdmin(keyword);
        public List<Penyewaan> GetAktifUser(int idUser) => _repo.GetAktifByUser(idUser);
        public List<Penyewaan> GetRiwayatUser(int idUser) => _repo.GetRiwayatByUser(idUser);

        public (bool ok, string msg) Sewa(int idUser, int idAlat, DateTime tglSewa, int jumlahUnit, DateTime? tglKembali)
        {
            if (jumlahUnit <= 0) return (false, "Jumlah unit minimal 1.");
            if (tglSewa.Date < DateTime.Today) return (false, "Tanggal sewa tidak boleh di masa lalu.");

            Alat? alat = _alatRepo.GetById(idAlat);
            if (alat == null) return (false, "Alat tidak ditemukan.");
            if (alat.StokTersedia <= 0) return (false, "Stok alat habis.");

            int durasi = tglKembali.HasValue ? (int)(tglKembali.Value - tglSewa).TotalDays : 1;
            if (durasi <= 0) durasi = 1;
            decimal total = alat.HargaPerhari * durasi * jumlahUnit;

            var p = new Penyewaan
            {
                IdUser = idUser,
                IdAlat = idAlat,
                JumlahUnit = jumlahUnit,
                TglSewa = tglSewa,
                TglPengembalian = tglKembali,
                TotalHarga = total,
                StatusSewa = "Aktif"
            };
            _repo.Insert(p);

            // Kurangi stok tersedia
            alat.StokTersedia -= jumlahUnit;
            _alatRepo.Update(alat);

            return (true, $"Berhasil menyewa {alat.MerkAlat} ({jumlahUnit} unit).\nTotal: Rp {total:N0}");
        }
    }
}
