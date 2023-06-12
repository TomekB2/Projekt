using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlkoholController : ControllerBase
    {
        private readonly ILogger<SectionsController> _logger;

        public AlkoholController(ILogger<SectionsController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Alkohol")]
        public Alkohol Post(double gesPocza, double geskon)
        {
            return new Alkohol() { wynik = (gesPocza - geskon) / 1.938 };          
        }
    }
}