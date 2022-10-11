using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gabrielspetillo_d7_avaliacao.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserData> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserData>().HasData(GetInitialUsers());
            base.OnModelCreating(modelBuilder);
        }

        private static UserData[] GetInitialUsers()
        {
            return new UserData[]
            {
                new UserData
                {
                    Id = 1,
                    Email = "admin@email.com",
                    Password = "admin123"
                }
            };
        }

    }
}
