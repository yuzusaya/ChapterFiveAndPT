using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFive
{
    public class ObjectOrientedProgrammingCourse
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string IdentityCard { get; set; }
        public decimal Mark { get; set; }

        public void SetStudentDetail(string studentName, string studentId,
            string identificationCard, decimal mark)
        {

        }
    }

    public class Student : ObjectOrientedProgrammingCourse
    {
        public new void SetStudentDetail(string studentName, string studentId,
            string identificationCard, decimal mark)
        {
            Students.Add(new Student()
            {
                StudentName = studentName,
                StudentId = studentId,
                IdentityCard = identificationCard,
                Mark = mark
            });
        }

        public void DisplayAllStudentDetails()
        {
            var students = Students.OrderBy(student => student.StudentName).ToList();
            Console.WriteLine("Student sorted by name");
            Console.WriteLine("No.\tStudent Name\tStudent Id\tIC\tMark");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i+1}\t{students[i].StudentName}\t{students[i].StudentId}\t" +
                                  $"{students[i].IdentityCard}\t{students[i].Mark}");
            }
        }

        public void DisplayAllStudentRanking()
        {
            Console.WriteLine("Student sorted by mark");
            var students = Students.OrderByDescending(student => student.Mark).ToList();
            Console.WriteLine("No.\tStudent Name\tStudent Id\tIC\tMark");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{students[i].StudentName}\t{students[i].StudentId}\t" +
                                  $"{students[i].IdentityCard}\t{students[i].Mark}");
            }
        }
    }
}
