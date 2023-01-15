using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaScoreApi.Client.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string ShortName { get; set; }
        public string NameCode { get; set; }
        public bool National { get; set; }
        public char Gender { get; set; }
    }
}
