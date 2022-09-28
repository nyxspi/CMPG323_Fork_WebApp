using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository: IGenericRepository<Zone>
    {
         Zone GetMostRecentZones();

    }
}
