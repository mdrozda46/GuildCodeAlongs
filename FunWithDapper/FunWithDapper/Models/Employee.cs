﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDapper.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }   
        public string Title { get; set; }   
        public DateTime? BirthDateTime { get; set; }
        public int? ReportsTo { get; set; }
        public string ManagerName { get; set; }
    }
}
