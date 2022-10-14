using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_system_csharp.Models;

namespace web_system_csharp.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context){
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x=>x.Name).ToList();
        }
    }
}