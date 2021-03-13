using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave4SimpleRestService.Managers;
using Opgave4SimpleRestService.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Opgave4SimpleRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeersManager _manager = new BeersManager();

        // GET: api/<BeersController>
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BeersController>/5
        [HttpGet("{id}")]
        public Beer GetId(int id)
        {
            return _manager.GetId(id);
        }

        // POST api/<BeersController>
        [HttpPost]
        public void Post([FromBody] Beer value)
        {
            _manager.Create(value);
        }

        // PUT api/<BeersController>/5
        [HttpPut("{id}")]
        public Beer Put(int id, [FromBody] Beer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<BeersController>/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
