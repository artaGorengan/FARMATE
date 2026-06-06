using FARMATE.Models;
using FARMATE.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
}
