using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Album.Api;
using Album.Api.Services;

namespace Album.Api.Controllers
{
    public class HelloController : Controller
    {
        // GET: api/hello/{name}
        [HttpGet("api/[controller]")]
        public IActionResult GetHello([FromQuery] string? name)
        {
            Program.Log($"GetHello method, parameter name = {name}");
            //OPTIONAL: Create a new GreetingService object
            var greetingService = new GreetingService();

            Program.Log("Return GetHello method");
            return Ok(greetingService.GetGreeting(name));
        }

    }

}