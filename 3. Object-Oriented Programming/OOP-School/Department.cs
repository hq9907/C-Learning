using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_School
{
    internal class Department : IDepartmentService
    {
        public Instructor Head { get; set; }

        public List<Budget> Budgets { get; set; }

        public List<Course> Courses { get; set; }
    }

    internal record class Budget { DateTime StartDate; DateTime EndDate; decimal money; }
}
