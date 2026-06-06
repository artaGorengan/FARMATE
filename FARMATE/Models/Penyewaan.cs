using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Models
{
    internal class Penyewaan
    {
        public int IdSewa { get; set; }
        public int IdUser { get; set; }
        public int IdAlat { get; set; }
        public int JumlahUnit { get; set; } = 1;
        public DateTime TglSewa { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public decimal TotalHarga { get; set; }
        public string StatusSewa { get; set; } = string.Empty;

        // Hasil JOIN
        public string NamaUser { get; set; } = string.Empty;
        public string NamaAlat { get; set; } = string.Empty;
        public decimal HargaPerHari { get; set; }

        // Computed
        public int DurasiHari => TglPengembalian.HasValue
            ? (int)(TglPengembalian.Value - TglSewa).TotalDays
            : (int)(DateTime.Today - TglSewa).TotalDays;
    }
}
