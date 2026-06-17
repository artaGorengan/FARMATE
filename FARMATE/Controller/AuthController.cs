using FARMATE.Repositories;
using FARMATE.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FARMATE.Controller
{
    internal class AuthController
    {
        private readonly AuthService _svc = new AuthService();

        public (bool ok, string msg) LoginAdmin(string username, string password)
            => _svc.LoginAdmin(username, password);

        public (bool ok, string msg) LoginUser(string email, string password)
            => _svc.LoginUser(email, password);

        public (bool ok, string msg) RegisterUser(
            string nama, string username, string noHp, string alamat,
            string email, string password, string konfirmasi)
            => _svc.RegisterUser(nama, username, noHp, alamat, email, password, konfirmasi);

        public void Logout() => _svc.Logout();
    }

    public class AdminController
    {
        private readonly AuthRepo _repo =
            new AuthRepo();

        public DataRow Login(
            string username,
            string password)
        {
            return _repo.LoginAdmin(
                username,
                password);
        }
    }
}
