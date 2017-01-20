using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication8
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsList = new Dictionary<string, Student>();
                     
            Student s1 = new Student("Jan", "Kwiatkowski", "111100");
            Student s2 = new Student("Alicja", "Kowalska", "110000");
            Student s3 = new Student("Tomasz", "Kowalska", "112233");
            Teacher t1 = new Teacher("Adam", "Nowak", "Matematyka");

            studentsList.Add(s1.indeks, s1);
            studentsList.Add(s2.indeks, s2);
            studentsList.Add(s3.indeks, s3);

            t1.addGrade(s1, 2);
            t1.addGrade(s1, 4);
            t1.addGrade(s2, 3);
            t1.addGrade(s2, 3);
            t1.addGrade(s3, 4);
            t1.addGrade(s3, 5);

            Console.WriteLine(s1);
            Console.Write("Podaj nr indeksu studenta ktorego chcesz wyswietlic: ");
            string input = Console.ReadLine();
            if (studentsList.Keys.Contains<string>(input))
            {
                Console.WriteLine(studentsList[input]);

            }
            else
                Console.WriteLine("Nie ma studenta o podabnym indeksie");

            string json = JsonConvert.SerializeObject(studentsList.ToArray());
        Console.WriteLine("Serializacja do JSONa");
                        System.IO.File.WriteAllText(@"D:\json.txt", json);
        }
       
    }
}
