using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class PemesananPasien
    {
        public enum Status
        {
            PENGAJUAN, PRODUKSI, SIAP_DIAMBIL, SUDAH_DIAMBIL
        }

        public String NomorPesanan { get; set; }
        public Pasien Pasien { get; set; }
        public double Total { get; set; }
        public double Pembayaran { get; set; }
        public bool SudahLunas { get { return Total - Pembayaran == 0; } }
        public DateTime TanggalPemesanan { get; set; }
        public Karyawan PICPemesanan { get; set; }
        public Pabrik PabrikPembuatan { get; set; }
        public Outlet OutletPengambilan { get; set; }
        public DateTime TanggalPengambilan { get; set; }
        public Karyawan PICPengambilan { get; set; }
        public List<DetilPemesananPasien> ListDetailPesanan { get; set; }

        public Status status { get; set; }
    }
}
