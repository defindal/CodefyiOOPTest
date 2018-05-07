using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefyiOOPTest
{
    public class Gudang : Cabang
    {
        public Dictionary<Produk, int> Stock { get; set; }
    }

}
