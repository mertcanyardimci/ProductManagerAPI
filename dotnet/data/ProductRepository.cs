using System;
using System.Linq;
using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Data
{
    public class ProductRepository
    {
        private readonly ProductContext _context;
        
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public Object Query(string s, string sort, int? queryPage)
        {
            var query = (from products
                    in _context.Products
                select products);

        
            if (!string.IsNullOrEmpty(s))
            {
                query = query.Where(p=>p.ModelName.Contains(s) || p.Title.Contains(s) || p.Text.Contains(s) || p.CityName.Contains(s) || p.TownName.Contains(s));
            }
            if (sort == "asc")
            {
                query = query.OrderBy(p=>p.Price);
            }
            else if (sort == "desc")
            {
                query = query.OrderByDescending(p=>p.Price);
            }
            
            int perPage = 50;
            int page = queryPage.GetValueOrDefault(1) == 0 ? 1 : queryPage.GetValueOrDefault(1);
            var total = query.Count();

            return new
            {
                total,
                page,
                adverts = query.Skip((page - 1) * perPage).Take(perPage)
            };
        }
        public DbSet<Product> Get()
        {
            return _context.Products;
        }

    }
}