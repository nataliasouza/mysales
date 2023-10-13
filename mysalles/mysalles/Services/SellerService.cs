using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return _context.Seller.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindByIdSeller(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(seller => seller.Id == id);
        }

        public void RemoveSeller(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }      
    }
}
