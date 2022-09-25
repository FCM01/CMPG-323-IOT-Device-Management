namespace DeviceManagement_WebApp.Models
{
  
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        Zone GetMostRecentService();
    }

}
