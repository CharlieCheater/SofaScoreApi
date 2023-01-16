namespace SofaScoreApi.Client.Service.EventService;

public interface IEventContext<T>
{
    public Task<T> GetByIdAsync(int id);
    public Task<IEnumerable<T>> GetLineAsync(DateOnly date);
    public Task<IEnumerable<T>> GetLiveAsync();
}
