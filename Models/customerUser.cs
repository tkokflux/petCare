namespace petCare.Models
{
    public class customerUser
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string city {  get; set; }
        public string? gender {  get; set; }
        
        public ICollection<Pet> pets { get; set; }
        public ICollection<Review> reviews { get; set; }




    }
}
