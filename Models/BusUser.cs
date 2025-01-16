namespace petCare.Models
{
    public class BusUser
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int phone {  get; set; }
        public string email {  get; set; }
        public string city {  get; set; }
        public string? gender {  get; set; }
        public string occupation {  get; set; }
        public string employmentLocation {  get; set; }
     
        public ICollection<Review> reviews { get; set; }



    }
}
