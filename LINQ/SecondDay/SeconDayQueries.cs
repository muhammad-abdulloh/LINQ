using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.SecondDay
{
    public class SeconDayQueries
    {
        public static void Run()
        {
            // orderby
            // Method Syntax
            //var result = Student.GetAllStudents().OrderBy(x => x.FirstName).ToList();

            //result.ForEach(x => Console.WriteLine(x.FirstName));

            // Query Syntax

            //List<Student> QS = (from x in Student.GetAllStudents()
            //         orderby x.LastName ascending
            //         select x).Where(x => x.Age > 20).ToList();

            //foreach (var q in QS)
            //{
            //    Console.WriteLine(q.Age);
            //}

            //List<int> numbers = new List<int>() { 2, 4, 12, 45, 1, 3, 56, 12, 34, 5 };

            //IEnumerable<int> result = numbers.OrderByDescending(x => x);  

            //foreach (int i in numbers)
            //{
            //    Console.Write(i + " ");
            //}

            // thenBy
            /*
             * .OrderByDescending(x => x.Age)
                                            .ThenBy(k => k.FirstName)
                                            .ThenByDescending(y => y.Course)
                                            .ThenBy(z => z.Contract)
             * */

            /*
            List<Student> result = Student.GetAllStudents()
                                            .OrderBy(x => x.Id)
                                            .ThenBy(l => l.LastName)
                                            .Where(x => x.Id > 2)
                                            .ToList();


            foreach (Student student in result)
            {
                Console.WriteLine($"{student.Id}: {student.LastName}");
            }
            */
            /**
            var students = Student.GetAllStudents().Select(x => x.FirstName).Distinct();

            List<int> numbers = new List<int>() { 1,9,12, 1,9, 2, 2, 3, 3, 4, 5, 6, 6 };


            List<string> letters = new List<string>() { "Rustambek", "rustambek", "Farxodbek","Sarvar", "Farxodbek", "Nurmuhammad" };

            IEnumerable<int> raqamlar =  numbers.Distinct();

            

            IEnumerable<String> sozlar =  letters.DistinctBy(x => x.ToLower());
            IEnumerable<String> sozlar2 =  letters.Distinct(StringComparer.OrdinalIgnoreCase);

            
            foreach (var student in sozlar2)
            {
                Console.WriteLine(student + " ");
            }
            */

            List<int> numbers = new List<int>() { 1, 9, 12, 1, 9, 2, 2, 3, 3, 4, 5, 6, 6 };

            bool result = numbers.All(x => x % 2 >= 2);

            List<string> letters = new List<string>() { "Rustambek", "rustambek", "Farxodbek", "Sarvar", "Farxodbek", "Nurmuhammad" };



            Console.WriteLine(letters.Contains("farxodbek", StringComparer.OrdinalIgnoreCase));
        }
    }
}
