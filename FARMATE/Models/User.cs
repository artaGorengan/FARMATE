using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Models
{
    internal class User
    {
        public int IdUser { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string NoHp { get; set; } = string.Empty;
        public string Alamat { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
