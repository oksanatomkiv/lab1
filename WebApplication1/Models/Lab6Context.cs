using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lab6Context : DbContext
    {
        public Lab6Context() : base("name=Lab6") { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Games> Games { get; set; }
    }
}