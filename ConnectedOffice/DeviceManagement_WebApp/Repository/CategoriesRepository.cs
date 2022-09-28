using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    { 
        //private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        { }



        public Service GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
        }

      

        //GET
        public List<Category> Getall()
        {
            return _context.Category.ToList();
        }

    }
   
}



