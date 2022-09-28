using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ServiceRepository: GenericRepository<Service>,IServiceRepository
    {
        public ServiceRepository(ConnectedOfficeContext context) : base(context)
        { }

        public Service GetMostRecentService()
        { 
            return _context.Service.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }
}
