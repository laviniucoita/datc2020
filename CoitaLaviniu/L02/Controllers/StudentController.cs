using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace L02.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        StudentsRepo students = new StudentsRepo();
        
        private readonly ILogger<StudentsController> _logger;
        public StudentsController( ILogger<StudentsController> logger )
        {
            _logger = logger;        
        }
        [ HttpGet ]
        public List<Student> Get()
        {
            return students.Students;
        }
        [ HttpGet( "{id}" ) ]
        public Student Get( int id )
        {
            foreach ( Student student in students.Students )
            {
                if( student.Id == id )
                {
                    return student;
                }
            }
            return null;
        }
        
        
        [ HttpPost ]
        
        public List<Student> Post( [ FromBody ] Student student )
        {
            students.Students.Add( student ) ;
            return students.Students;
        }
    
       [ HttpDelete( "{id}" ) ]
       public List<Student> Delete( int id )
        {
            Student student = students.Students.Find(x => x.Id == id);
            if( student == null )
            {

            }
            else
            {
                students.Students.Remove( student );
            }                               
            return students.Students;
        }
        
       [ HttpPut( "{id}" ) ]
       public Student Update( int id, [ FromBody ] Student studentUpdate)
       {
            Student student = students.Students.Find(x => x.Id == id);
            if( student == null )
            {

            }
            else
            {
                    student.Nume = studentUpdate.Nume;
                    student.Prenume = studentUpdate.Prenume;
                    student.Faculty = studentUpdate.Faculty;
                    student.StudyYear = studentUpdate.StudyYear;
                    student.Score = studentUpdate.Score;
            }
            return student;    
        }
    }

    
}