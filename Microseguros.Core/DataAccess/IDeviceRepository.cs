using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microseguros.Core.DataAccess
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> Get();
        Device Get(int id);
        IEnumerable<Device> Get(string name);
    }
}
