using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal class Course : ICourseService
    {
        List<Student> students = new List<Student>();
        public void enroll(Student student)
        {
            students.Add(student);
        }

        public Student[] getEnrollment()
        {
            return students.ToArray();
        }
    }
}
