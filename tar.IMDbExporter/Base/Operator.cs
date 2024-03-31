using System.Text;
using tar.IMDbExporter.Gui;
using tar.IMDbScraper.Base;
using tar.IMDbScraper.Models;

namespace tar.IMDbExporter.Base {
  internal static class Operator {
    #region --- fields ----------------------------------------------------------------------------
    private static MainForm? _mainForm;
    #endregion

    #region --- get countries ---------------------------------------------------------------------
    internal static Dictionary<string, string> GetCountries() {
      return new() {
        { "AD",   "Andorra" },
        { "AE",   "United Arab Emirates" },
        { "AF",   "Afghanistan" },
        { "AG",   "Antigua and Barbuda" },
        { "AI",   "Anguilla" },
        { "AL",   "Albania" },
        { "AM",   "Armenia" },
        { "AN",   "Netherlands Antilles" },
        { "AO",   "Angola" },
        { "AQ",   "Antarctica" },
        { "AR",   "Argentina" },
        { "AS",   "American Samoa" },
        { "AT",   "Austria" },
        { "AU",   "Australia" },
        { "AW",   "Aruba" },
        { "AX",   "Åland Islands" },
        { "AZ",   "Azerbaijan" },
        { "BA",   "Bosnia and Herzegovina" },
        { "BB",   "Barbados" },
        { "BD",   "Bangladesh" },
        { "BE",   "Belgium" },
        { "BF",   "Burkina Faso" },
        { "BG",   "Bulgaria" },
        { "BH",   "Bahrain" },
        { "BI",   "Burundi" },
        { "BJ",   "Benin" },
        { "BM",   "Bermuda" },
        { "BN",   "Brunei Darussalam" },
        { "BO",   "Bolivia" },
        { "BR",   "Brazil" },
        { "BS",   "Bahamas" },
        { "BT",   "Bhutan" },
        { "BV",   "Bouvet Island" },
        { "BW",   "Botswana" },
        { "BY",   "Belarus" },
        { "BZ",   "Belize" },
        { "CA",   "Canada" },
        { "CC",   "Cocos (Keeling) Islands" },
        { "CD",   "Congo, The Democratic Republic of the" },
        { "CF",   "Central African Republic" },
        { "CG",   "Congo" },
        { "CH",   "Switzerland" },
        { "CI",   "Cote d'Ivoire" },
        { "CK",   "Cook Islands" },
        { "CL",   "Chile" },
        { "CM",   "Cameroon" },
        { "CN",   "China" },
        { "CO",   "Colombia" },
        { "CR",   "Costa Rica" },
        { "CU",   "Cuba" },
        { "CV",   "Cape Verde" },
        { "CX",   "Christmas Island" },
        { "CY",   "Cyprus" },
        { "CZ",   "Czech Republic" },
        { "DDDE", "Germany (East)" },
        { "DE",   "Germany" },
        { "DJ",   "Djibouti" },
        { "DK",   "Denmark" },
        { "DM",   "Dominica" },
        { "DO",   "Dominican Republic" },
        { "DZ",   "Algeria" },
        { "EC",   "Ecuador" },
        { "EE",   "Estonia" },
        { "EG",   "Egypt" },
        { "EH",   "Western Sahara" },
        { "ER",   "Eritrea" },
        { "ES",   "Spain" },
        { "ET",   "Ethiopia" },
        { "FI",   "Finland" },
        { "FJ",   "Fiji" },
        { "FK",   "Falkland Islands (Malvinas)" },
        { "FM",   "Micronesia, Federated States of" },
        { "FO",   "Faroe Islands" },
        { "FR",   "France" },
        { "GA",   "Gabon" },
        { "GB",   "United Kingdom (Great Britain)" },
        { "GD",   "Grenada" },
        { "GE",   "Georgia" },
        { "GF",   "French Guiana" },
        { "GG",   "Guernsey" },
        { "GH",   "Ghana" },
        { "GI",   "Gibraltar" },
        { "GL",   "Greenland" },
        { "GM",   "Gambia" },
        { "GN",   "Guinea" },
        { "GP",   "Guadeloupe" },
        { "GQ",   "Equatorial Guinea" },
        { "GR",   "Greece" },
        { "GS",   "South Georgia and the South Sandwich Islands" },
        { "GT",   "Guatemala" },
        { "GU",   "Guam" },
        { "GW",   "Guinea-Bissau" },
        { "GY",   "Guyana" },
        { "HK",   "Hong Kong" },
        { "HM",   "Heard Island and McDonald Islands" },
        { "HN",   "Honduras" },
        { "HR",   "Croatia" },
        { "HT",   "Haiti" },
        { "HU",   "Hungary" },
        { "ID",   "Indonesia" },
        { "IE",   "Ireland" },
        { "IL",   "Israel" },
        { "IM",   "Isle of Man" },
        { "IN",   "India" },
        { "IO",   "British Indian Ocean Territory" },
        { "IQ",   "Iraq" },
        { "IR",   "Iran, Islamic Republic of" },
        { "IS",   "Iceland" },
        { "IT",   "Italy" },
        { "JE",   "Jersey" },
        { "JM",   "Jamaica" },
        { "JO",   "Jordan" },
        { "JP",   "Japan" },
        { "KE",   "Kenya" },
        { "KG",   "Kyrgyzstan" },
        { "KH",   "Cambodia" },
        { "KI",   "Kiribati" },
        { "KM",   "Comoros" },
        { "KN",   "Saint Kitts and Nevis" },
        { "KP",   "Korea, Democratic People's Republic of (North)" },
        { "KR",   "Korea, Republic of (South)" },
        { "KW",   "Kuwait" },
        { "KY",   "Cayman Islands" },
        { "KZ",   "Kazakhstan" },
        { "LA",   "Lao People's Democratic Republic" },
        { "LB",   "Lebanon" },
        { "LC",   "Saint Lucia" },
        { "LI",   "Liechtenstein" },
        { "LK",   "Sri Lanka" },
        { "LR",   "Liberia" },
        { "LS",   "Lesotho" },
        { "LT",   "Lithuania" },
        { "LU",   "Luxembourg" },
        { "LV",   "Latvia" },
        { "LY",   "Libyan Arab Jamahiriya" },
        { "MA",   "Morocco" },
        { "MC",   "Monaco" },
        { "MD",   "Moldova, Republic of" },
        { "ME",   "Montenegro" },
        { "MG",   "Madagascar" },
        { "MH",   "Marshall Islands" },
        { "MK",   "North Macedonia" },
        { "ML",   "Mali" },
        { "MM",   "Myanmar" },
        { "MN",   "Mongolia" },
        { "MO",   "Macao" },
        { "MP",   "Northern Mariana Islands" },
        { "MQ",   "Martinique" },
        { "MR",   "Mauritania" },
        { "MS",   "Montserrat" },
        { "MT",   "Malta" },
        { "MU",   "Mauritius" },
        { "MV",   "Maldives" },
        { "MW",   "Malawi" },
        { "MX",   "Mexico" },
        { "MY",   "Malaysia" },
        { "MZ",   "Mozambique" },
        { "NA",   "Namibia" },
        { "NC",   "New Caledonia" },
        { "NE",   "Niger" },
        { "NF",   "Norfolk Island" },
        { "NG",   "Nigeria" },
        { "NI",   "Nicaragua" },
        { "NL",   "Netherlands" },
        { "NO",   "Norway" },
        { "NP",   "Nepal" },
        { "NR",   "Nauru" },
        { "NU",   "Niue" },
        { "NZ",   "New Zealand" },
        { "OM",   "Oman" },
        { "PA",   "Panama" },
        { "PE",   "Peru" },
        { "PF",   "French Polynesia" },
        { "PG",   "Papua New Guinea" },
        { "PH",   "Philippines" },
        { "PK",   "Pakistan" },
        { "PL",   "Poland" },
        { "PM",   "Saint Pierre and Miquelon" },
        { "PN",   "Pitcairn" },
        { "PR",   "Puerto Rico" },
        { "PS",   "Palestinian Territory, Occupied" },
        { "PT",   "Portugal" },
        { "PW",   "Palau" },
        { "PY",   "Paraguay" },
        { "QA",   "Qatar" },
        { "RE",   "Reunion" },
        { "RO",   "Romania" },
        { "RS",   "Serbia" },
        { "RU",   "Russian Federation" },
        { "RW",   "Rwanda" },
        { "SA",   "Saudi Arabia" },
        { "SB",   "Solomon Islands" },
        { "SC",   "Seychelles" },
        { "SD",   "Sudan" },
        { "SE",   "Sweden" },
        { "SG",   "Singapore" },
        { "SH",   "Saint Helena" },
        { "SI",   "Slovenia" },
        { "SJ",   "Svalbard and Jan Mayen" },
        { "SK",   "Slovakia" },
        { "SL",   "Sierra Leone" },
        { "SM",   "San Marino" },
        { "SN",   "Senegal" },
        { "SO",   "Somalia" },
        { "SR",   "Suriname" },
        { "ST",   "Sao Tome and Principe" },
        { "SV",   "El Salvador" },
        { "SY",   "Syrian Arab Republic" },
        { "SZ",   "Swaziland" },
        { "TC",   "Turks and Caicos Islands" },
        { "TD",   "Chad" },
        { "TF",   "French Southern Territories" },
        { "TG",   "Togo" },
        { "TH",   "Thailand" },
        { "TJ",   "Tajikistan" },
        { "TK",   "Tokelau" },
        { "TL",   "Timor-Leste" },
        { "TM",   "Turkmenistan" },
        { "TN",   "Tunisia" },
        { "TO",   "Tonga" },
        { "TR",   "Turkey" },
        { "TT",   "Trinidad and Tobago" },
        { "TV",   "Tuvalu" },
        { "TW",   "Taiwan, Province of China" },
        { "TZ",   "Tanzania, United Republic of" },
        { "UA",   "Ukraine" },
        { "UG",   "Uganda" },
        { "UM",   "United States Minor Outlying Islands" },
        { "US",   "United States" },
        { "UY",   "Uruguay" },
        { "UZ",   "Uzbekistan" },
        { "VA",   "Holy See (Vatican City State)" },
        { "VC",   "Saint Vincent and the Grenadines" },
        { "VE",   "Venezuela" },
        { "VG",   "British Virgin Islands" },
        { "VI",   "U.S. Virgin Islands" },
        { "VN",   "Vietnam" },
        { "VU",   "Vanuatu" },
        { "WF",   "Wallis and Futuna" },
        { "WS",   "Samoa" },
        { "XK",   "Kosovo" },
        { "XWG",  "Germany (West)" },
        { "YE",   "Yemen" },
        { "YT",   "Mayotte" },
        { "ZA",   "South Africa" },
        { "ZM",   "Zambia" },
        { "ZW",   "Zimbabwe" },
      };
    }
    #endregion
    #region --- get country name by code ----------------------------------------------------------
    internal static string? GetCountryNameByCode(string imdbCountryCode) {
      if (GetCountries().TryGetValue(imdbCountryCode, out string? imdbCountryName)) {
        return imdbCountryName;
      }
      return null;
    }
    #endregion
    #region --- imdb title: updated ---------------------------------------------------------------
    private static void IMDbTitle_Updated(IMDbTitleProgress progress) {
      _mainForm?.UpdateStatusByProgress(progress);
    }
    #endregion
    #region --- parse -----------------------------------------------------------------------------
    internal static string Parse(IMDbTitle? iMDbTitle, string countryCode) {
      if (iMDbTitle is null) {
        return string.Empty;
      }

      StringBuilder stringBuilder = new();

      #region --- alternate titles ----------------------------------------------------------------
      if (
        iMDbTitle.AlternateTitles.Any(
          x => x.Country?.ID is not null
            && x.Country.ID.Equals(countryCode, StringComparison.OrdinalIgnoreCase)
        )
      ) {
        stringBuilder.AppendLine("---Alternate Titles");

        foreach (
          var entry in iMDbTitle.AlternateTitles.Where(
            x => x.Country?.ID is not null
              && x.Country.ID.Equals(countryCode, StringComparison.OrdinalIgnoreCase)
          )
        ) {
          stringBuilder.AppendLine(
            $"{entry.Country!.ID}: {entry.Title}"
          );
        }
      }
      #endregion
      #region --- awards --------------------------------------------------------------------------
      if (iMDbTitle.Awards.Count > 0) { 
        stringBuilder.AppendLine($"---Awards");

        foreach (Award entry in iMDbTitle.Awards) {
          stringBuilder.AppendLine(
            $"{entry.Event}|{entry.IsWinner} [{entry.Name} {entry.Year}] -->{entry.Category}"
            + (entry.Persons?.Count > 0 ? $" >{string.Join(", ", entry.Persons!.Select(p => p.Name))}" : string.Empty)
          );
        }
      }
      #endregion
      #region --- companies -----------------------------------------------------------------------
      if (iMDbTitle.Companies is not null) {
        if (iMDbTitle.Companies.Production.Count > 0) {
          stringBuilder.AppendLine("---Production Companies");

          foreach (var entry in iMDbTitle.Companies.Production) {
            stringBuilder.AppendLine(entry.Name);
          }
        }

        string countryName = GetCountryNameByCode(countryCode)!; // not null due to precheck

        if (
          iMDbTitle.Companies.Distribution.Any(
            x => x.Countries.Contains(countryName)
              || x.Countries.Contains(countryName.ToLower())
          )
        ) {
          stringBuilder.AppendLine("---Distributors");
          
          foreach (
            var entry in iMDbTitle.Companies.Distribution.Where(
              x => x.Countries.Contains(countryName)
                || x.Countries.Contains(countryName.ToLower())
            )
          ) {
            stringBuilder.AppendLine(
              $"{entry.Countries[0]} - {entry.Name}"
              + (entry.Notes.Count > 0 ? $" ({entry.Notes[0]}: {entry.YearFrom})" : $": {entry.YearFrom}")
            );
          }
        }
      }
      #endregion
      #region --- connections ---------------------------------------------------------------------
      if (iMDbTitle.Connections is not null) {
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.EditedFrom));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.EditedInto));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.FeaturedIn, true));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.Features, true));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.FollowedBy));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.Follows));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.ReferencedIn));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.References));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.RemadeAs));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.RemakeOf));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.SpinOff));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.SpinOffFrom));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.SpoofedIn, true));
        stringBuilder.Append(ParseConnections(iMDbTitle.Connections.VersionOf));
      }
      #endregion
      #region --- filming locations ---------------------------------------------------------------
      if (iMDbTitle.FilmingLocations.Count > 0) {
        stringBuilder.AppendLine("---Filming Locations");

        foreach (var entry in iMDbTitle.FilmingLocations) {
          stringBuilder.AppendLine(
            $"{entry.Address}"
            + (entry.Notes.Count > 0 ? $" ({entry.Notes[0]})" : string.Empty)
          );
        }
      }
      #endregion
      #region --- goofs ---------------------------------------------------------------------------
      if (iMDbTitle.Goofs is not null) {
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.Anachronism));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.AudioVisualUnsynchronized));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.BoomMicVisible));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.CharacterError));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.Continuity));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.CrewOrEquipmentVisible));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.ErrorInGeography));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.FactualError));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.Miscellaneous));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.NotAGoof));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.RevealingMistake));
        stringBuilder.Append(ParseGoofs(iMDbTitle.Goofs.PlotHole));
      }
      #endregion
      #region --- main page -----------------------------------------------------------------------
      if (iMDbTitle.MainPage is not null) {
        stringBuilder.AppendLine("---Plot");

        stringBuilder.AppendLine(iMDbTitle.MainPage.Outline);
      }
      #endregion
      #region --- release dates -------------------------------------------------------------------
      if (iMDbTitle.ReleaseDates.Count > 0) {
        stringBuilder.AppendLine("---Release Dates");

        stringBuilder.AppendLine(
          $"{iMDbTitle.ReleaseDates[0].Country?.ID}: {iMDbTitle.ReleaseDates[0].Date!.Value:dd.MM.yyyy}"
          + (iMDbTitle.ReleaseDates[0].Notes.Count > 0 ? $" {iMDbTitle.ReleaseDates[0].Notes[0]}" : string.Empty)
        );

        foreach (
          var entry in iMDbTitle.ReleaseDates.Where(
            x => x.Date is not null
              && x.Country?.ID is not null
              && x.Country.ID.Equals(countryCode, StringComparison.OrdinalIgnoreCase)
          )
        ) {
          stringBuilder.AppendLine(
            $"{entry.Country?.ID}: {entry.Date!.Value:dd.MM.yyyy}"
            + (entry.Notes.Count > 0 ? $" {entry.Notes[0]}" : string.Empty)
          );
        }
      }
      #endregion

      return stringBuilder.ToString();
    }
    #endregion
    #region --- parse connections -----------------------------------------------------------------
    private static StringBuilder ParseConnections(Connections connections, bool withNote = false) {
      StringBuilder result = new();

      if (connections.Count > 0) {
        string[] split = connections[0].Category!.Split('_');
        StringBuilder stringBuilder = new();

        foreach (string entry in split) {
          stringBuilder.Append(
            $"{entry[..1].ToUpper()}{entry[1..]} "
          );
        }

        result.AppendLine(
          $"---Connections {stringBuilder.ToString().TrimEnd()}"
        );

        foreach (Connection entry in connections) {
          if (entry.AssociatedTitle is AssociatedTitle title) {
            result.AppendLine(
              $"{title.URL}|{title.LocalizedTitle} ({title.YearFrom}) {title.Type} {title.Series?.LocalizedTitle}"
              + (withNote && entry.Notes is not null ? $" {entry.Notes.PlainText}" : string.Empty)
            );
          }
        }
      }

      return result;
    }
    #endregion
    #region --- parse goofs -----------------------------------------------------------------------
    private static StringBuilder ParseGoofs(Goofs goofs) {
      StringBuilder result = new();

      if (goofs.Any(x => x.Text is not null)) {
        string[] split = goofs[0].Category!.Split('_');
        StringBuilder stringBuilder = new();

        foreach (string entry in split) {
          stringBuilder.Append(
            $"{entry[..1].ToUpper()}{entry[1..]} "
          );
        }

        result.AppendLine(
          $"---Goofs {stringBuilder.ToString().TrimEnd()}"
        );

        foreach (Goof entry in goofs.Where(x => x.Text is not null)) {
          result.AppendLine(entry.Text!.PlainText);
        }
      }

      return result;
    }
    #endregion
    #region --- scrape imdb title ----------------------------------------------------- (async) ---
    internal static async Task<IMDbTitle?> ScrapeIMDbTitleAsync(MainForm mainForm, string iMDbID, IMDbTitleSettings settings) {
      _mainForm = mainForm;

      if (string.IsNullOrEmpty(iMDbID)) {
        return null;
      }

      IMDbTitle result = new(iMDbID, settings);
      result.Updated += new Action<IMDbTitleProgress>(IMDbTitle_Updated);
      await result.ScrapeAsync();
      result.Updated -= new Action<IMDbTitleProgress>(IMDbTitle_Updated);

      return result;
    }
    #endregion
  }
}