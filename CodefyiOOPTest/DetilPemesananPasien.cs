using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class DetilPemesananPasien : DetilPemesanan
    {
        public PemesananPasien Pesanan { get; set; }       

        public double HargaJual { get; set; }

        public double SubTotal { get { return Jumlah * HargaJual; } }

    }
}
