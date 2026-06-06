using FARMATE.Models;
using FARMATE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Controller
{
    internal class PengembalianController
    {
        private readonly PengembalianService _svc = new PengembalianService();

        public List<Pengembalian> GetAllAdmin() => _svc.GetAllAdmin();

        public (bool ok, string msg, string denda) Kembalikan(int idSewa, DateTime tglKembali)
            => _svc.Kembalikan(idSewa, tglKembali);
    }
}
