using Microsoft.AspNetCore.Mvc;

namespace ProjektAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectionFieldController : ControllerBase
    {
        private readonly ILogger<SectionFieldController> _logger;

        public SectionFieldController(ILogger<SectionFieldController> logger)
        {
            _logger = logger;
        }

        private static readonly string labelilo = "Iloœæ pakowanego piwa";
        private static readonly string labelilo2 = "Volume of beer";
        private static readonly string placeholderilo = "Podaj Iloœæ pakowanego piwa"; 
        private static readonly string placeholderilo2 = "Enter volume of beer";
        private static readonly string labelco = "Poziom CO2";
        private static readonly string labelco2 = "Level of CO2";
        private static readonly string placeholderco = "Podaj Poziom CO2";
        private static readonly string placeholderco2 = "Enter CO2 level";
        private static readonly string labeltemp = "Temp. piwa";
        private static readonly string labeltemp2 = "Beer temp";
        private static readonly string placeholdertemp = "Podaj Temp. piwa";
        private static readonly string placeholdertemp2 = "Enter Beer temp";
        private static readonly string text = "Wynik";
        private static readonly string text2 = "Result";
        private static readonly string label = "Wynik";
        private static readonly string label2 = "Result";
        private static readonly string labelden = "Gestosc poczatkowa";
        private static readonly string labelden2 = "OG";
        private static readonly string placeholderden = "Podaj gestosc poczatkowa";
        private static readonly string placeholderden2 = "Enter OG";
        private static readonly string labelfden = "Gestosc koncowa";
        private static readonly string labelfden2 = "FG";
        private static readonly string placeholderfden = "Podaj gestosc koncowa";
        private static readonly string placeholderfden2 = "Enter FG";
        private static readonly string labelmden = "Zmierzona Gestosc";
        private static readonly string labelmden2 = "Mesured gravity";
        private static readonly string placeholdermden = "Podaj zmierzona Gestosc";
        private static readonly string placeholdermden2 = "Enter mesured gravity";

        private SectionFields[] SectionFieldChoose(int id, string lang)
        {
            if (lang == "pl") {
                if (id == 1)
                {
                    SectionFields field1 = new SectionFields()
                    {
                        type = "input",
                        key = "ilPiwa",
                        props = new Props() { type = "number", min = 0, label = labelilo, placeholder = placeholderilo, required = true }
                    };
                    SectionFields field2 = new SectionFields()
                    {
                        type = "input",
                        key = "pozCO",
                        props = new Props() { type = "number", min = 0, label = labelco, placeholder = placeholderco, required = true }
                    };
                    SectionFields field3 = new SectionFields()
                    {
                        type = "input",
                        key = "temppiwa",
                        props = new Props() { type = "number", min = 0, label = labeltemp, placeholder = placeholdertemp, required = true }
                    };
                    SectionFields field4 = new SectionFields()
                    {
                        type = "input",
                        key = "wynik",
                        props = new Props() { type = "number", text = text, label = label, required = false, disabled = true },
                    };
                    SectionFields[] fields = new SectionFields[] { field1, field2, field3, field4 };
                    return fields;
                }
                if (id == 2)
                {
                    SectionFields field1 = new SectionFields()
                    {
                        type = "input",
                        key = "gesPocza",
                        props = new Props() { type = "number", min = 0, label = labelden, placeholder = placeholderden, required = true }
                    };
                    SectionFields field2 = new SectionFields()
                    {
                        type = "input",
                        key = "geskon",
                        props = new Props() { type = "number", min = 0, label = labelfden, placeholder = placeholderfden, required = true }
                    };
                    SectionFields field4 = new SectionFields()
                    {
                        type = "input",
                        key = "wynik",
                        props = new Props() { type = "number", text = text, label = label, required = false, disabled = true },
                    };
                    SectionFields[] fields = new SectionFields[] { field1, field2, field4 };
                    return fields;
                }
                if (id == 3)
                {
                    SectionFields field1 = new SectionFields()
                    {
                        type = "input",
                        key = "gesPocz",
                        props = new Props() { type = "number", min = 0, label = labelden, placeholder = placeholderden, required = true }
                    };
                    SectionFields field2 = new SectionFields()
                    {
                        type = "input",
                        key = "zmigest",
                        props = new Props() { type = "number", min = 0, label = labelmden, placeholder = placeholdermden, required = true }
                    };
                    SectionFields field4 = new SectionFields()
                    {
                        type = "input",
                        key = "wynik",
                        props = new Props() { type = "number", text = text, label = label, required = false, disabled = true },
                    };
                    SectionFields[] fields = new SectionFields[] { field1, field2, field4 };
                    return fields;
                }
                else return null;
            }
            else
            {
                if (id == 1)
                {
                    SectionFields field1 = new SectionFields()
                    {
                        type = "input",
                        key = "ilPiwa",
                        props = new Props() { type = "number", min = 0, label = labelilo2, placeholder = placeholderilo2, required = true }
                    };
                    SectionFields field2 = new SectionFields()
                    {
                        type = "input",
                        key = "pozCO",
                        props = new Props() { type = "number", min = 0, label = labelco2, placeholder = placeholderco2, required = true }
                    };
                    SectionFields field3 = new SectionFields()
                    {
                        type = "input",
                        key = "temppiwa",
                        props = new Props() { type = "number", min = 0, label = labeltemp2, placeholder = placeholdertemp2, required = true }
                    };
                    SectionFields field4 = new SectionFields()
                    {
                        type = "input",
                        key = "wynik",
                        props = new Props() { type = "number", text = text2, label = label2, required = false, disabled = true },
                    };
                    SectionFields[] fields = new SectionFields[] { field1, field2, field3, field4 };
                    return fields;
                }
                if (id == 2)
                {
                    SectionFields field1 = new SectionFields()
                    {
                        type = "input",
                        key = "gesPocza",
                        props = new Props() { type = "number", min = 0, label = labelden2, placeholder = placeholderden2, required = true }
                    };
                    SectionFields field2 = new SectionFields()
                    {
                        type = "input",
                        key = "geskon",
                        props = new Props() { type = "number", min = 0, label = labelfden2, placeholder = placeholderfden2, required = true }
                    };
                    SectionFields field4 = new SectionFields()
                    {
                        type = "input",
                        key = "wynik",
                        props = new Props() { type = "number", text = text2, label = label2, required = false, disabled = true },
                    };
                    SectionFields[] fields = new SectionFields[] { field1, field2, field4 };
                    return fields;
                }
                if (id == 3)
                {
                    SectionFields field1 = new SectionFields()
                    {
                        type = "input",
                        key = "gesPocz",
                        props = new Props() { type = "number", min = 0, label = labelden2, placeholder = placeholderden2, required = true }
                    };
                    SectionFields field2 = new SectionFields()
                    {
                        type = "input",
                        key = "zmigest",
                        props = new Props() { type = "number", min = 0, label = labelmden2, placeholder = placeholdermden2, required = true }
                    };
                    SectionFields field4 = new SectionFields()
                    {
                        type = "input",
                        key = "wynik",
                        props = new Props() { type = "number", text = text2, label = label2, required = false, disabled = true },
                    };
                    SectionFields[] fields = new SectionFields[] { field1, field2, field4 };
                    return fields;
                }
                else return null;
            }
        }

        [HttpGet(Name = "GetSectionFields")]
        public SectionFields[] Get(int id, string lang)
        {
            return SectionFieldChoose(id, lang);
        }

    }
}