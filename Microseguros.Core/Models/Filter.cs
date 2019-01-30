using System;
using System.Collections.Generic;
using System.Text;

namespace Microseguros.Core.Models
{
    public class Filter
    {
        public int? Skip { get; set; }
        public int? Top { get; set; }
        public string Patt { get; set; }
    }
}
