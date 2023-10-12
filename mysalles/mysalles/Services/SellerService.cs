using mysalles.Data;
using mysalles.Models;
using System.Collections.Generic;
using System.Linq;

namespace mysalles.Services
{
    public class SellerService
    {
        private readonly MySallesContext _context;

        public SellerService(MySallesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAllSellers()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
