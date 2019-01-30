using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microseguros.Core.Business;
using Microseguros.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microseguros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelService _modelService;
        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }
        // GET: api/Model
        [HttpGet]
        public async Task<IEnumerable<Model>> Get(int? skip, int? top, int? brandId, string pattName = null)
        {
            return await _modelService.GetAsync(new ModelFilter(skip, top, pattName, brandId));
        }
        

        // POST: api/Model
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Model/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
