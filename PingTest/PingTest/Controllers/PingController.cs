using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PingTest.Controllers
{
    public class PingController : Controller
    {
        [HttpGet]
        [Route("api/ping")]
        public IActionResult Ping()
        {
            return Ok("pong!!");
        }
    }
}