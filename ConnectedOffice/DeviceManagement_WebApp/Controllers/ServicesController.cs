using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Controllers
{
    public class ServicesController: Controller
    {
        private readonly IServiceRepository _serviceRepository;
        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        // GET: Services
        /*public async Task<IActionResult> Index()
        {
            return View(_serviceRepository.GetAll());
        }*/


        //Added code 
        private readonly IZonesRepository _zonesRepository;

        public async Task<ActionResult> Index()
        {
            return View(_zonesRepository.GetAll());
        }


        private readonly ConnectedOfficeContext _context;



        public ServicesController(ConnectedOfficeContext context)
        {
            _context = context;
        }


    }
}
