using VehiculeApp.Models;

namespace VehiculeApp.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }

    }
}
