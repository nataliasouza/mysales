﻿using Microsoft.EntityFrameworkCore;
using mySales.Data;
using mySales.Models;
using mySales.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mySales.Services
{
    public class SellerService
    {
        private readonly MySalesContext _context;

        public SellerService(MySalesContext context)
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
