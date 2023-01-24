using SofaScoreApi.DAL.Enums;
using SofaScoreApi.Infrastructure;
using System.Text.Json.Serialization;

namespace SofaScoreApi.DAL.Models;

public class Statistic
{
    public PeriodType Period { get; set; }
    public List<GroupStatistics> Groups { get; set; }
}
