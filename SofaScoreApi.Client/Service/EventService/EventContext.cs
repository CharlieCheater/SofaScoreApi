using Newtonsoft.Json;
using SofaScoreApi.Client.Models;

namespace SofaScoreApi.Client.Service.EventService;

internal class EventContext : IEventContext<SportEvent>
{
    private ApiHelper _apiHelper;
    private HttpClient _httpClient;
    public EventContext(HttpClient client, ApiHelper apiHelper)
    {
        if (client is null)
            throw new ArgumentNullException(nameof(client));
        if(apiHelper is null)
            throw new ArgumentNullException(nameof(apiHelper));
        _httpClient = client;
        _apiHelper = apiHelper;
    }
    public async Task<SportEvent> GetByIdAsync(int id)
    {
        var eventEndpoint = _apiHelper.GetEventDetailEndpoint(id);
        var result = await _httpClient.GetStringAsync(eventEndpoint);
        return JsonConvert.DeserializeObject<SportEvent>(result);
    }

    public async Task<IEnumerable<SportEvent>> GetLineAsync(DateOnly date)
    {
        var lineEndpoint = _apiHelper.GetLineEndpoint(date);
        var result =  await _httpClient.GetStringAsync(lineEndpoint);
        return JsonConvert.DeserializeObject<List<SportEvent>>(result);
    }

    public async Task<IEnumerable<SportEvent>> GetLiveAsync()
    {
        var result = await _httpClient.GetStringAsync(_apiHelper.LiveEndpoint);
        return JsonConvert.DeserializeObject<List<SportEvent>>(result);
    }
}