using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Queries
    {
        public static void Run()
        {
            /* simple query select
            List<int> numbers = new List<int>() { 2, 3, 4,3,4, 4,3,4,34,1,4,1324,1,34,2,432,4,324,32,4,324};

            //Method Syntax

            IEnumerable<int> query = numbers.Where(x => x % 2 == 0).ToList();


            //Mixed Syntax
            List<int> query = (from x in numbers
                               select x).Where(x => x % 2 == 1).ToList();

            foreach (var number in query)
            {
                Console.WriteLine(number);
            }


            // Query Syntax

            var QS = from number in numbers
                     where number % 2 == 1
                     select number;

            // query syntax 
            List<int> QStoList = (from number in numbers
                                 where number % 2 == 1
                                 select number).ToList();

            //select* from numbers
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
            */
        
            // simple query
            /**
            // 1 - ish
            var employeeSalary1 = from salary in Employee.GetEmployees() 
                                 select (salary.FirstName, Salary: salary.Salary * 12, salary.Position);

            // 2 - ish
            var employeeSalary = (from salary in Employee.GetEmployees()
                                 select new 
                                 { 
                                     FirstName = salary.FirstName,
                                     Salary = salary.Salary * 12,
                                     Position = salary.Position
                                 });

            // method syntax
            var MS = Employee.GetEmployees().Select(x => new
            {
                Name = x.FirstName, 
                Salary = x.Salary * 12,
                Position = x.Position
            });


            foreach (var employee in employeeSalary1)
                Console.WriteLine(employee.FirstName +  " " + employee.Position + " " + employee.Salary);
            */

            List<string> list = new List<string>() { "Muhammad Abdulloh", "Komilov" };

            // method syntax
            
            var items = Employee.GetEmployees().SelectMany(x => x.ProgrammingLanguages, 
                    (parent, child) => new
                    {
                        Name = parent.FirstName,
                        Language = child
                    }
           );




            foreach ( var item in items )
            {
                Console.WriteLine($"Name: {item.Name}, Language: {item.Language}");
            }
            

            // query syntax select many

            //var QS = from employe in list
            //         from metaItem in employe
            //         select metaItem;

            //foreach (var item in QS )
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
