using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microseguros.Core.Business;
using Microseguros.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microseguros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;
        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        // GET: api/Device
        [HttpGet]
        public IEnumerable<Device> Get()
        {
            return _deviceService.GetAll();
        }

        // GET: api/Device/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Device
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Device/5
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
