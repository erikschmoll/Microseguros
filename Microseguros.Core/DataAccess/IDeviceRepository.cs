using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Core.DataAccess
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetAsync();
        Device Get(int id);
        IEnumerable<Device> Get(string name);
    }
}
