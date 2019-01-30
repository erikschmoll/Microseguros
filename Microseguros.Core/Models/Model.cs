﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microseguros.Core.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int DeviceId { get; set; }
        public float Quoted { get; set; }
    }
}
