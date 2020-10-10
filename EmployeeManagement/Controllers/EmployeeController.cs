using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        
        //Object initializer
        Employee employee1 = new Employee()
        {
            FirstName = "Sabita", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        Employee employee2 = new Employee
        { 
            FirstName = "Binita", 
            Surname = "subedi", 
            Address = "Ktm",
            Salary = 10000.00
        };

        Employee employee3 = new Employee
        {
            FirstName = "Aniss", 
            Surname = "Ghimire", 
            Address = "Bhaktapur",
            Salary = 100.00
        };

        Employee employee4 = new Employee
        { 
            FirstName = "Sabita", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        Employee employee5 = new Employee
        { 
            FirstName = "Sabita", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        Employee employee6 = new Employee
        { 
            FirstName = "Sabita", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        List<Employee> employees = new List<Employee>() {employee1, employee2, employee3, employee4, employee5, employee6};
        

        return View(employees);
    }
}

public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'F';
    public double Salary { get; set; }
}