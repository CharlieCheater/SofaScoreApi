# SofaScoreApi
This library is designed to get soccer events from the SofaScore service and detailed information about them

## You can get the followng information
- [x] Information about soccer events
- [x] Soccer event statistics
- [x] 1x2

## Connection
```c#
using SofaScoreApi.Client;
```
## Get soccer events
```c#
ApiClient apiClient = new ApiClient();

DateOnly date = DateOnly.FromDateTime(DateTime.Now);

var line = await apiClient.EventContext.GetLineAsync(date);
var live = await apiClient.EventContext.GetLiveAsync();
```
## Get soccer event statistics
```c#
ApiClient apiClient = new ApiClient();

var eventId = 10230582; // Soccer World Cup. Japan - Croatia
var statistics = apiClient.StatisticContext.GetByEventIdAsync(eventId)
```
