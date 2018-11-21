using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class EmployeeObserver1 : IEmployeeObserver
    {
        public void Start()
        {
            Console.WriteLine("Employee 1");
        }
    }

    class EmployeeObserver2 : IEmployeeObserver
    {
        public void Start()
        {
            Console.WriteLine("Employee 2");
        }
    }
}
