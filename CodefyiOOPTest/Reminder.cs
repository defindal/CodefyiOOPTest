using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class Reminder
    {
        public enum Status { BELUM, TERKIRIM, DIRESPON}

        public DateTime TanggalPengiriman { get; set; }

        public Status StatusReminder { get; set; }

    }
}
