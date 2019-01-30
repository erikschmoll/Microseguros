using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Core.Business
{
    public interface IDeviceService
    {
        Task<IEnumerable<Device>> GetAsync();
    }
}
