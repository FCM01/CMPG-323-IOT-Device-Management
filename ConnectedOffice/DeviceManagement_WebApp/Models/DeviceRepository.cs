using DeviceManagement_WebApp.Data;
using System.Linq;

namespace DeviceManagement_WebApp.Models
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Device GetMostRecentService()
        {
            return _context.Device.OrderByDescending(service => service.DateCreated).FirstOrDefault();
        }
    }
}

