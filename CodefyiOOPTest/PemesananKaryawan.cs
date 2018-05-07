using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class PemesananKaryawan
    {
        public enum Status
        {
            PENGAJUAN, SUDAH_DITERIMA
        }

        public String NomorPesanan { get; set; }
        public Karyawan Pemesan { get; set; }
        public Outlet Tujuan { get; set; }

        public List<DetilPemesananKaryawan> DetailPesanan { get; set; }

    }
}
