using Microsoft.EntityFrameworkCore;
using mysalles.Data;
using mysalles.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mysalles.Services
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
