using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal interface IDepartmentService
    {
        Instructor Head { get; }
        List<Budget> Budgets { get; }
        List<Course> Courses { get; }
    }
}
