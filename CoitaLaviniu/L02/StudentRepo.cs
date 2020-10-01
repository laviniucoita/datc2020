using System.Collections.Generic;
namespace L02.webapi
{
    public class StudentsRepo
    { public  List<Student> Students  ;
        public StudentsRepo()
        {
        Students = new List<Student>();
        Students.Add( new Student{ 
            Id = 1,
            Nume = " Batecuie ",
            Prenume = " Ionut ",
            StudyYear = 4,
            Faculty = " AC ", 
            Score = 5.56}
            );
        Students.Add( new Student{ 
            Id = 2,
            Nume = " Mere ",
            Prenume = " Ana ",
            StudyYear = 3,
            Faculty = " Litere ", 
            Score = 9.56}
            );
        Students.Add( new Student{ 
            Id = 3,
            Nume = " Presley ",
            Prenume = " Elvis ",
            StudyYear = 3,
            Faculty = " Muzica ",
            Score = 10}
            );
        }
    }   

       
}