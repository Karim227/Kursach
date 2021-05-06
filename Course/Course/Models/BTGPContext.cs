using Microsoft.EntityFrameworkCore;
using System;

namespace Cyrsovay.Models
{
    public class BTGPContext : DbContext
    {
        public DbSet<BTGPModel> Cyrsach { get; set; }
        public BTGPContext(DbContextOptions<BTGPContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
