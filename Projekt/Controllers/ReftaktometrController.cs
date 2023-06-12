using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefraktometrController : ControllerBase
    {
        private readonly ILogger<RefraktometrController> _logger;

        public RefraktometrController(ILogger<RefraktometrController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Refraktometr")]
        public Refraktometr Post(double gesPocza, double gezmie)
        {
            return new Refraktometr() { wynik = gesPocza/ gezmie / 0.64 };          
        }
    }
}