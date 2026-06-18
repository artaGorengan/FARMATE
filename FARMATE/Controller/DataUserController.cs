using FARMATE.Models;
using FARMATE.Repositories;
using FARMATE.Utils;
using FARMATE.Views.Admin;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FARMATE.Controller
{
    internal class DataUserController
    {
        private readonly UserRepository _repo = new UserRepository();
        public DataTable GetDataUser()
        {
            return _repo.GetDataUser();
        }
    }
}