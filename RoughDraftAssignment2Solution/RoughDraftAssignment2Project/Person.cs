using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughDraftAssignment2Project
{
    class Person
    {
        Person Spouse;

        bool IsMarried()
        {
            return this.SpouseFirstName != null;
            return this.SpouseAge != null;
        }
        
        public string FirstName;
        public string LastName;
        public int Age;
        public bool IsMarried;
        Person Spouse;
        public string SpouseFirstName;
        public int SpouseAge;

        
        
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;

        }

        public string GetSpouseFullName()
        {
            return this.SpouseFirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.Age);


        }

        public void PrintSpouseNameAndAge()
        {
            System.Console.WriteLine(this.SpouseFirstName + " " + this.LastName + " " + this.SpouseAge);


        }

        public void GatherDataFromUser()
        {
            this.FirstName = Question.AskForString("What is your first name?");
            this.LastName = Question.AskForString("What is your last name?");
            this.Age = Question.AskForInteger("How old are you?");
            this.IsMarried = Question.AskForBool("Are you married?");
            this.SpouseFirstName = Question.AskForString("What is your spouse's name?");
            this.SpouseAge = Question.AskForInteger("How old is your spouse?");
          
            
        }

        public static int Count;

        public static double Average;
 

    }
}
