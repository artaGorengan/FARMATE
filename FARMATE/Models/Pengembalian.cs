using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Models
{
    internal class Pengembalian
    {
        public int IdKembali { get; set; }
        public int IdSewa { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Denda { get; set; } = string.Empty;

        // Hasil JOIN
        public string NamaUser { get; set; } = string.Empty;
        public string NamaAlat { get; set; } = string.Empty;
        public DateTime TglSewa { get; set; }
        public DateTime? TglPengembalian { get; set; }
    }
}
