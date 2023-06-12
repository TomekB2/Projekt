using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace ProjektAPI
{
    public class SectionFields
    {
        public string? key { get; set; }
        public string? type { get; set; }
        public Props? props { get; set; }
        public Expressions? expressions { get; set; }
    }
    public class Props
    {
        public string? type { get; set; }
        public string? text { get; set; }
        public string? btnType { get; set; }
        public string? onClick { get; set; }
        public int? min { get; set; }
        public string? label { get; set; }
        public string? placeholder { get; set; }
        public bool? required { get; set; }
        public bool? disabled { get; set; }
    }
    public class Expressions
    {
        public bool? disabled { get; set; }
    }
}