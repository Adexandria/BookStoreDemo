using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Text;

namespace Books.Data
{
    class AppContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>();
            options.UseSqlServer("Data source =Bookstore.db");
            return new AppDbContext(options.Options);
        }
    }
}

