using FARMATE.Models;
using FARMATE.Repositories;
using FARMATE.Services;
using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FARMATE.Controller
{
    internal class AlatController
    {
        
        private readonly AlatService _svc = new AlatService();
        private readonly AlatRepo _repo = new AlatRepo();

        public List<Alat> GetAll(string keyword = "") => _svc.GetAll(keyword);
        public List<Alat> GetTersedia() => _svc.GetTersedia();
        public Alat? GetById(int id) => _svc.GetById(id);

        //abstract (blue print)
        public (bool ok, string msg) Tambah(Alat a) => _svc.Tambah(a);
        public (bool ok, string msg) Edit(Alat a) => _svc.Edit(a);
        public (bool ok, string msg) Hapus(int id) => _svc.Hapus(id);

        //---------------------------------------FITUR ADMIN---------------------------------------------
        public DataTable GetAllAlat()
        {
            return _repo.GetAllAlat();
        }

        public void HapusAlat(int idAlat)
        {
            _repo.HapusAlat(idAlat);
        }

        public DataTable GetStatistik()
        {
            return _repo.GetStatistik();
        }

        public DataTable GetKategori()
        {
            return _repo.GetKategori();
        }

        public void TambahAlat(int adminId, int kategori, string merk, string deskripsi, decimal harga, int stok, string bbm, string foto)
        {
            _repo.TambahAlat(adminId, kategori, merk, deskripsi, harga, stok, bbm, foto);
        }
        public void UpdateAlat(int idAlat, int kategori, string merk, string deskripsi, decimal harga, int stok, string bbm)
        {
            _repo.UpdateAlat(idAlat, kategori, merk, deskripsi, harga, stok, bbm);

        }
        //------------------------------------------FITUR USER------------------------------------------
        public DataTable GetKategoriUser()
        {
            return _repo.GetKategoriUser();
        }

        public DataTable GetDaftarAlat(int kategori)
        {
            return _repo.GetDaftarAlat(kategori);
        }

        public DataRow GetAlatById(int idAlat)
        {
            return _repo.GetAlatById(idAlat);
        }
        public DataRow GetDetailAlat(int idAlat)
        {
            return _repo.GetDetailAlat(idAlat);
        }

        public void SimpanPenyewaan(int userId, int alatId, int jumlahHari, decimal hargaPerHari)
        {
            _repo.SimpanPenyewaan(userId, alatId, jumlahHari, hargaPerHari);
        }
    }
}
