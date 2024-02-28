using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaslangicProjesi.Entity
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public byte  IsActive{ get; set; }

    }
}
