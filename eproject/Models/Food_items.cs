using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Food_items
    {
        [Key]
        public int item_id { get; set; }

        public int Food_Id { get; set; }

        public string item_name { get; set; }

        public decimal price { get; set; }
        public string item_image { get; set; }

    }
}
