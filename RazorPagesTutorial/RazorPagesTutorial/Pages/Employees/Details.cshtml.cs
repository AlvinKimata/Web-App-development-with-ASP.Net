using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Services;
using RazorPagesTutorial.Models;

namespace RazorPagesTutorial.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public Employee Employee {get; set;}
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public void OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);
        }
    }
}
