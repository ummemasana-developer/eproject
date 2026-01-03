using System.ComponentModel.DataAnnotations;

namespace eproject.Models
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }

        public string messsage { get; set; }



    }
}
