using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5Task4
{
    class Apartment : Building
    {
        public string CurrentTenant {get; set;}
        public string ApartmentNumber { get; set; }
        public string Tenants { get; set; }

        public Apartment(string apartments,string currenttenant, string apartmentnumber, string tenants)
        {
            CurrentTenant = currenttenant;
            ApartmentNumber = apartmentnumber;
            Tenants = tenants;
        } 
    }
}
