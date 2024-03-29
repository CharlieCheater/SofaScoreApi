﻿namespace SofaScoreApi.Client.Service;

public abstract class ApiContext
{
    protected readonly HttpClient _httpClient;
    protected readonly ApiHelper _apiHelper;

    protected ApiContext(HttpClient httpClient, ApiHelper apiHelper)
    {
        _httpClient = httpClient;
        _apiHelper = apiHelper;
    }
}
