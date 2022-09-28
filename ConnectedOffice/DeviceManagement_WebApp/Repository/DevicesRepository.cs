using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DevicesRepository : GenericRepository<Device>, IDevicesRepository
    {
        //private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
        public DevicesRepository(ConnectedOfficeContext context) : base(context)
        { }

        public Service GetMostRecentDevice()
        {
            return _context.Device.OrderByDescending(device => device.DateCreated).FirstOrDefault();
        }



        //GET
        public List<Device> Getall()
        {
            return _context.Device.ToList();
        }

    }
}
