using Newtonsoft.Json;
namespace SofaScoreApi.Client.Models
{
    public class Score
    {
        public int Current { get; set; }
        public int Display { get; set; }
        public int Period1 { get; set; }
        public int Period2 { get; set; }
        public int NormalTime { get; set; }
        public int Overtime { get; set; }
        public int Penalties { get; set; }
    }
}
