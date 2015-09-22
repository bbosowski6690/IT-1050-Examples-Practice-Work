using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughDraftAssignment2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double SumOfAllAges = 0;
            double NumberOfPeople = 0;
            double AverageAge = SumOfAllAges / NumberOfPeople;
            int TotalPeople = 0;

            Person person1 = new Person();
            person1.GatherDataFromUser();

            
            Person person2 = new Person();
            person2.GatherDataFromUser();



            Person person3 = new Person();
            person3.GatherDataFromUser();


            System.Console.WriteLine(person1.PrintNameAndAge());
            System.Console.WriteLine(person1.PrintSpouseNameAndAge());
            System.Console.WriteLine(person2.PrintNameAndAge());
            System.Console.WriteLine(person2.PrintSpouseNameAndAge());
            System.Console.WriteLine(person3.PrintNameAndAge());
            System.Console.WriteLine(person3.PrintSpouseNameAndAge());
            System.Console.WriteLine("Average Age: " + AverageAge);
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }
    }
}
