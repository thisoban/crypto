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

        public string DbPath { get; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "cryptos.db");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
        public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
        }
}
