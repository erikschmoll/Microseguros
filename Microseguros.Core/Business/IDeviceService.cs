using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microseguros.Core.Business
{
    public interface IDeviceService
    {
        IEnumerable<Device> GetAll();
    }
}
