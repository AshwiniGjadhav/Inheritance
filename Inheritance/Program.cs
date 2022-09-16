using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("manager", 45000, 250, 5000);
            m1.Calculate();
            Console.WriteLine(m1);

            Employee e1 = new Manager("manager2", 43000,250,5000);
            e1.Calculate();
            Console.WriteLine(e1);

            Employee e2 = new Employee("emp1", 36000, 200);
            e2.Calculate();
            Console.WriteLine(e2);

            Employee e3 = new SalesManager("Salesmanager1", 43000, 250, 5000,4000);
            e3.Calculate();
            Console.WriteLine(e3);




        }
    }
}
