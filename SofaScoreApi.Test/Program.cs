using SofaScoreApi.Client;

ApiClient apiClient = new ApiClient();
int id = 11009185;
var events = await apiClient.EventContext.GetByIdAsync(id);

Console.WriteLine("Hello, World!");
