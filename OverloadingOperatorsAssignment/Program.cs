using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded "==" and "!=" operators
            if (employee1 == employee2)
                Console.WriteLine("Employee 1 and Employee 2 are equal.");
            else
                Console.WriteLine("Employee 1 and Employee 2 are not equal.");

            Console.ReadLine();
        }
    }
}
