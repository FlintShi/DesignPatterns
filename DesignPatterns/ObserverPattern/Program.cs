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
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.subjectState = "ABC";
            s.Notify();

            Console.Read();

        }
    }

    abstract class Subject
    {
        public string subjectState { get; set; }
        public abstract void Attach(Observer observer);
        public abstract void Detach(Observer observer);
        public abstract void Notify();
    }

    //具体通知者
    class ConcreteSubject : Subject
    {
        private IList<Observer> observers = new List<Observer>();

        //增加观察者
        public override void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        //移除观察者
        public override void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        //通知
        public override void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }

    abstract class Observer
    {
        protected string name;
        protected string observerState;
        protected Subject subject;
        public Observer(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public abstract void Update();
    }

    class ConcreteObserver : Observer
    {
        public ConcreteObserver(Subject subject, string name)
            : base(subject, name)
        { }
        //更新

        public override void Update()
        {
            observerState = subject.subjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }
    }
}
