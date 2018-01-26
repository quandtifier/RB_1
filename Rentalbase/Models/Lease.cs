using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{
    public class Lease
    {
        public int ID { get; set; }
        public int PropertyID { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInMonths { get; set; }
        public double MonthlyRate { get; set; }
    }
}