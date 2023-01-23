namespace SofaScoreApi.DAL.Models;

public class PeriodStatistics
{
    public string Period { get; set; }
    public List<GroupStatistics> GroupStatistics { get; set; }
}
