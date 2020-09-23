using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CountryController : ApiController
    {
        List<Country> Countries { get; set; }

        CountryController() {

            this.Countries = new List<Country>();
            Countries.Add(new Country("AD" , "Andorra"));
            Countries.Add(new Country("AE" ,"United Arab Emirates"));
            Countries.Add(new Country("AF" , "Afghanistan"));
            Countries.Add(new Country("AG" ,"Antigua and Barbuda"));
            Countries.Add(new Country("AI" ,"Anguilla"));
            Countries.Add(new Country("AL" , "Albania"));
            Countries.Add(new Country("AM" ,"Armenia"));
            Countries.Add(new Country("AO" , "Angola"));
            Countries.Add(new Country("AQ" ,"Antarctica"));
            Countries.Add(new Country("AR" , "Argentina"));
            Countries.Add(new Country("AS" ,"American Samoa"));
            Countries.Add(new Country("AT" , "Austria"));
            Countries.Add(new Country("AU" ,"Australia"));
            Countries.Add(new Country("AW" , "Aruba"));
            Countries.Add(new Country("AX" ,"Åland Islands"));
            Countries.Add(new Country("AZ" ,"Azerbaijan"));
            Countries.Add(new Country("BA" , "Bosnia and Herzegovina"));
            Countries.Add(new Country("BB" ,"Barbados"));
            Countries.Add(new Country("BD" , "Bangladesh"));
            Countries.Add(new Country("BE" ,"Belgium"));
            Countries.Add(new Country("BF" , "Burkina Faso"));
            Countries.Add(new Country("BG" ,"Bulgaria"));
            Countries.Add(new Country("BH" , "Bahrain"));
            Countries.Add(new Country("BI" ,"Burundi"));
            Countries.Add(new Country("BJ" , "Benin"));
            Countries.Add(new Country("BL" ,"Saint Barthélemy"));
            Countries.Add(new Country("BM" ,"Bermuda"));
            Countries.Add(new Country("BN" , "Brunei Darussalam"));
            Countries.Add(new Country("BO" ,"Bolivia"));
            Countries.Add(new Country("BQ" , "Caribbean Netherlands "));
            Countries.Add(new Country("BR" , "Brazil"));
            Countries.Add(new Country("BS" ,"Bahamas"));
            Countries.Add(new Country("BT" , "Bhutan"));
            Countries.Add(new Country("BV" ,"Bouvet Island"));
            Countries.Add(new Country("BW" , "Botswana"));
            Countries.Add(new Country("BY" ,"Belarus"));
            Countries.Add(new Country("BZ" , "Belize"));
            Countries.Add(new Country("CA" ,"Canada"));
            Countries.Add(new Country("CC" ,"Cocos(Keeling) Islands"));
            Countries.Add(new Country("CF" , "Central African Republic"));
            Countries.Add(new Country("CG" , "Congo"));
            Countries.Add(new Country("CH" , "Switzerland"));
            Countries.Add(new Country("CK" , "Cook Islands"));
            Countries.Add(new Country("CL" , "Chile"));
            Countries.Add(new Country("CM" , "Cameroon"));
            Countries.Add(new Country("CN" , "China"));
            Countries.Add(new Country("CO" , "Colombia"));
            Countries.Add(new Country("CR" , "Costa Rica"));
            Countries.Add(new Country("CU" , "Cuba"));
            Countries.Add(new Country("CV" , "Cape Verde"));
            Countries.Add(new Country("CW" , "Curaçao"));
            Countries.Add(new Country("CX" , "Christmas Island"));
            Countries.Add(new Country("CY" , "Cyprus"));
            Countries.Add(new Country("CZ" , "Czech Republic"));
            Countries.Add(new Country("DE" , "Germany"));
            Countries.Add(new Country("DJ" , "Djibouti"));
            Countries.Add(new Country("DK" , "Denmark"));
            Countries.Add(new Country("DM" , "Dominica"));
            Countries.Add(new Country("DO" , "Dominican Republic"));
            Countries.Add(new Country("DZ" , "Algeria"));
            Countries.Add(new Country("EC" , "Ecuador"));
            Countries.Add(new Country("EE" , "Estonia"));
            Countries.Add(new Country("EG" , "Egypt"));
            Countries.Add(new Country("EH" , "Western Sahara"));
            Countries.Add(new Country("ER" , "Eritrea"));
            Countries.Add(new Country("ES" , "Spain"));
            Countries.Add(new Country("ET" , "Ethiopia"));
            Countries.Add(new Country("FI" , "Finland"));
            Countries.Add(new Country("FJ" , "Fiji"));
            Countries.Add(new Country("FK" , "Falkland Islands"));
            Countries.Add(new Country("FO" , "Faroe Islands"));
            Countries.Add(new Country("FR" , "France"));
            Countries.Add(new Country("GA" , "Gabon"));
            Countries.Add(new Country("GB" , "United Kingdom"));
            Countries.Add(new Country("GD" , "Grenada"));
            Countries.Add(new Country("GE" , "Georgia"));
            Countries.Add(new Country("GF" , "French Guiana"));
            Countries.Add(new Country("GG" , "Guernsey"));
            Countries.Add(new Country("GH" , "Ghana"));
            Countries.Add(new Country("GI" , "Gibraltar"));
            Countries.Add(new Country("GL" , "Greenland"));
            Countries.Add(new Country("GM" , "Gambia"));
            Countries.Add(new Country("GN" , "Guinea"));
            Countries.Add(new Country("GP" , "Guadeloupe"));
            Countries.Add(new Country("GQ" , "Equatorial Guinea"));
            Countries.Add(new Country("GR" , "Greece"));
            Countries.Add(new Country("GS" , "South Georgia and the South Sandwich Islands"));
            Countries.Add(new Country("GT" , "Guatemala"));
            Countries.Add(new Country("GU" , "Guam"));
            Countries.Add(new Country("GW" , "Guinea - Bissau"));
            Countries.Add(new Country("GY" , "Guyana"));
            Countries.Add(new Country("HK" , "Hong Kong"));
            Countries.Add(new Country("HM" , "Heard and McDonald Islands"));
            Countries.Add(new Country("HN" , "Honduras"));
            Countries.Add(new Country("HR" , "Croatia"));
            Countries.Add(new Country("HT" , "Haiti"));
            Countries.Add(new Country("HU" , "Hungary"));
            Countries.Add(new Country("ID" , "Indonesia"));
            Countries.Add(new Country("IE" , "Ireland"));
            Countries.Add(new Country("IL" , "Israel"));
            Countries.Add(new Country("IM" , "Isle of Man"));
            Countries.Add(new Country("IN" , "India"));
            Countries.Add(new Country("IO" , "British Indian Ocean Territory"));
            Countries.Add(new Country("IQ" , "Iraq"));
            Countries.Add(new Country("IR" , "Iran"));
            Countries.Add(new Country("IS" , "Iceland"));
            Countries.Add(new Country("IT" , "Italy"));
            Countries.Add(new Country("JE" , "Jersey"));
            Countries.Add(new Country("JM" , "Jamaica"));
            Countries.Add(new Country("JO" , "Jordan"));
            Countries.Add(new Country("JP" , "Japan"));
            Countries.Add(new Country("KE" , "Kenya"));
            Countries.Add(new Country("KG" , "Kyrgyzstan"));
            Countries.Add(new Country("KH" , "Cambodia"));
            Countries.Add(new Country("KI" , "Kiribati"));
            Countries.Add(new Country("KM" , "Comoros"));
            Countries.Add(new Country("KN" , "Saint Kitts and Nevis"));
            Countries.Add(new Country("KP" , "North Korea"));
            Countries.Add(new Country("KR" , "South Korea"));
            Countries.Add(new Country("KW" , "Kuwait"));
            Countries.Add(new Country("KY" , "Cayman Islands"));
            Countries.Add(new Country("KZ" , "Kazakhstan"));
            Countries.Add(new Country("LA" , "Lao People's Democratic Republic"));
            Countries.Add(new Country("LB" , "Lebanon"));
            Countries.Add(new Country("LC" , "Saint Lucia"));
            Countries.Add(new Country("LI" , "Liechtenstein"));
            Countries.Add(new Country("LK" , "Sri Lanka"));
            Countries.Add(new Country("LR" , "Liberia"));
            Countries.Add(new Country("LS" , "Lesotho"));
            Countries.Add(new Country("LT" , "Lithuania"));
            Countries.Add(new Country("LU" , "Luxembourg"));
            Countries.Add(new Country("LV" , "Latvia"));
            Countries.Add(new Country("LY" , "Libya"));
            Countries.Add(new Country("MA" , "Morocco"));
            Countries.Add(new Country("MC" , "Monaco"));
            Countries.Add(new Country("MD" , "Moldova"));
            Countries.Add(new Country("ME" , "Montenegro"));
            Countries.Add(new Country("MF" , "Saint - Martin(France)"));
            Countries.Add(new Country("MG" , "Madagascar"));
            Countries.Add(new Country("MH" , "Marshall Islands"));
            Countries.Add(new Country("MK" , "Macedonia"));
            Countries.Add(new Country("ML" , "Mali"));
            Countries.Add(new Country("MM" , "Myanmar"));
            Countries.Add(new Country("MN" , "Mongolia"));
            Countries.Add(new Country("MO" , "Macau"));
            Countries.Add(new Country("MP" , "Northern Mariana Islands"));
            Countries.Add(new Country("MQ" , "Martinique"));
            Countries.Add(new Country("MR" , "Mauritania"));
            Countries.Add(new Country("MS" , "Montserrat"));
            Countries.Add(new Country("MT" , "Malta"));
            Countries.Add(new Country("MU" , "Mauritius"));
            Countries.Add(new Country("MV" , "Maldives"));
            Countries.Add(new Country("MW" , "Malawi"));
            Countries.Add(new Country("MX" , "Mexico"));
            Countries.Add(new Country("MY" , "Malaysia"));
            Countries.Add(new Country("MZ" , "Mozambique"));
            Countries.Add(new Country("NA" , "Namibia"));
            Countries.Add(new Country("NC" , "New Caledonia"));
            Countries.Add(new Country("NE" , "Niger"));
            Countries.Add(new Country("NF" , "Norfolk Island"));
            Countries.Add(new Country("NG" , "Nigeria"));
            Countries.Add(new Country("NI" , "Nicaragua"));
            Countries.Add(new Country("NL" , "The Netherlands"));
            Countries.Add(new Country("NO" , "Norway"));
            Countries.Add(new Country("NP" , "Nepal"));
            Countries.Add(new Country("NR" , "Nauru"));
            Countries.Add(new Country("NU" , "Niue"));
            Countries.Add(new Country("NZ" , "New Zealand"));
            Countries.Add(new Country("OM" , "Oman"));
            Countries.Add(new Country("PA" , "Panama"));
            Countries.Add(new Country("PE" , "Peru"));
            Countries.Add(new Country("PF" , "French Polynesia"));
            Countries.Add(new Country("PG" , "Papua New Guinea"));
            Countries.Add(new Country("PH" , "Philippines"));
            Countries.Add(new Country("PK" , "Pakistan"));
            Countries.Add(new Country("PL" , "Poland"));
            Countries.Add(new Country("PM" , "St.Pierre and Miquelon"));
            Countries.Add(new Country("PN" , "Pitcairn"));
            Countries.Add(new Country("PR" , "Puerto Rico"));
            Countries.Add(new Country("PT" , "Portugal"));
            Countries.Add(new Country("PW" , "Palau"));
            Countries.Add(new Country("PY" , "Paraguay"));
            Countries.Add(new Country("QA" , "Qatar"));
            Countries.Add(new Country("RE" , "Réunion"));
            Countries.Add(new Country("RO" , "Romania"));
            Countries.Add(new Country("RS" , "Serbia"));
            Countries.Add(new Country("RU" , "Russian Federation"));
            Countries.Add(new Country("RW" , "Rwanda"));
            Countries.Add(new Country("SA" , "Saudi Arabia"));
            Countries.Add(new Country("SB" , "Solomon Islands"));
            Countries.Add(new Country("SC" , "Seychelles"));
            Countries.Add(new Country("SD" , "Sudan"));
            Countries.Add(new Country("SE" , "Sweden"));
            Countries.Add(new Country("SG" , "Singapore"));
            Countries.Add(new Country("SH" , "Saint Helena"));
            Countries.Add(new Country("SI" , "Slovenia"));
            Countries.Add(new Country("SJ" , "Svalbard and Jan Mayen Islands"));
            Countries.Add(new Country("SK" , "Slovakia"));
            Countries.Add(new Country("SL" , "Sierra Leone"));
            Countries.Add(new Country("SM" , "San Marino"));
            Countries.Add(new Country("SN" , "Senegal"));
            Countries.Add(new Country("SO" , "Somalia"));
            Countries.Add(new Country("SR" , "Suriname"));
            Countries.Add(new Country("SS" , "South Sudan"));
            Countries.Add(new Country("ST" , "Sao Tome and Principe"));
            Countries.Add(new Country("SV" , "El Salvador"));
            Countries.Add(new Country("SX" , "Sint Maarten(Dutch part)"));
            Countries.Add(new Country("SY" , "Syria"));
            Countries.Add(new Country("SZ" , "Swaziland"));
            Countries.Add(new Country("TC" , "Turks and Caicos Islands"));
            Countries.Add(new Country("TD" , "Chad"));
            Countries.Add(new Country("TF" , "French Southern Territories"));
            Countries.Add(new Country("TG" , "Togo"));
            Countries.Add(new Country("TH" , "Thailand"));
            Countries.Add(new Country("TJ" , "Tajikistan"));
            Countries.Add(new Country("TK" , "Tokelau"));
            Countries.Add(new Country("TL" , "Timor - Leste"));
            Countries.Add(new Country("TM" , "Turkmenistan"));
            Countries.Add(new Country("TN" , "Tunisia"));
            Countries.Add(new Country("TO" , "Tonga"));
            Countries.Add(new Country("TR" , "Turkey"));
            Countries.Add(new Country("TT" , "Trinidad and Tobago"));
            Countries.Add(new Country("TV" , "Tuvalu"));
            Countries.Add(new Country("TW" , "Taiwan"));
            Countries.Add(new Country("TZ" , "Tanzania"));
            Countries.Add(new Country("UA" , "Ukraine"));
            Countries.Add(new Country("UG" , "Uganda"));
            Countries.Add(new Country("UM" , "United States Minor Outlying Islands"));
            Countries.Add(new Country("US" , "United States"));
            Countries.Add(new Country("UY" , "Uruguay"));
            Countries.Add(new Country("UZ" , "Uzbekistan"));
            Countries.Add(new Country("VA" , "Vatican"));
            Countries.Add(new Country("VC" , "Saint Vincent and the Grenadines"));
            Countries.Add(new Country("VE" , "Venezuela"));
            Countries.Add(new Country("VG" , "Virgin Islands(British)"));
            Countries.Add(new Country("VI" , "Virgin Islands(U.S.)"));
            Countries.Add(new Country("VN" , "Vietnam"));
            Countries.Add(new Country("VU" , "Vanuatu"));
            Countries.Add(new Country("WF" , "Wallis and Futuna Islands"));
            Countries.Add(new Country("WS" , "Samoa"));
            Countries.Add(new Country("YE" , "Yemen"));
            Countries.Add(new Country("YT" , "Mayotte"));
            Countries.Add(new Country("ZA" , "South Africa"));
            Countries.Add(new Country("ZM" , "Zambia"));
            Countries.Add(new Country("ZW" , "Zimbabwe"));

        }

        // GET: api/country
        [System.Web.Http.Route("api/country")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse((HttpStatusCode)200, this.Countries);
        }
        // GET: api/country
        [System.Web.Http.Route("api/country/{code}")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get(string code)
        {
            List<Country> lstOut = new List<Country>();

            foreach (Country c in this.Countries)
            {
                if (code == c.Code_Alpha_2)
                {
                    lstOut.Add(new Country(c.Name_Short, c.Code_Alpha_2));
                    break;
                }
            }
            return Request.CreateResponse((HttpStatusCode)200, lstOut);
        }
    }
}
