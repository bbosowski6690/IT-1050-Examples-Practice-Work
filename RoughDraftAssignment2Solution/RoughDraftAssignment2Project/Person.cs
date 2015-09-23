namespace RoughDraftAssignment2Project
{
    class Person
    {
        

        
        
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public string SpouseName;
        public int SpouseAge;
        public bool IsMarried()
        {
            return Spouse != null;
            if (person1.IsMarried())
            {
            person1.SpouseName = " ";
            person1.SpouseAge = " ";

            }
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string GetSpouseFullName()
        {
            return this.SpouseName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.Age);
        }

        public void PrintSpouseNameAndAge()
        {
            System.Console.WriteLine(this.SpouseName + " " + this.LastName + " " + this.SpouseAge);
        }

        public void GatherDataFromUser()
        {
            this.FirstName = Question.AskForString("What is your first name?");
            this.LastName = Question.AskForString("What is your last name?");
            this.Age = Question.AskForInteger("How old are you?");
            this.IsMarried = Question.AskForBool("Are you married?");
            this.SpouseName = Question.AskForString("What is your spouse's name?");
            this.SpouseAge = Question.AskForInteger("How old is your spouse?");
        }

        

        public static double Average;
 

    }
}
