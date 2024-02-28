using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaslangicProjesi.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int BasketId { get; set; }

        public DateTime OrderRegistrationDate { get; set; }

        public string OrderDescription { get; set; }


    }
}
