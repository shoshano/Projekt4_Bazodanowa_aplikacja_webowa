using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Projekt4_Bazodanowa_aplikacja_webowa
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime RelaseDate { get; set; } = DateTime.Now;
        public float? Rating { get; set; }
        public int? rateCount { get; set; }
        public string? FotoUrl { get; set; }
    }
}
