using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Models
{
    //public class IDeviceRepository
    //{
    //}
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Device GetMostRecentService();
    }

}

