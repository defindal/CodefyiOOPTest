using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class Pasien
    {
        public String ID { get; set; }
        public String Nama { get; set; }
        public String Alamat { get; set; }
        public DateTime TanggalLahir { get; set; }
        public String Handphone { get; set; }

        public List<Pemeriksaan> ListPemeriksaan { get; set; }

        public List<PemesananPasien> ListPesanan { get; set; }

        public DateTime? TanggalPesananTerakhir {
            get {
                if (ListPesanan.Count > 0)
                {
                    return ListPesanan.Last().TanggalPemesanan;
                }
                else return null;
            }
        }

        public double? JumlahTransaksiTerakhir
        {
            get
            {
                if (ListPesanan.Count > 0)
                {
                    return ListPesanan.Last().Total;
                }
                else return null;
            }
        }

        public DateTime? JadwalBerikut
        {
            get
            {
                if (ListPemeriksaan.Count > 0)
                {
                    return ListPemeriksaan.Last().TanggalPemeriksaan.AddDays(
                        ListPemeriksaan.Last().JadwalSelanjutnya
                    );
                }
                else return null;
            }
        }

        public List<Reminder> ListReminder { get; set; }

        public Reminder.Status StatusReminder
        {
            get {
                if (ListReminder.Count > 0)
                {
                    return ListReminder.Last().StatusReminder;
                }
                else return Reminder.Status.BELUM;
            }
        }

        public bool Terarsip
        {
            get
            {
                if (ListReminder.Count() == 3)
                {
                    return ListReminder.Last().StatusReminder == Reminder.Status.TERKIRIM;
                }
                else return false;
            }
        }

        public bool SudahMembuatJanji
        {
            get
            {
                if (ListPemeriksaan.Count() > 0)
                {
                    return ListPemeriksaan.Last().TanggalPemeriksaan > DateTime.Now;
                }
                else return false;
            }
        }
    }
}
