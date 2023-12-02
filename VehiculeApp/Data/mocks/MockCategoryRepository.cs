using VehiculeApp.Data.Interfaces;
using VehiculeApp.Models;

namespace VehiculeApp.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName="Cars" , Description=" All Cars Models" , CategoryId=1 },
                    new Category {CategoryName ="Motors" , Description="All Motors Models", CategoryId=2}
                };
            }
        }

    }
}
