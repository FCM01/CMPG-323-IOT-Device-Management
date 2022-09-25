using DeviceManagement_WebApp.Data;
using System.Linq;

namespace DeviceManagement_WebApp.Models
{
    public class DeviceRepositoryClass : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepositoryClass(ConnectedOfficeContext context) : base(context)
        {
        }

        public Device GetMostRecentService()
        {
            return _context.Device.OrderByDescending(service => service.DeviceId).FirstOrDefault();
        }
    }
}

