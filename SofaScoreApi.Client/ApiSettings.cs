﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaScoreApi.Client
{
    public class ApiSettings
    {
        public string Host => "https://api.sofascore.com/";
        public string LiveEndpoint => Host + "api/v1/sport/football/events/live";
        public string GetLineEndpoint(DateOnly date) => Host + "api/v1/sport/football/scheduled-events/" + date.ToString("yyyy-MM-dd");
    }
}
