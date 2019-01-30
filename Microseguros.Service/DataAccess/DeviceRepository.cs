using Microseguros.Core.DataAccess;
using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Service.DataAccess
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly ISqlDapper<Device> _sqlDapper;
        public DeviceRepository(ISqlDapper<Device> sqlDapper)
        {
            _sqlDapper = sqlDapper;
        }
        public async Task<IEnumerable<Device>> GetAsync()
        {
            try
            {
                return await _sqlDapper.GetAsync("devices");
            }
            catch (Exception e)
            {
                throw e;
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
