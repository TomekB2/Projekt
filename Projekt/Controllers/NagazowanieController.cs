using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NagazowanieController : ControllerBase
    {
        private readonly ILogger<NagazowanieController> _logger;

        public NagazowanieController(ILogger<NagazowanieController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Nagazowanie")]
        public Nagazowanie Post(double temp, double co, double ilo)
        {
            double co2 = (co / 4) / ilo;
            double celsius = temp; ;
            double residualCo2 = 3.0378 - (0.050062 * celsius) + (0.00026555 * celsius * celsius);
            return new Nagazowanie() { wynik = co2 + residualCo2 };          
        }
    }
}