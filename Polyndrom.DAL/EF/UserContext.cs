using System;
using System.Collections.Generic;
using System.Text;
using Polyndrom.DAL.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace Polyndrom.DAL.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users{get;set;}
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) 
        {
            Database.EnsureCreated();            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                new User { ID=1, Email=@"test@test.com", Password="12345"}                
                });
        }

    }
}
