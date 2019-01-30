﻿using Microseguros.Core.Models;
using Microseguros.Core.Business;
using System;
using System.Collections.Generic;
using Microseguros.Core.DataAccess;
using Microsoft.Extensions.Logging;

namespace Microseguros.Business
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly ILogger<DeviceService> _logger;
        public DeviceService(ILogger<DeviceService> logger, IDeviceRepository deviceRepository)
        {
            _logger = logger;
            _deviceRepository = deviceRepository;
        }
        public IEnumerable<Device> GetAll()
        {
            try
            {
                return _deviceRepository.Get();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los dispositivos");
                throw ex;
            }
        }
    }
}
