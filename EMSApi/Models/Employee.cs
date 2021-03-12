namespace EMSApi.Controllers
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; } = 'F';
        public double Salary { get; set; }

    }
}