using DemoAPIs.ApiHello.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPIs.ApiHello.Controllers
{
    [ApiController]
    [Route("api/v1/accueil")] // monsite.com/api/v1/accueil
    public class HomeController : ControllerBase
    {

        [HttpGet]
        // monsite.com/api/v1/accueil
        public string HelloWorld()
        {
            return "Hello world";
        }

        [HttpGet("someone/{fullname}")]
        // monsite.com/api/v1/accueil/someone/:fullname
        public string HelloSomeone(string fullname)
        {
            return $"Hello {fullname}";
        }

        [HttpPost("someone")]
        // monsite.com/api/v1/accueil/someone

        /*
            {
                "firstname": "Antoine", 
                "lastname": "Dieudonne",
                "team": "Development"
            }
         */
        public string HelloSomeonePost([FromBody] SomeoneRequestRecord payload)
        {
            return $"Hello {payload.Firstname} {payload.Lastname}, you're working in team: {payload.Team}";
        }
    }
}
