namespace DeviceManagement_WebApp.Models
{
    
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetMostRecentService();
    }

}
