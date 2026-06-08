using System;
using System.Collections.Generic;
using System.Text;

namespace FARMATE.Models
{
    internal class Alat
    {
        public int IdAlat { get; set; }
        public int IdAdmin { get; set; }
        public int IdKategori { get; set; }
        public string MerkAlat { get; set; } = string.Empty;
        public string Deskripsi { get; set; } = string.Empty;
        public decimal HargaPerhari { get; set; }
        public int StokTotal { get; set; }
        public int StokTersedia { get; set; }
        public string BahanBakar { get; set; } 
        public string Gambar { get; set; }

        // JOIN fields untuk tampilan
        public string NamaKategori { get; set; } = string.Empty;
        public string NamaAlat => MerkAlat; // alias untuk kompatibilitas tampilan
        public string Status => StokTersedia > 0 ? "Tersedia" : "Habis";
    }
}
