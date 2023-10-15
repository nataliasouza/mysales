using Microsoft.EntityFrameworkCore;
using mysalles.Data;
using mysalles.Models;
using mysalles.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mysalles.Services
{
    public class SellerService
    {
        private readonly MySallesContext _context;

        public SellerService(MySallesContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>>FindAllSellersAsync()
        {
            return await _context.Seller.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task Insert(Seller seller)
        {
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdSellerAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(seller => seller.Id == id);
        }

        public async Task UpdateSellerAsync(Seller seller)
        {
            bool hasAnySeller = await _context.Seller.AnyAsync(x => x.Id == seller.Id);
            if (!hasAnySeller)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(seller);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }

        public async Task RemoveSellerAsync(int id)
        {
            try
            {
                var seller = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(seller);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException ex) 
            {
                throw new IntegrityException(ex.Message);
            }
        }      
    }
}
