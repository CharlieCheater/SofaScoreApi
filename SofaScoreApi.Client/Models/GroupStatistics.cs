using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaScoreApi.Client.Models
{
    public class GroupStatistics
    {
        public string GroupName { get; set; }
        public List<Statistic> Statistics { get; set; }
    }
}
