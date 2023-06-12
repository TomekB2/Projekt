using Microsoft.AspNetCore.Mvc;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectionsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Kalkulator Nagazowania", "Kalkulator Alkoholu","Korekta refraktometru"
        }; 
        
        private static readonly string[] Summaries2 = new[]
        {
        "CO2 volume calculator", "Alkohol Calculator","Refractometer Calculator"
        };

        private readonly ILogger<SectionsController> _logger;

        public SectionsController(ILogger<SectionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSections")]
        public IEnumerable<Sections> Get(string lang)
        {
            if (lang == "pl") {
                return Enumerable.Range(0, Summaries.Length).Select(index => new Sections
                {
                    id = index + 1,
                    summary = Summaries[index],
                    type = "button",
                }).ToArray();
            }
            else {
                return Enumerable.Range(0, Summaries2.Length).Select(index => new Sections
                {
                    id = index + 1,
                    summary = Summaries2[index],
                    type = "button",
                }).ToArray();
            }
            
        }     
    }
}