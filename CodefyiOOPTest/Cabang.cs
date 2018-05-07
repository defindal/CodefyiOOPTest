using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class Cabang
    {
        public int ID { get; set; }
        public String Nama { get; set; }
        public String Kota { get; set; }
        public String Alamat { get; set; }
        
        public List<Karyawan> ListKaryawan { get; set; }
    }
}
