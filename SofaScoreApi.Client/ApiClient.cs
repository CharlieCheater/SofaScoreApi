using SofaScoreApi.Client.Service.EventService;
using SofaScoreApi.Client.Service.StatisticService;
using SofaScoreApi.DAL.Models;

namespace SofaScoreApi.Client;

public class ApiClient : IApiClient
{
    private readonly ApiHelper _settings;
    private readonly HttpClient _client;
    private bool _disposed;
    public IEventContext<SportEvent> EventContext { get; init; }
    public IStatisticContext<Statistic> StatisticContext { get; init; }

    public ApiHelper Settings => _settings;
    public ApiClient()
    {
        _settings = new ApiHelper();
        _client = new HttpClient
        {
            BaseAddress = new Uri(_settings.Host)
        };
        EventContext = new EventContext(_client, Settings);
        StatisticContext = new StatisticContext(_client, Settings);
    }
    public virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _client.Dispose();
            }
            this._disposed = true;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
