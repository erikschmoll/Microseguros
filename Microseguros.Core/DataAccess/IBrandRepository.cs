﻿using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Core.DataAccess
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAsync();
    }
}
