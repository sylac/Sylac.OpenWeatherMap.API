namespace Sylac.OpenWeatherMap.API.Options;

/// <summary>
/// Extensions for the <see cref="Language"/> enumeration.
/// </summary>
public static class LanguageExtensions
{
    /// <summary>
    /// Convert the language to a query string.
    /// </summary>
    /// <param name="language"> The language. </param>
    /// <returns> The query string. </returns>
    /// <exception cref="ArgumentOutOfRangeException"> Thrown when an argument is outside the range of valid values. </exception>
    public static string ToQueryString(this Language language)
    {
        return language switch
        {
            Language.Albanian => "sq",
            Language.Afrikaans => "af",
            Language.Arabic => "ar",
            Language.Azerbaijani => "az",
            Language.Basque => "eu",
            Language.Belarusian => "be",
            Language.Bulgarian => "bg",
            Language.Catalan => "ca",
            Language.ChineseSimplified => "zh_cn",
            Language.ChineseTraditional => "zh_tw",
            Language.Croatian => "hr",
            Language.Czech => "cz",
            Language.Danish => "da",
            Language.Dutch => "nl",
            Language.English => "en",
            Language.Finnish => "fi",
            Language.French => "fr",
            Language.Galician => "gl",
            Language.German => "de",
            Language.Greek => "el",
            Language.Hebrew => "he",
            Language.Hindi => "hi",
            Language.Hungarian => "hu",
            Language.Icelandic => "is",
            Language.Indonesian => "id",
            Language.Italian => "it",
            Language.Japanese => "ja",
            Language.Korean => "kr",
            Language.Kurmanji => "ku",
            Language.Latvian => "la",
            Language.Lithuanian => "lt",
            Language.Macedonian => "mk",
            Language.Norwegian => "no",
            Language.Persian => "fa",
            Language.Polish => "pl",
            Language.Portuguese => "pt",
            Language.PortugueseBrazil => "pt_br",
            Language.Romanian => "ro",
            Language.Russian => "ru",
            Language.Serbian => "sr",
            Language.Slovak => "sk",
            Language.Slovenian => "sl",
            Language.Spanish => "sp",
            Language.Swedish => "sv",
            Language.Thai => "th",
            Language.Turkish => "tr",
            Language.Ukrainian => "ua",
            Language.Vietnamese => "vi",
            Language.Zulu => "zu",
            _ => throw new ArgumentOutOfRangeException(nameof(language), language, null)
        };
    }
}
