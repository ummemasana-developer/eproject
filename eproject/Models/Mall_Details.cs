using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Mall_Details
    {

        [Key]
        public int Mall_id { get; set; }

        public string Mall_name { get; set; }

        public string Description { get; set; }

        public string mall_image { get; set; }



    }
}
