using FARMATE.Models;
using FARMATE.Services;
    using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Controller
{
    internal class AlatController
    {
        private readonly AlatService _svc = new AlatService();

        public List<Alat> GetAll(string keyword = "") => _svc.GetAll(keyword);
        public List<Alat> GetTersedia() => _svc.GetTersedia();
        public Alat? GetById(int id) => _svc.GetById(id);

        public (bool ok, string msg) Tambah(Alat a) => _svc.Tambah(a);
        public (bool ok, string msg) Edit(Alat a) => _svc.Edit(a);
        public (bool ok, string msg) Hapus(int id) => _svc.Hapus(id);
    }
}
