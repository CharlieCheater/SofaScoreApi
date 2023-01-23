﻿using SofaScoreApi.DAL.Models;
using System.Net.Http.Json;

namespace SofaScoreApi.Client.Service.EventService;

internal class EventContext : IEventContext<SportEvent>
{
    private ApiHelper _apiHelper;
    private HttpClient _httpClient;
    public EventContext(HttpClient client, ApiHelper apiHelper)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }
        if (apiHelper is null)
        {
            throw new ArgumentNullException(nameof(apiHelper));
        }

        _httpClient = client;
        _apiHelper = apiHelper;
    }
    public async Task<SportEvent> GetByIdAsync(int id)
    {
        var eventEndpoint = _apiHelper.GetEventDetailEndpoint(id);
        var result = await _httpClient.GetFromJsonAsync<Dictionary<string, SportEvent>>(eventEndpoint);
        return result["event"];
    }

    public async Task<IEnumerable<SportEvent>> GetLineAsync(DateOnly date = DateOnly.FromDateTime(DateTime.UtcNow))
    {
        var lineEndpoint = _apiHelper.GetLineEndpoint(date);
        var result = await _httpClient.GetFromJsonAsync<Dictionary<string, List<SportEvent>>>(lineEndpoint);
        return result["events"];
    }

    public async Task<IEnumerable<SportEvent>> GetLiveAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<Dictionary<string, List<SportEvent>>>(_apiHelper.LiveEndpoint);
        return result["events"];
    }
}