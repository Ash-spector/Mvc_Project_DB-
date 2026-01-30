using Mvc_Project_Db.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Project_Db.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext():base("Constr")
        {
        }
        public DbSet <Employee> Employees  { get; set; }
        public DbSet <student> students { get; set; }
    }
}