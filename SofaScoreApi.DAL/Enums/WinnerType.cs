using System.Text.Json.Serialization;

namespace SofaScoreApi.DAL.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WinnerType
{
    None = 0,
    Home = 1,
    Away = 2,
    Draw = 3
}
