using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microseguros.Core.DataAccess;
using Microseguros.Core.Models;
using Microsoft.Extensions.Logging;

namespace Microseguros.Service.DataAccess
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ILogger<BrandRepository> _logger;
        private readonly ISqlDapper<Brand> _sqlDapper;

        public BrandRepository(ILogger<BrandRepository> logger, ISqlDapper<Brand> sqlDapper)
        {
            _logger = logger;
            _sqlDapper = sqlDapper;
        }

        public async Task<IEnumerable<Brand>> GetAsync()
        {
            try
            {
                return await _sqlDapper.GetAsync("select * from brands");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "BrandRepository/GetAsync");
                throw ex;
            }
        }
    }
}
