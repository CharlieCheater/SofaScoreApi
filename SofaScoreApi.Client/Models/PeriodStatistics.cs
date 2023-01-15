using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaScoreApi.Client.Models
{
    public class PeriodStatistics
    {
        public string Period { get; set; }
        public List<GroupStatistics> GroupStatistics { get; set; }
    }
}
