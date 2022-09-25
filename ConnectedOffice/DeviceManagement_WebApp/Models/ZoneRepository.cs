using DeviceManagement_WebApp.Data;
using System.Linq;

namespace DeviceManagement_WebApp.Models
{
    //public class ZoneRepository
    //{
    //}
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Zone GetMostRecentService()
        {
            return _context.Zone.OrderByDescending(service => service.ZoneId).FirstOrDefault();
        }
    }
}

