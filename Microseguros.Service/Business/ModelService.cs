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
    public class ModelService : IModelService
    {
        private readonly IModelRepository _modelRepository;
        private readonly ILogger<ModelService> _logger;
        public ModelService(ILogger<ModelService> logger, IModelRepository modelRepository)
        {
            _logger = logger;
            _modelRepository = modelRepository;
        }
        public async Task<IEnumerable<Model>> GetAsync(ModelFilter modelFilter)
        {
            try
            {
                return await _modelRepository.GetAsync(modelFilter);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $@"Error in Models params 
                                            Skip={modelFilter.Skip} 
                                            Top={modelFilter.Top} 
                                            Patt={modelFilter.Patt} 
                                            BrandId={modelFilter.BrandId}");
                throw ex;
            }
        }
    }
}
