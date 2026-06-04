using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Utils

{
    internal class Koneksi
    {
            private static string connString =
                "Host=localhost;Port=5432;Username=postgres;Password=123456789;Database=FARMATE";

            public static NpgsqlConnection GetConnection()
            {
                return new NpgsqlConnection(connString);
            }
    }
}
