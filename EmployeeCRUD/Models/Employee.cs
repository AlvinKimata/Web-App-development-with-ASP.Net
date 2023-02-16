using System;
using System.Collections.Generic;

namespace EmployeeCRUD.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string FatherName { get; set; } = null!;
}
