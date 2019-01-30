using Microseguros.Core.Business;
using Microseguros.Core.DataAccess;
using Microseguros.Core.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microseguros.Service.Business
{
    public class BrandService : IBrandService
    {
        private readonly ILogger<BrandService> _logger;
        private readonly IBrandRepository _brandRepository;

        public BrandService(ILogger<BrandService> logger, IBrandRepository brandRepository)
        {
            _logger = logger;
            _brandRepository = brandRepository;
        }

        public async Task<IEnumerable<Brand>> GetAsync()
        {
            try
            {
                return await _brandRepository.GetAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "BrandService/GetAsync");
                throw ex;
            }
        }
    }
}
