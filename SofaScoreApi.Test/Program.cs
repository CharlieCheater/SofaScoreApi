using SofaScoreApi.Client;

ApiClient apiClient = new ApiClient();

var eventId = 10230582;
var soccer = await apiClient.EventContext.GetByIdAsync(eventId);
var statistics = await apiClient.StatisticContext.GetByEventIdAsync(eventId);
var line = await apiClient.EventContext.GetLineAsync(DateOnly.FromDateTime(DateTime.UtcNow));

foreach (var sportEvent in line)
{
    Console.WriteLine($"{sportEvent.Home.Name} - {sportEvent.Away.Name}");
    Console.WriteLine($"{sportEvent.HomeScore.NormalTime} - {sportEvent.AwayScore.NormalTime}\n");
}