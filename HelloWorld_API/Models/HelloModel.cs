using System.ComponentModel.DataAnnotations;

namespace HelloWorld_API.Models
{
    public class HelloModel
    {
        [Key]
        public int ID { get; set; }
        public string Message { get; set; }
    }
}