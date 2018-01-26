using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Rentalbase.Models
{
    public class InvoiceType
    {
        [Key]
        public string Type { get; set; }
    }
}