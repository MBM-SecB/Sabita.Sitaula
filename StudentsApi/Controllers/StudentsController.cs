using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;

[Route("students")]
[ApiController]
public class StudentsController : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] { "Sabita", "Binita" };

        students = null;
        if (students == null)
            return BadRequest();
        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetStudentById(string name)
    {
        var students = new string[] { "Sabita", "Binita" };

        var student = students.Where(x => x == name).FirstOrDefault();
        if (student == null)
        {
            return BadRequest();
        }

        return Ok(student);
    }

    [HttpPost]
    [Route("add")]
    public ActionResult CreateStudent(Student student)
    {
       
        if (student == null)
        {
            return BadRequest();
        }
        //Add student to db


        return Created("",student);
    }
    db.Student.Add(student)
    db.SaveChanges()
}

