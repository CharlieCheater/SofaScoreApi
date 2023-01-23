using System.Text.Json.Serialization;

namespace SofaScoreApi.DAL.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string ShortName { get; set; }
    public string NameCode { get; set; }
    [JsonPropertyName("national")]
    public bool IsNational { get; set; }
}
