using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Route("[action]")]
        public List<Employee> GetString()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Sabita", Surname="Sitaula",Address="Jhapa"},
                new Employee { Id = 2, FirstName = "Binita", Surname="Subedi",Address="Jhapa"}

            };
            return employees;
        }

        [Route("getstring/{int}")]
        
        public string GetString(int x)
        {
            return "Binita Subedi";
        }
    }
}