using VehiculeApp.Models;
namespace VehiculeApp.Data
{
    public interface IVehiculeRepository
    {
        IEnumerable<Vehicule> Vehicules { get;}
        IEnumerable<Vehicule> PreferredVehicules { get;}
        Vehicule GetVehiculeById(int VehiculeId);
    }
}