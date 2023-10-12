using mysalles.Data;
using mysalles.Models;
using System.Collections.Generic;
using System.Linq;

namespace mysalles.Services
{
    public class DepartmentService
    {
        private readonly MySallesContext _context;

        public DepartmentService(MySallesContext context)
        {
            _context = context;
        }

        public List<Department> FindAllDepartments()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
