using Newtonsoft.Json;
namespace SofaScoreApi.Client.Models
{
    public class Score
    {
        public int Current { get; set; } = 0;
        public int Display { get; set; } = 0;
        public int Period1 { get; set; } = 0;
        public int Period2 { get; set; } = 0;
        public int NormalTime { get; set; } = 0;
        public int Overtime { get; set; } = 0;
        public int Penalties { get; set; } = 0;
    }
}
