using Microsoft.EntityFrameworkCore;
using mySales.Data;
using mySales.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mySales.Services
{
    public class DepartmentService
    {
        private readonly MySallesContext _context;

        public DepartmentService(MySallesContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllDepartmentsAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
