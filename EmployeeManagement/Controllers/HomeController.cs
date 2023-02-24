using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository; 
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public JsonResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return Json(model);
        }
    }
}
