using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Shop
    {
        
        [Key]
        public int Shop_Id { get; set; }

        public string Shop_Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
