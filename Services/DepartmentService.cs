using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_system_csharp.Models;
using Microsoft.EntityFrameworkCore;

namespace web_system_csharp.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context){
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x=>x.Name).ToListAsync();
        }
    }
}