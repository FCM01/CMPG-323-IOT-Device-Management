
namespace DeviceManagement_WebApp.Models
{
   
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Device GetMostRecentService();
    }

}

