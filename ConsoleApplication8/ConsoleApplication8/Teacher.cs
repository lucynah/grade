using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Teacher : Student
    {
                  
        private string subject;

        public Teacher(string name, string lastname, string subject): base( name, lastname)
        { 
            this.subject = subject;
        }

        public void addGrade(Student student, int grade)
        {
            gradesList.Add(grade);
        }
    }
}
