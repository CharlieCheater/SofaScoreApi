using SofaScoreApi.Client.Models;
using SofaScoreApi.Client.Service.EventService;

namespace SofaScoreApi.Client;

public class ApiClient : IApiClient
{
    private ApiHelper _settings;
    public IEventContext<SportEvent> EventContext => throw new NotImplementedException();

    public ApiHelper Settings => _settings;
    public ApiClient()
    {

    }

    public void Dispose()
    {
        
    }
}
