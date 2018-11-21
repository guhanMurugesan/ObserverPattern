using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class EmployeeObservable
    {
        EmployeeObserverCollection observerCollection = new EmployeeObserverCollection();

        public void AddObserver(IEmployeeObserver observer)
        {
            observerCollection.Subscribe(observer);
        }

        public void RemoveObserver(IEmployeeObserver observer)
        {
            observerCollection.UnSubscribe(observer);
        }

        public void EmployeeSessionStart()
        {
            observerCollection.Start();
        }
    }
}
