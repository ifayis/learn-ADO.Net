using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

    //class Linq
    //{
    //    static void Main()
    //    {
    //        List<Student> students = new List<Student>()
    //        {
    //        new Student {Name = "mhd", Age = 20, Department = "hr"},
    //        new Student {Name = "fys", Age = 22, Department = "it"},
    //        new Student {Name = "abc", Age = 24, Department = "marketing"}
    //        };

    //        //var result = students.GroupBy(a => a.Age).OrderByDescending(s => s.Key).Skip(1).FirstOrDefault().ToList();

    //        //foreach (var stu in result)
    //        //{
    //        //    Console.WriteLine($"{stu.Name} - {stu.Age} - {stu.Department}");
    //        //}

    //        int result = students.Max(s => s.Age);
    //        Console.WriteLine(result);
    //    }
    //}
}
