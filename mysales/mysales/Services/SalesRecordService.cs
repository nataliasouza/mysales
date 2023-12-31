﻿using mySales.Data;
using mySales.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace mySales.Services
{
    public class SalesRecordService
    {
        private readonly MySalesContext _context;

        public SalesRecordService(MySalesContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                //restrição de data 
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                //restrição de data
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                //restrição de data 
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                //restrição de data
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            var data = await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)                
                .OrderByDescending(x => x.Date)
                .ToListAsync();

            return data.GroupBy(x => x.Seller.Department).ToList();
        }
    }
}
