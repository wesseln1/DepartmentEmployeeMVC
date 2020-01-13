﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentEmployeeMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [MaxLength(15, ErrorMessage = "First Name must be less than 16 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
