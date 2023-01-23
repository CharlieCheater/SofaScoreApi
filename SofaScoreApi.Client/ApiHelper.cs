using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaScoreApi.Client
{
    public class ApiHelper
    {
        public string Host => "https://api.sofascore.com/";
        public string LiveEndpoint => "api/v1/sport/football/events/live";
        public string GetLineEndpoint(DateOnly date) => "api/v1/sport/football/scheduled-events/" + date.ToString("yyyy-MM-dd");
        public string GetEventDetailEndpoint(int id) => "api/v1/event/" + id;
    }
}
