using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;


namespace StudentsApi.Data
{
public class StudentsContext : DbContext
    {
        //Creating Constructor
        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {

        }   

        //Creating Table
        public DbSet<Student> Students { get; set; }


    }
}