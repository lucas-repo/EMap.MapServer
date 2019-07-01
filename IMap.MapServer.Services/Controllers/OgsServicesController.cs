using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMap.MapServer.Services.Models;

namespace EMap.MapServer.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgsServicesController : ControllerBase
    {
        ConfigContext _configContext;
        public OgsServicesController(ConfigContext configContext)
        {
            _configContext = configContext;
        }
        // GET: api/OgsServices
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OgsServices/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OgsServices
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OgsServices/5
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
