using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Food_Courts
    {

        [Key]
        public int Food_Id { get; set; }

        public string Description { get; set; }

        public string item_image { get; set; }


    }
}
