using SofaScoreApi.Client.Service.EventService;
using SofaScoreApi.DAL.Models;

namespace SofaScoreApi.Client;
public interface IApiClient : IDisposable
{
    IEventContext<SportEvent> EventContext { get; }
    ApiHelper Settings { get; }
}
