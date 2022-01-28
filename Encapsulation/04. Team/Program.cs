using PersonInfo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {

            var team = new Team("Softuni");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                team.AddPlayer(person);
            }

           
            if (team.FirstTeam.Count==1)
            {
                Console.WriteLine("First team has " + team.FirstTeam.Count + " player.");
            }
            else
            {
                Console.WriteLine("First team has " + team.FirstTeam.Count + " players.");
            }

            if (team.ReserveTeam.Count==1)
            {
                Console.WriteLine("Reserve team has " + team.ReserveTeam.Count + " player.");
            }
            else
            {
                Console.WriteLine("Reserve team has " + team.ReserveTeam.Count + " players.");
            }
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }


    }
}
