namespace SofaScoreApi.Client;

public interface ISocketClient
{
    Uri Host { get; }
    void Subscribe(int id);
    void UnSubscribe(int id);
}
