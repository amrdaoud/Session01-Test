using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Car
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public required string Name { get; set; }
        public string? ChassisNumber { get; set; }
        public virtual required CarType Type {get;set;}
    }
}