﻿



using ProjectLibrary.Models;
using System.Data.Entity;

namespace ProjectLibrary.Context
{
    public class CompanyContext  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2019;initial catalog=CMT;Persist Security Info=True;User Id=sa;Password=StandardE80;MultipleActiveResultSets=True;");
        }

        public DbSet<CompanyModel> Companies { get; set; }
    }
}
