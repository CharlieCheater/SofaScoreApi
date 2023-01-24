using SofaScoreApi.DAL.Models;
using System.Net.Http.Json;

namespace SofaScoreApi.Client.Service.StatisticService
{
    internal class StatisticContext : ApiContext, IStatisticContext<Statistic>
    {
        public StatisticContext(HttpClient httpClient, ApiHelper apiHelper) : base(httpClient, apiHelper)
        {
        }

        public async Task<List<Statistic>> GetByEventIdAsync(int id)
        {
            var statisticsEndpoint = _apiHelper.GetStatisticsEndpoint(id);
            var result = await _httpClient.GetFromJsonAsync<Dictionary<string, List<Statistic>>>(statisticsEndpoint);
            return result["statistics"];
        }
    }
}
