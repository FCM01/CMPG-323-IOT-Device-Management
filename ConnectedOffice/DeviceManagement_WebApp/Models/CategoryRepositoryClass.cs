using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Models
{
    public class CategoryRepositoryClass
    {
    }
}
public class CategoryRepositoryClass : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepositoryClass(ConnectedOfficeContext context) : base(context)
    {
    }

    public Category GetMostRecentService()
    {
        return _context.Category.OrderByDescending(service => service.CategoryId).FirstOrDefault();
    }
}
