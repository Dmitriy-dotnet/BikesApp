using Bikes.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bikes.DAL.Context
{
    public class BikeContext : DbContext
    {
        public BikeContext(DbContextOptions<BikeContext> options ) : base( options )
        {
            Database.EnsureCreated();
        }

        public DbSet<Bike> Bikes { get; private set; }

    }
}
