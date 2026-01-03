using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class shop_items
    {
        [Key]
        public int item_id { get; set; }
        public int Shop_Id { get; set; }

        public string item_name { get; set; }

        public decimal price { get; set; }

        public string item_image { get; set; }

    }
}
