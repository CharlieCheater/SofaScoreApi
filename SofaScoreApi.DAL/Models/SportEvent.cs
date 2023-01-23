using System.Text.Json.Serialization;

namespace SofaScoreApi.DAL.Models;

public class SportEvent
{
    public int Id { get; set; }
    public int WinnerCode { get; set; }
    public string CustomId { get; set; }
    public string Slug { get; set; }
    public string LastPeriod { get; set; }
    public long StartTimestamp { get; set; }
    public bool FinalResultOnly { get; set; }
    public bool HasEventPlayerStatistics { get; set; }
    public bool HasEventPlayerHeatMap { get; set; }
    public bool HasGlobalHighlights { get; set; }
    [JsonPropertyName("homeTeam")]
    public Team Home { get; set; }
    [JsonPropertyName("awayTeam")]
    public Team Away { get; set; }

    public Score HomeScore { get; set; }
    public Score AwayScore { get; set; }

}
