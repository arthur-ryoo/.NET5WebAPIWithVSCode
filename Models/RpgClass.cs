using System.Text.Json.Serialization;

namespace _NETWebAPIWithEF.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}
