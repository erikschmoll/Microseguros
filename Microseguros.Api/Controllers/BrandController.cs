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
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        // GET: api/Brand
        [HttpGet]
        public async Task<IEnumerable<Brand>> Get()
        {
            return await _brandService.GetAsync();
        }
    }
}
