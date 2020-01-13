﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentEmployeeMVC.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Departments { get; set; }
    }
}
