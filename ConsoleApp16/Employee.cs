using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancie { get; set; }
        public int Payment { get; set; }
        public int[] DateOfGettingTheJobe { get; set; } 

        public Employee(string name,int payment,int[] data)
        {
            Name = name;
            Payment = payment;
            Vacancie = Vacancies.Boss;
            DateOfGettingTheJobe = new int[3];
            for(int i = 0;i<3;i++)
            {
                DateOfGettingTheJobe[i] = data[i];
            }
            
        }
    }
}
