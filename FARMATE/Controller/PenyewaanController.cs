using FARMATE.Models;
using FARMATE.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FARMATE.Repositories;

namespace FARMATE.Controller
{
    internal class PenyewaanController
    {
        private readonly PenyewaanService _svc = new PenyewaanService();

        public List<Penyewaan> GetAllAdmin(string keyword = "") => _svc.GetAllAdmin(keyword);
        public List<Penyewaan> GetAktifUser(int idUser) => _svc.GetAktifUser(idUser);
        public List<Penyewaan> GetRiwayatUser(int idUser) => _svc.GetRiwayatUser(idUser);

        public (bool ok, string msg) Sewa(int idUser, int idAlat, DateTime tglSewa,
            int jumlahUnit, DateTime? tglKembali)
            => _svc.Sewa(idUser, idAlat, tglSewa, jumlahUnit, tglKembali);
    }
    internal class RiwayatController
    {
        private readonly PenyewaanRepo _repo =
            new PenyewaanRepo();

        public DataTable GetRiwayatUser(
            int userId,
            int kategoriId)
        {
            return _repo.GetRiwayatUser(
                userId,
                kategoriId);
        }

        public DataTable GetStatistikUser(
            int userId)
        {
            return _repo.GetStatistikUser(
                userId);
        }

        public DataTable GetKategori()
        {
            return _repo.GetKategori();
        }
    }

}
