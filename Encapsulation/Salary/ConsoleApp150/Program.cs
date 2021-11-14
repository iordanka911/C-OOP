using ClassLibrary1;
using EncapsulationDemos.People;
using System;
using System.Collections.Generic;

namespace EncapsulationDemos
{
    
    class Manager : Worker
    {
        public void FireWorker(Worker Worker)
        {
            
        }
    }
    
    class Worker //read only (immutable)
    {
        private int salary;

        public Worker()
        {

        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 650)
                {
                    //value = 650;
                    throw new Exception("Invalid salary.Min salary is 650.");
                }
                salary = value;
            }
        }
        public void IncreaseSalary()
        {
            salary *= 2;
        }

        public void AddMeToList(List<Worker> people)
        {
            people.Add(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Test();
            Worker p = new Worker();
            Person v = new Person();
            var list = new List<Worker>();
            var Worker = new Worker();
            Worker.Salary = 700;
            Worker.AddMeToList(list);
            Console.WriteLine(list.Count);

            Worker.IncreaseSalary();
            Console.WriteLine(Worker.Salary);
        }
    }

}

