using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughDraftAssignment2Project
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

        public static bool AskForBool(string prompt)
        {
            return bool.Parse(AskForString(prompt));
        }

    
        
           
    }
}
