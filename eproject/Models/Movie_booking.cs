using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Movie_booking
    {
        [Key]
        public int booking_id { get; set; }
        public int movie_id { get; set; }

        public string customer_name { get; set; }

        public int seats_booked { get; set; }

        public DateTime booking_date { get; set; }
    }
}
