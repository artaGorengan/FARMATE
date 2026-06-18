using FARMATE.Models;
using FARMATE.Services;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FARMATE.Repositories;

namespace FARMATE.Controller
{
    internal class PengembalianController
    {
        private readonly PengembalianService _svc = new PengembalianService();

        public List<Pengembalian> GetAllAdmin() => _svc.GetAllAdmin();

        public (bool ok, string msg, string denda) Kembalikan(int idSewa, DateTime tglKembali)
            => _svc.Kembalikan(idSewa, tglKembali);

        private readonly PengembalianRepo _repo = new PengembalianRepo();


        public DataTable GetRiwayat()
        {
            return _repo.GetRiwayat();
        }

        public DataRow GetStatistik()
        {
            return _repo.GetStatistik();
        }

        public int GetJumlahTerlambat()
        {
            return _repo.GetJumlahTerlambat();
        }

        public decimal KonfirmasiPengembalian(int idSewa)
        {
            return _repo.KonfirmasiPengembalian(idSewa);
        }
    }

}
