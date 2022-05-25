using crypto.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace crypto.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<Crypto> cryptos { get; set; }

        public DataContext()
        {

        }
 
        public DataContext(DbContextOptions options) : base(options) { }
    }
}

