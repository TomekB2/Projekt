using Microsoft.AspNetCore.Mvc;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CookiesController : ControllerBase
    {
        private static readonly string message = "Ta storna korzysta z cookies";
        private static readonly string dismiss = "Ok";
        private static readonly string link = "Wiecej";
        private static readonly string href = "https://uodo.gov.pl/pl/131/224";
        private static readonly string message2 = "This website collects cookies to deliver better user experience";
        private static readonly string dismiss2 = "Ok";
        private static readonly string link2 = "More";
        private static readonly string href2 = "https://uodo.gov.pl/pl/131/224";

        private readonly ILogger<CookiesController> _logger;

        public CookiesController(ILogger<CookiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCookies")]
        public Cookies Get(string lang)
        {
            if (lang == "pl")
            {            
                return new Cookies { message = message, dismiss = dismiss, link = link, href = href };
            }
            else { return new Cookies { message = message2, dismiss = dismiss2, link = link2, href = href2 }; }
            
            
        }     
    }
}