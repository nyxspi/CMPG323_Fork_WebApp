using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository
    {
        private readonly ConnectedOfficeContext _context=new ConnectedOfficeContext();

        //GET
        public List<Category> Getall()
        {
            return _context.Category.ToList();
        }

    }
   
}



