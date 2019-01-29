using Microseguros.Core.Models;
using Microseguros.Core.Business;
using System;
using System.Collections.Generic;

namespace Microseguros.Business
{
    public class DeviceService : IDeviceService
    {
        public IEnumerable<Device> GetAll()
        {
            return new List<Device>()
            {
                new Device(){ Name = "as" }
            };
        }
    }
}
