using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'F';
    public double Salary { get; set; }


public static List<Employee> GetEmployees()
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
            FirstName = "Sabita1", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        Employee employee5 = new Employee
        { 
            FirstName = "Sabita2", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        Employee employee6 = new Employee
        { 
            FirstName = "Sabita3", 
            Surname = "Sitaula", 
            Address = "Jhapa",
            Salary = 100.00
        };

        var employees = new List<Employee>() {employee1, employee2, employee3, employee4, employee5, employee6};
        return employees;
    }
}