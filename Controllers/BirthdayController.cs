using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace docker_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BirthdayController : ControllerBase
    {
        private readonly ILogger<BirthdayController> _logger;

        public BirthdayController(ILogger<BirthdayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Birthday> Get()
        {
            return new List<Birthday>(){
                {new Birthday(){ Name="Neva", DateOfBirth=new DateTime(2015,4,1)}},
                {new Birthday(){ Name="Leyla", DateOfBirth=new DateTime(2014,1,27)}},
                {new Birthday(){ Name="Natalie", DateOfBirth=new DateTime(1980,1,25)}},
                {new Birthday(){ Name="Linus", DateOfBirth=new DateTime(1977,9,6)}},
            };
        }
    }
}
