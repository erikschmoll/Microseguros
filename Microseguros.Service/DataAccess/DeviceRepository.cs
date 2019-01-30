using Microseguros.Core.DataAccess;
using Microseguros.Core.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Service.DataAccess
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly ISqlDapper<Device> _sqlDapper;
        private readonly ILogger<DeviceRepository> _logger;
        public DeviceRepository(ILogger<DeviceRepository> logger, ISqlDapper<Device> sqlDapper)
        {
            _logger = logger;
            _sqlDapper = sqlDapper;
        }
        public async Task<IEnumerable<Device>> GetAsync()
        {
            try
            {
                return await _sqlDapper.GetAsync("select * from devices");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeviceRepository/GetAsync");
                throw ex;
            }
        }

        public Device Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Device> Get(string name)
        {
            throw new NotImplementedException();
        }

        
    }
}
