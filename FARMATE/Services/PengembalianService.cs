using FARMATE.Models;
using FARMATE.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Services
{
    internal class PengembalianService
    {
        private readonly PengembalianRepo _repo = new PengembalianRepo();
        private readonly PenyewaanRepo _sewRepo = new PenyewaanRepo();
        private readonly AlatRepo _alatRepo = new AlatRepo();

        public List<Pengembalian> GetAllAdmin() => _repo.GetAllForAdmin();

        public (bool ok, string msg, string denda) Kembalikan(int idSewa, DateTime tglKembali)
        {
            Penyewaan? sewa = _sewRepo.GetById(idSewa);
            if (sewa == null) return (false, "Penyewaan tidak ditemukan.", "0");
            if (sewa.StatusSewa != "Aktif") return (false, "Penyewaan sudah selesai / bukan aktif.", "0");

            string dendaStr = "0";
            if (sewa.TglPengembalian.HasValue && tglKembali > sewa.TglPengembalian.Value)
            {
                int telatHari = (int)(tglKembali - sewa.TglPengembalian.Value).TotalDays;
                decimal dendaVal = telatHari * sewa.HargaPerHari * 0.5m;
                dendaStr = $"Rp {dendaVal:N0} ({telatHari} hari terlambat)";
            }

            _repo.Insert(new Pengembalian
            {
                IdSewa = idSewa,
                TanggalKembali = tglKembali,
                Denda = dendaStr
            });

            _sewRepo.UpdateStatus(idSewa, "Selesai");

            // Kembalikan stok
            Alat? alat = _alatRepo.GetById(sewa.IdAlat);
            if (alat != null)
            {
                alat.StokTersedia += sewa.JumlahUnit;
                _alatRepo.Update(alat);
            }

            string msg = dendaStr != "0"
                ? $"Pengembalian berhasil. Denda keterlambatan: {dendaStr}"
                : "Pengembalian berhasil. Tidak ada denda.";
            return (true, msg, dendaStr);
        }
    }
}
