namespace VehiculeApp.Models
{
    public class Vehicule
    {
        public int VehiculeId { get; set; }
        public String Marque { get; set; }
        public String Description { get; set; }
        public String Couleur { get; set; }
        public decimal Price { get; set; }
        public String ImageUrl { get; set; }
        public String ImageThumbnaiUrl { get; set; }
        public Boolean IsPrefrredVehicule { get; set; }
        public Boolean InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get;}
    }
}
