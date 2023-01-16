using SofaScoreApi.Client.Models;
using SofaScoreApi.Client.Service.EventService;

namespace SofaScoreApi.Client;
public interface IApiClient : IDisposable
{
    IEventContext<SportEvent> EventContext { get; }
    ApiHelper Settings { get; }
}
