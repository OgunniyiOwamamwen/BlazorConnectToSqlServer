using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Models
{
    public class EmployeeData
    {
        [Required]
        [MinLength(4, ErrorMessage = "SurName is too Short.")]
        public string SurName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Name is too Short.")]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
    }
}
