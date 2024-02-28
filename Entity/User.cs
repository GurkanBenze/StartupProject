using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaslangicProjesi.Entity
{
    public class User 
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string TcNumber { get; set; }

        public string Password { get; set; }

        public byte  IsAdmin { get; set; }

        public byte IsDeletedUser { get; set; }









    }
}
