using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{

    public class Property
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public PropertyType Type { get; set; }
        public double Value { get; set; }
        public int LandlordID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Tenant> Tenants { get; set; }
    }
}