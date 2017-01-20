using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Student 
    {
        public string name;
        public string lastname;
        public string indeks;
        public static int grade;
      
        public List<int> gradesList = new List<int>();

        public Student(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public Student(string name, string lastname, string indeks) 
        {
            this.name = name;
            this.lastname = lastname;
            this.indeks = indeks;
        }
        public void getGradesList()
        {
            foreach (var i in gradesList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
