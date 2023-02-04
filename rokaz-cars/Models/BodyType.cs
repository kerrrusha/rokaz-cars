using System.ComponentModel.DataAnnotations;

namespace rokaz_cars.Models
{
    public class BodyType
    {
        [Key]
        public long Id { get; set; }
        public string? name { get; set; }
    }
}
