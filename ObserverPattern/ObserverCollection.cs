using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    public interface IObservable<Tobserver>
    {
        void Subscribe(Tobserver observer);
        void UnSubscribe(Tobserver observer);
    }

    public class ObserverCollection<Tobserver> : List<Tobserver>,IObservable<Tobserver>
    {
        public void Execute(CommandBase<Tobserver> command)
        {
            foreach (var observer in this)
            {
                command.Execute(observer);
            }
        }

        public void Subscribe(Tobserver observer)
        {
            if (observer != null)
                this.Add(observer);
        }

        public void UnSubscribe(Tobserver observer)
        {
            if (observer != null)
                this.Remove(observer);
        }
    }

    public abstract class CommandBase<Tobserver>
    {
        public virtual void Execute(Tobserver target)
        {
            this.Invoke(target);
        }

        public abstract void Invoke(Tobserver observer);

    }

    public class EmployeeObserverCollection : ObserverCollection<IEmployeeObserver>,IEmployeeObserver
    {
        public class StartCommand : CommandBase<IEmployeeObserver>
        {
            public override void Invoke(IEmployeeObserver target)
            {
                target.Start();
            }
        }

        public void Start()
        {
            StartCommand command = new StartCommand();
            this.Execute(command);
        }

    }

   public interface IEmployeeObserver
    {
        void Start();
    }


}
