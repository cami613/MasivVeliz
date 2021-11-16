using System.ComponentModel.DataAnnotations;

namespace TestMasivian.DTO
{
    public class BetRequest
    {
        [Range(0, 38)]
        public int position { get; set; }
        [Range(0.5d, maximum:10000)]
        public double money { get; set; }
    }
}