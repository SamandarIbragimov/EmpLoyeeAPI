﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDAL
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DepartmentName { get; set; } 

        public List<Employee> Employees { get;set; }

      
        
    }
}
