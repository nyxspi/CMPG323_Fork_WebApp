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
        protected readonly CMPG323Context_context=new CMPG323Context();
    }
    public IEnumerable<Categories> GetAll()
    {
        return _context.Categories.ToList();
    }

    public async Task<IActionResult> Index()
    {
        CategoriesRepository categoriesRepository = new CategoriesRepository();

        var results = categoriesRepository.GetAll();

        return View(results);
    }

    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly CMPG323Context _context;
        public GenericRepository(CMPG323Context context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }

    public class ServicesController : Controller
    {
        private readonly IServiceRepository _serviceRepository;
        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            return View(_serviceRepository.GetAll());
        }
    }


    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(CMPG323Context context) : base(context)
        {

        }

        public Service GetMostRecentService()
        {
            return _context.Service.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }

}



