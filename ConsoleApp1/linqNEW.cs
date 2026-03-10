using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class linqNEW
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }

        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
            new Employee { Id = 1, Name = "Alice", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Bob", Department = "HR", Salary = 40000 },
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 70000 },
            new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 50000 }
            };

            
            var result = employees.OrderByDescending(e => e.Salary).Take(2);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Salary} - {item.Department}");
            }

            //Console.WriteLine(result);
        }
    }
}
