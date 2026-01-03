using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Gallery
    {
        [Key]
        public int gallery_id { get; set; }

        public string title { get; set; }

        public string image_path { get; set; }

        public string category { get; set; }
    }
}
