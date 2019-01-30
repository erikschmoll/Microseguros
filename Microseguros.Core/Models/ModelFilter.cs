using System;
using System.Collections.Generic;
using System.Text;

namespace Microseguros.Core.Models
{
    public class ModelFilter : Filter
    {
        public int? BrandId { get; set; }
        public ModelFilter()
        {

        }
        public ModelFilter(int? skip, int? top, string pattName, int? brandId)
        {
            Skip = skip;
            Top = top;
            Patt = pattName;
            BrandId = brandId;
        }
    }
}
