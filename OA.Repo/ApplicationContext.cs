using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repo
{
    public class ApplicationContext : DbContext
    {
        

        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
        {

        }

        public object User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}
