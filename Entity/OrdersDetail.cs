﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaslangicProjesi.Entity
{
    public class OrdersDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amout { get; set; }
        public int Price { get; set; }

        public int TotalPrice { get; set; }



    }
}
