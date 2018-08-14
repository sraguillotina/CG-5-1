using System;

namespace Class5_FullName
{
    class Program
    {
        static void Main(string[] args)
        {

         /*Created a program that asks the user to enter their first and 
         * last name separately.  Created a method that 
         * combines the first and last name and returns it as a new value. Printed the new value (entire name). */

            //The user input becomes the userFirstName variable.
            Console.Write("Please type your first name: ");
            string userFirstName = Console.ReadLine();

            //The user input becomes userLastName variable.
            Console.Write("Please type your last name: ");
            string userLastName = Console.ReadLine();

            //Console.Write will print the user's combined full name.
            Console.Write("Your full name is: ");
            //Invoking the CombineName method created for this application.
            //Strings input by the user (userFirstName and userLastName) are
            //passed through method.
            CombineName(userFirstName, userLastName);
            Console.ReadLine();

        }
            //New method created outside Main method.
            /*Method CombineName takes two parameters and allowing user input
             *to pass through through method code.
             *The first parameter, string firstName, will receive the user's first input. 
             *The second parameter, string lastName, will receive the user's second input.
             */
        private static void CombineName(string firstName, string lastName)
        {
            //The String.Format class and method creates a new string by putting two 
            //strings together.
            //The space between the value place-holders ensures a space between user's input strings.
            Console.Write(String.Format("{0} {1}", firstName, lastName));
           
        }
        
           

    }
}
