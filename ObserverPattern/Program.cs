using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeObservable observable = new EmployeeObservable();
            EmployeeObserver1 obsr1 = new EmployeeObserver1();
            EmployeeObserver2 obsr2 = new EmployeeObserver2();
            observable.AddObserver(obsr1);
            observable.AddObserver(obsr2);
            observable.EmployeeSessionStart();
            Console.ReadLine();
        }
    }
}
