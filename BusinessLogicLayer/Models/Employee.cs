using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
    }
}
