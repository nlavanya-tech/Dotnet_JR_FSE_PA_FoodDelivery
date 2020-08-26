using FoodDeliveryMvcApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryMvcApp.DataLayer
{
    public class InMemoryDb:DbContext
    {
        //Creating inmemoryDb context
        public InMemoryDb(DbContextOptions<InMemoryDb> options) : base(options)
        {

        }
        //Create user Property
        public DbSet<Login> login { get; set; }
        public DbSet<SignUp> signup { get; set; }
        public DbSet<Restorents> restorent { get; set; }
        public DbSet<FoodIteam> fooditem { get; set; }
    }
}
