namespace petCare.Models
{
    public class Review
    {
        public Guid id { get; set; }
        public Guid customerId { get; set; }
        public Guid businessId { get; set; }
        public customerUser customerUser { get; set; }
        public BusUser busUser { get; set; }
        public int stars {  get; set; }
        public string? description {  get; set; }
        public DateTime date { get; set; }

    }
}
