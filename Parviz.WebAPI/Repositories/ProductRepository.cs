﻿using Microsoft.EntityFrameworkCore;
using Parviz.WebAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parviz.WebAPI.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var data = await _context.Products.FindAsync(id);
            _context.Products.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            var unchangedData = await _context.Products.FindAsync(product.Id);
            _context.Entry(unchangedData).CurrentValues.SetValues(product);
            await _context.SaveChangesAsync();
        }
    }
}
