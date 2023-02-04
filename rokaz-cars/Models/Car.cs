using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace rokaz_cars.Models
{
    public class Car
    {
        [Key]
        public long Id { get; set; }
        public string? mark { get; set; }
        public string? model { get; set; }
        public string? year { get; set; }
        public int? body_type_id { get; set; }
        public string? color { get; set; }
        public int? mileage { get; set; }
        public long? cost { get; set; }
    }
}
