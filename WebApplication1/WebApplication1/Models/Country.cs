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
        string Name_Short { get; set; }
        string Code_Alpha_2 { get; set; }

        public Country() { }

        public Country(string shortName, string alpha2Code)
        {
            this.Name_Short = shortName;
            this.Code_Alpha_2 = alpha2Code;
        }
    }
}