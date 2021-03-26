using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetWebApi.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class TodoController : Controller
    {

        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IActionResult Get()
        //    => Ok(new object[] { 1, 2, 3 });

        [HttpGet]
        public IActionResult GetHello(int x)
           => Ok(new object[] { x*1, x*2, x*3, x*4,"Hola", DateTime.Now });

        [HttpPost]
        public IActionResult Post([FromBody] object input)
        {
            return Created(nameof(GetHello), input);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] object input)
        {
            return Ok();
        }
    }
}