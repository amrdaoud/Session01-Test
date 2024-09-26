namespace api.Models
{
    public class CarType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}