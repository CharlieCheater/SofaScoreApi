namespace SofaScoreApi.Client.Service.EventService;

public interface IEventContext<T>
{
    public T GetAll();
    public T GetById(int id);
    public T GetLine(DateOnly date);
    public T GetLive();
}
