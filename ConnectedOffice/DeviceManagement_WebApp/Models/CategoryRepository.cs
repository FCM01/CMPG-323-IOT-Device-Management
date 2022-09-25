using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Models
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetMostRecentService()
        {
            return _context.Category.OrderByDescending(service => service.CategoryId).FirstOrDefault();
        }
    }
}

