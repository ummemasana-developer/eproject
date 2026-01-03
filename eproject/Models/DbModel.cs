using Microsoft.EntityFrameworkCore;

namespace eproject.Models
{
    public class DbModel:DbContext
    {
        public DbModel(DbContextOptions opt) : base(opt)
        { }
        public DbSet<admin> admins_table { get; set; }


        public DbSet<Contact_details> contact_details_table { get; set; }

        public DbSet<Feedback> feedback_table { get; set; }

        public DbSet<Food_Courts> food_courts_table { get; set; }

        public DbSet<Food_items> food_items_table { get; set; }

        public DbSet<Gallery> gallery_table { get; set; }

        public DbSet<Mall_Details> mall_details_table { get; set; }

        public DbSet<Movie_booking> movie_booking_table { get; set; }

        public DbSet<Movies> movies_table { get; set; }


        public DbSet<Shop> shop_table { get; set; }

        public DbSet<shop_items> shop_items_table { get; set; }



    }
}
