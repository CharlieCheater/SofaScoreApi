namespace SofaScoreApi.Client.Service.EventService;

public interface IEventContext<T>
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetLineAsync(DateOnly date);
    Task<IEnumerable<T>> GetLiveAsync();
}
