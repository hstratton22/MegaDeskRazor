using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Model
{
    public enum DesktopMaterial
    {
        Laminate, Oak, Pine, Rosewood, Veneer
    }
    public class Desk
    {
        public int ID { get; set; }
        public int width { get; set; }
        public int length { get; set; }

        //nullable
        [DisplayFormat(NullDisplayText = "No drawers")]
        public int? drawers { get; set; }
        public DesktopMaterial desktopMaterial { get; set; }
    }
}
