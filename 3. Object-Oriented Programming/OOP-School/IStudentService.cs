using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal interface IStudentService: IPersonService
    {
        double GPA();
        List<(Course, Grade)> Grades { get; }
    }
}
