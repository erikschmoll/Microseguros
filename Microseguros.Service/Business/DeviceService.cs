using Microseguros.Core.Models;
using Microseguros.Core.Business;
using System;
using System.Collections.Generic;
using Microseguros.Core.DataAccess;

namespace Microseguros.Business
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }
        public IEnumerable<Device> GetAll()
        {
            return _deviceRepository.Get();
        }
    }
}
