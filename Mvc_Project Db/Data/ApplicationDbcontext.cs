using Mvc_Project_Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Project_Db.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext() : base("Constr")
        {
        }

        public DbSet<student> students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}