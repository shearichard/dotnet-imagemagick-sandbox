using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// A class loosely based on the ISO 3166 standard
    /// for identifying Countries
    /// </summary>
    public class Country
    {
        public string Name_Short { get; set; }
        public string Code_Alpha_2 { get; set; }

        public Country() { }

        public Country( string alpha2Code , string shortName )
        {
            this.Name_Short = shortName;
            this.Code_Alpha_2 = alpha2Code;
        }
    }
}