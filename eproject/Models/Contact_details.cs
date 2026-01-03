using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Contact_details
    {
        [Key]
        public int contact_id { get; set; }
        public string customer_name { get; set; }
        public int address { get; set; }

        public int phone { get; set; }

        public string email { get; set; }
    }
}
