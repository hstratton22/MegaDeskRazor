using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Model
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        //nullable
        [DisplayFormat(NullDisplayText = "Standard Shipping")]
        public int? RushDays { get; set; }
        public int DeskID {get; set;}
        public Desk Desk { get; set; }

    }
}
