using System;
using System.Collections.Generic;
using RazorPagesTutorial.Models;

namespace RazorPagesTutorial.Services{
   public class MockEmployeeRepository : IEmployeeRepository
   {
        private List<Employee> _employeeList;

        public MockEmployeeRepository(){
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@mail.com", PhotoPath = "woman.jpg"},
                new Employee() {Id = 2, Name = "John", Department = Dept.IT, Email = "john@mail.com", PhotoPath = "man.jpg"},
                new Employee() {Id = 3, Name = "Sara", Department = Dept.HR, Email = "sara@mail.com", PhotoPath = "woman.jpg"},
                new Employee() {Id = 4, Name = "David", Department = Dept.Payroll, Email = "david@mail.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees(){
            return _employeeList;
        }
   }
}