using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Models;
using static DeviceManagement_WebApp.Repository.IGenericRepositoryInterface;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository: IGenericRepository<Zone>
    {
         Zone GetMostRecentZones();

    }
}
