using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace scheduleApi.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public String hello()
        {
            return "hello world";
        }
    }
}