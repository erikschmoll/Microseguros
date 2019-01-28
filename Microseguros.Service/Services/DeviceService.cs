using Microseguros.Core.Models;
using Microseguros.Core.Services;
using System;
using System.Collections.Generic;

namespace Microseguros.Service
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
