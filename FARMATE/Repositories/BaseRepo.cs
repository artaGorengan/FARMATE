using FARMATE.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Repositories
{
    internal class BaseRepo
    {
        protected NpgsqlConnection GetOpenConnection()
        {
            var conn = Koneksi.GetConnection();
            conn.Open();
            return conn;
        }
    }
}
