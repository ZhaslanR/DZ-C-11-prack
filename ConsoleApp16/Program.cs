using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[3] {12,09,2000};
            Employee employee = new Employee("Zhaslan", 15000, mas);
            Console.ReadLine();
        }
    }
}
