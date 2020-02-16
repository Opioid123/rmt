using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rmt;

namespace rmt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RMTController : ControllerBase
    {
        private static readonly Resource Resource = new Resource(){
            Data = new Data[]
        {
            new Data(){LDAP = "thirus", Name = "Thirupuranthakam", Id = "thirus@iquadra.com", Role = "Developer"},
            new Data(){LDAP = "brandon", Name = "Brandon", Id = "brandon@iquadra.com", Role = "Scrum Master"},
            new Data(){LDAP = "randy", Name = "Randy", Id = "randy@iquadra.com", Role = "Account Manager"},
            new Data(){LDAP = "venkat", Name = "Venkat", Id = "venkat@iquadra.com", Role = "Sponsor"},
            new Data(){LDAP = "kerti", Name = "Keerti", Id = "keerti@iquadra.com", Role = "Sponsor"},
            new Data(){LDAP = "ravi", Name = "Ravi", Id = "ravi@iquadra.com", Role = "Delivery Manager"},
            new Data(){LDAP = "sreeram", Name = "Sree Ram", Id = "sreeram@iquadra.com", Role = "Developer"}
        }
        };
         private static readonly Data[] Data = new Data[]
        {
            new Data(){LDAP = "thirus", Name = "Thirupuranthakam", Id = "thirus@iquadra.com", Role = "Developer"},
            new Data(){LDAP = "brandon", Name = "Brandon", Id = "brandon@iquadra.com", Role = "Scrum Master"},
            new Data(){LDAP = "randy", Name = "Randy", Id = "randy@iquadra.com", Role = "Account Manager"},
            new Data(){LDAP = "venkat", Name = "Venkat", Id = "venkat@iquadra.com", Role = "Sponsor"},
            new Data(){LDAP = "kerti", Name = "Keerti", Id = "keerti@iquadra.com", Role = "Sponsor"},
            new Data(){LDAP = "ravi", Name = "Ravi", Id = "ravi@iquadra.com", Role = "Delivery Manager"},
            new Data(){LDAP = "sreeram", Name = "Sree Ram", Id = "sreeram@iquadra.com", Role = "Developer"}
        };

        private readonly ILogger<RMTController> _logger;

        public RMTController(ILogger<RMTController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Resource Get()
        {
            return Resource;
        }
    }
}
