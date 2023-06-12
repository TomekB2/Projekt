using Microsoft.AspNetCore.Mvc;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MOTDController : ControllerBase
    {
        private static readonly string message = "To jest projekt na zaliczenie Programowania w internecie";
        private static readonly string message2 = "This is project for Programowanie w internecie";

        private readonly ILogger<MOTDController> _logger;

        public MOTDController(ILogger<MOTDController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMOTD")]
        public MOTD Get(string lang)
        {
            if (lang == "pl") {
                return new MOTD { message = message };
            }
            else { return new MOTD { message = message2 }; }

        }     
    }
}