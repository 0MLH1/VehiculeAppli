namespace VehiculeApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public List <Vehicule> Vehicules { get; set; }
    }
}
