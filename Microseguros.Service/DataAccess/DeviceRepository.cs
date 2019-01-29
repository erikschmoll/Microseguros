using Microseguros.Core.DataAccess;
using Microseguros.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microseguros.Service.DataAccess
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly ISqlDapper<Device> _sqlDapper;
        public DeviceRepository(ISqlDapper<Device> sqlDapper)
        {
            _sqlDapper = sqlDapper;
        }
        public IEnumerable<Device> Get()
        {
            try
            {
                return _sqlDapper.Get("devices");
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
