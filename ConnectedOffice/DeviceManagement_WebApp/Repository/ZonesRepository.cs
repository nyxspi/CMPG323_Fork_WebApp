using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZonesRepository : GenericRepository<Zone>, IZonesRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
        public ZonesRepository(ConnectedOfficeContext context) : base(context)
        { }



        public Service GetMostRecentZones()
        {
            return _context.Zone.OrderByDescending(zones => zones.DateCreated).FirstOrDefault();
        }



        //GET
        public List<Zone> Getall()
        {
            return _context.Zone.ToList();
        }


    }
}
