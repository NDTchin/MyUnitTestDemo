using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyUnitTestDemo.Models;

namespace MyUnitTestDemo.Data
{
    public class MyUnitTestDemoContext : DbContext
    {
        public MyUnitTestDemoContext (DbContextOptions<MyUnitTestDemoContext> options)
            : base(options)
        {
        }

        public DbSet<MyUnitTestDemo.Models.Product> Product { get; set; } = default!;
    }
}
