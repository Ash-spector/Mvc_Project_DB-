using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Project_Db.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public int salary { get; set; }
        public string Address { get; set; }
    }
}