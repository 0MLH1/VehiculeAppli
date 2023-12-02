using VehiculeApp.Data.Interfaces;
using VehiculeApp.Models;

namespace VehiculeApp.Data.mocks
{
    public class MockVehiculeRepository : IVehiculeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Vehicule> Vehicules
        {
            get
            {
                return new List<Vehicule>
                {
                    new Vehicule
                    {
                        VehiculeId=1,
                        Marque="Mercedes s-class 500",
                        Description="the best",
                        Couleur="black",
                        ImageThumbnaiUrl="https://www.google.com/images/mercedes_s-class_500_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/mercedes_s-class_500_thumbnail.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=true,
                        InStock=true,
                        Price=500000
                    },
                    new Vehicule
                    {
                        VehiculeId=2,
                        Marque="Mercedes cls",
                        Description="one of the best",
                        Couleur="black",
                        ImageThumbnaiUrl="https://www.google.com/images/mercedes_cls_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/mercedes_cls_thumbnail.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=700000
                    },
                    new Vehicule
                    {
                        VehiculeId=3,
                        Marque="BMW 5 Series",
                        Description="Elegant and powerful",
                        Couleur="Blue",
                        ImageThumbnaiUrl="https://www.google.com/images/bmw_5_series_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/bmw_5_series_thumbnail.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=600000
                    },
                    new Vehicule
                    {
                        VehiculeId=4,
                        Marque="Audi Q7",
                        Description="Luxury SUV with advanced features",
                        Couleur="White",
                        ImageThumbnaiUrl="https://www.google.com/images/audi_q7_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/audi_q7_thumbnail.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=800000
                    },
                    new Vehicule
                    {
                        VehiculeId=5,
                        Marque="Toyota Camry",
                        Description="Reliable and fuel-efficient",
                        Couleur="Gray",
                        ImageThumbnaiUrl="https://www.google.com/images/toyota_camry_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/toyota_camry.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=350000
                    },
                    new Vehicule
                    {
                        VehiculeId=6,
                        Marque="Honda Accord",
                        Description="Comfortable and stylish",
                        Couleur="Red",
                        ImageThumbnaiUrl="https://www.google.com/images/honda_accord_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/honda_accord.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=400000
                    },
                    new Vehicule
                    {
                        VehiculeId=7,
                        Marque="Ford Mustang",
                        Description="Iconic American muscle car",
                        Couleur="Yellow",
                        ImageThumbnaiUrl="https://www.google.com/images/ford_mustang_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/ford_mustang.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=600000
                    },
                    new Vehicule
                    {
                        VehiculeId=8,
                        Marque="Chevrolet Camaro",
                        Description="Powerful and aggressive",
                        Couleur="Black",
                        ImageThumbnaiUrl="https://www.google.com/images/chevrolet_camaro_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/chevrolet_camaro.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=550000
                    },
                    new Vehicule
                    {
                        VehiculeId=9,
                        Marque="Nissan Altima",
                        Description="Efficient and affordable",
                        Couleur="White",
                        ImageThumbnaiUrl="https://www.google.com/images/nissan_altima_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/nissan_altima.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=380000
                    },
                    new Vehicule
                    {
                        VehiculeId=10,
                        Marque="Hyundai Sonata",
                        Description="Modern and well-equipped",
                        Couleur="Silver",
                        ImageThumbnaiUrl="https://www.google.com/images/hyundai_sonata_thumbnail.jpg",
                        ImageUrl="https://www.google.com/images/hyundai_sonata.jpg",
                        CategoryId=1,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=420000
                    },
                    new Vehicule
                    {
                        VehiculeId=11,
                        Marque="Honda CBR1000RR",
                        Description="Superbike with cutting-edge technology",
                        Couleur="Red",
                        ImageThumbnaiUrl="https://www.example.com/images/honda_cbr1000rr_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/honda_cbr1000rr.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=15000
                    },
                    new Vehicule
                    {
                        VehiculeId=12,
                        Marque="Yamaha YZF-R1",
                        Description="Iconic sportbike known for performance",
                        Couleur="Blue",
                        ImageThumbnaiUrl="https://www.example.com/images/yamaha_yzf-r1_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/yamaha_yzf-r1.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=18000
                    },
                    new Vehicule
                    {
                        VehiculeId=13,
                        Marque="Ducati Panigale V4",
                        Description="Italian superbike with exquisite design",
                        Couleur="White",
                        ImageThumbnaiUrl="https://www.example.com/images/ducati_panigale_v4_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/ducati_panigale_v4.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=22000
                    },
                    new Vehicule
                    {
                        VehiculeId=14,
                        Marque="Kawasaki Ninja ZX-10R",
                        Description="High-performance sportbike",
                        Couleur="Green",
                        ImageThumbnaiUrl="https://www.example.com/images/kawasaki_ninja_zx-10r_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/kawasaki_ninja_zx-10r.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=16000
                    },
                    new Vehicule
                    {
                        VehiculeId=15,
                        Marque="BMW S1000RR",
                        Description="German sportbike known for speed",
                        Couleur="Black",
                        ImageThumbnaiUrl="https://www.example.com/images/bmw_s1000rr_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/bmw_s1000rr.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=20000
                    },
                    new Vehicule
                    {
                        VehiculeId=16,
                        Marque="Suzuki GSX-R1000",
                        Description="Japanese sportbike with a rich history",
                        Couleur="Yellow",
                        ImageThumbnaiUrl="https://www.example.com/images/suzuki_gsx-r1000_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/suzuki_gsx-r1000.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=17000
                    },
                    new Vehicule
                    {
                        VehiculeId=17,
                        Marque="Triumph Street Triple RS",
                        Description="Naked bike with a distinctive design",
                        Couleur="Silver",
                        ImageThumbnaiUrl="https://www.example.com/images/triumph_street_triple_rs_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/triumph_street_triple_rs.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=12000
                    },
                    new Vehicule
                    {
                        VehiculeId=18,
                        Marque="Aprilia RSV4",
                        Description="Italian superbike with racing DNA",
                        Couleur="Red",
                        ImageThumbnaiUrl="https://www.example.com/images/aprilia_rsv4_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/aprilia_rsv4.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=21000
                    },
                    new Vehicule
                    {
                        VehiculeId=19,
                        Marque="Harley-Davidson Fat Boy",
                        Description="Iconic cruiser with a powerful presence",
                        Couleur="Black",
                        ImageThumbnaiUrl="https://www.example.com/images/harley-davidson_fat_boy_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/harley-davidson_fat_boy.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=25000
                    },
                    new Vehicule
                    {
                        VehiculeId=20,
                        Marque="Indian Scout",
                        Description="American cruiser with classic styling",
                        Couleur="Brown",
                        ImageThumbnaiUrl="https://www.example.com/images/indian_scout_thumbnail.jpg",
                        ImageUrl="https://www.example.com/images/indian_scout.jpg",
                        CategoryId=2,
                        IsPrefrredVehicule=false,
                        InStock=true,
                        Price=18000
                    },

                };
            }
        }
        public IEnumerable<Vehicule>  PreferredVehicules
        {
            get
            {
                return new List<Vehicule>
                {
                    new Vehicule
                    {
                        VehiculeId=1,
                        Marque="Mercedes s-class 500",
                        Description="the best",
                        Couleur="black",
                        ImageThumbnaiUrl="https://www.google.com/search?q=mercedes+prix+maroc&sca_esv=587298166&tbm=isch&sxsrf=AM9HkKlGl_IezagB-9gmGSuoG8SLy-Rk8w:1701529078769&source=lnms&sa=X&ved=2ahUKEwjinsLigfGCAxXhy7sIHciuBc0Q_AUoAXoECAEQAw&biw=1280&bih=603&dpr=1.5#imgrc=8dF2TKbENMYUnM",
                        ImageUrl="https://www.google.com/search?q=mercedes+prix+maroc&sca_esv=587298166&tbm=isch&sxsrf=AM9HkKlGl_IezagB-9gmGSuoG8SLy-Rk8w:1701529078769&source=lnms&sa=X&ved=2ahUKEwjinsLigfGCAxXhy7sIHciuBc0Q_AUoAXoECAEQAw&biw=1280&bih=603&dpr=1.5#imgrc=8dF2TKbENMYUnM",
                        CategoryId=1,
                        IsPrefrredVehicule=true,
                        InStock=true,
                        Price=500000
                    }
                };
            }
        }
        public Vehicule GetVehiculeById(int VehiculeId)
        {
            throw new NotImplementedException();
        }
    }
}

