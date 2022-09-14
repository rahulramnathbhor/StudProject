using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.display());
            Student student1 = new Student();
            Console.WriteLine(student1.display());
        }
    }
}
