using System;

namespace EncapsulationDemos
{
    class Person //read only (immutable)
    {
        private int salary;

        public Person()
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
                if (value<650)
                {
                    value = 650;
                }
                salary = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Salary = 300;
            Console.WriteLine(person.Salary);
        }
    }
}
