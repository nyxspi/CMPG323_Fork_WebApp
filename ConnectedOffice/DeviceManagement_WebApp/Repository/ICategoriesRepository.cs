using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DeviceManagement_WebApp.Repository.IGenericRepositoryInterface;

namespace DeviceManagement_WebApp.Repository
{

        public interface ICategoriesRepository : IGenericRepository<Category>
        { 
            Category GetMostRecentCategory();
        }

}
