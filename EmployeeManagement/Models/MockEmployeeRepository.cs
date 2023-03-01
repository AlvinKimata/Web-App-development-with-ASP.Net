using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Deprtment = Dept.HR, Email = "mary@abc.com" },
                new Employee() { Id = 2, Name = "John", Deprtment = Dept.IT, Email = "john@abc.com" },
                new Employee() { Id = 3, Name = "Sam", Deprtment = Dept.IT, Email = "sam@abc.com" }
             };

        }

        public Employee Add(Employee employee)
        {
           employee.Id =  _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
