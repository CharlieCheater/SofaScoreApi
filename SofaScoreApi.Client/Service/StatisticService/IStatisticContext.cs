namespace SofaScoreApi.Client.Service.StatisticService;

public interface IStatisticContext<T>
{
    Task<List<T>> GetByEventIdAsync(int id);
}
