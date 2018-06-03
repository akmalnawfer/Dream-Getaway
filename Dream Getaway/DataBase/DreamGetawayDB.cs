using Dream_Getaway.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dream_Getaway.DataBase
{
    public class DreamGetawayDB : DbContext
    {
        public DreamGetawayDB() : base("dgcontext")
        { }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Packages> Packages { get; set; }
    }
}