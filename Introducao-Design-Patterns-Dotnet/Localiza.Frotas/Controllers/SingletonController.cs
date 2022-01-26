using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Localiza.Frotas.Infra.Singleton;

namespace Localiza.Frotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly SingletonContainer singletonContainer;

        public SingletonController(SingletonContainer singletonContainer)
        {
            this.singletonContainer = singletonContainer;
        }

        [HttpGet()]
        public IActionResult Get()
        {

            //var singleton = new Singleton.Instance;
            return Ok(singletonContainer);
        }
    }
}