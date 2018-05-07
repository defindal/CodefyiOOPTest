using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class Pemeriksaan
    {
        public enum Status { PENGAJUAN, KONFIRMASI}

        public int ID { get; set; }
        public Karyawan AhliMata { get; set; }
        public Pasien Pasien { get; set; }

        public Status StatusJadwal { get; set; }

        public DateTime TanggalPemeriksaan { get; set; }

        public int JadwalSelanjutnya { get; set; } // satuan Hari



    }
}
