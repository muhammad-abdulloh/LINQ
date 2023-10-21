namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public string? Position { get; set; }
        public List<string> ProgrammingLanguages { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee { Id = 1001, FirstName = "Rustambek", LastName = "Jurayev", Age = 15, Salary = 200, 
                        Position = "Junior", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "JavaScrpt" } },
                new Employee { Id = 1002, FirstName = "Nurmuhammad", LastName = "Sharobiddinov", Age = 20,  Salary = 1500, 
                        Position = "Middle", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "C++" } },
                new Employee { Id = 1003, FirstName = "Sevinch", LastName = "Xayriddinova", Age = 19,  Salary = 1200, 
                        Position = "Strong Junior", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "Pascal", "C++" } },
                new Employee { Id = 1004, FirstName = "Bahriddin", LastName = "Abdusalomov", Age = 24,  Salary = 1600 , 
                        Position = "Middle", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "C++" }},
                new Employee { Id = 1005, FirstName = "Sarvarjon", LastName = "G'ulomjonov", Age = 25,  Salary = 2300, 
                        Position = "Strong Middle", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "GO" } },
                new Employee { Id = 1006, FirstName = "Azizbek", LastName = "Oxunov", Age = 17,  Salary = 1600, 
                        Position = "Middle", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "PHP" } },
                new Employee { Id = 1007, FirstName = "Muhammad Abdulloh", LastName = "Komilov", Age = 23,  Salary = 1600, 
                        Position = "Middle", ProgrammingLanguages = new List<string> { "C", "Python", "C#", "JavaScrpt", "TypeScript" } },
            };

            return employees;
        }
    }
}
