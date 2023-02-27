using APIServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
 

namespace APIServer.Context
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options)
        {
        }
        public DbSet<Country> Country { get; set; }
        public DbSet<StateMaster> StateMaster { get; set; }


    }
}
