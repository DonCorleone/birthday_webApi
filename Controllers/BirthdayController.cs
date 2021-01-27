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
                {new Birthday(){ Name="Urbi", DateOfBirth=new DateTime(1984,4,22)}},
                {new Birthday(){ Name="Nani", DateOfBirth=new DateTime(1953,12,28)}},
                {new Birthday(){ Name="Chris", DateOfBirth=new DateTime(1945,4,1)}},
                {new Birthday(){ Name="Neni", DateOfBirth=new DateTime(1952,1,7)}},
                {new Birthday(){ Name="Alexis", DateOfBirth=new DateTime(2015,6,27)}},
                {new Birthday(){ Name="Hannah", DateOfBirth=new DateTime(2014,5,11)}},
                {new Birthday(){ Name="Norah", DateOfBirth=new DateTime(2012,06,30)}},
                {new Birthday(){ Name="Dean", DateOfBirth=new DateTime(1984,11,14)}},
                {new Birthday(){ Name="Nina", DateOfBirth=new DateTime(1983,1,28)}},
            };
        }
    }
}
