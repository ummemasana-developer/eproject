using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Movies
    {
        [Key]
        public int movie_id { get; set; }
        public string movie_name{ get; set; }
        public string language { get; set; }

        public DateTime show_time { get; set; }
        public int total_seats { get; set; }
        public int available_seats { get; set; }
        public string poster_image { get; set; }
    }
}
