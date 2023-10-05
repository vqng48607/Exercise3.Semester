using System.ComponentModel.DataAnnotations;

namespace QWERTY.Models
{
    public class Surfboard
    {
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }
        public double Thinkness { get; set; }
        public double Width { get; set; }


    }
}
