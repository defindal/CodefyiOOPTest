using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class Produk
    {
        public enum Tipe
        {
            FRAME, LENSA, AKSESORIS
        }

        public String Kode { get; set; }

        public String Deskripsi { get; set; }

        public Tipe tipe { get; set; }

        public double Harga { get; set; }

        public double Diskon { get; set; }

        public double HargaPublish
        {
            get { return (100 - Diskon) * Harga; }
        }
    }
}
