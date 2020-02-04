using System;
using System.Collections.Generic;

namespace ToDoList_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();   //declares that userInput equals what the user types


            Console.WriteLine("What would you like to do?\n" +
                                "A = Add Task, S = Skip, F = Finish / Complete, FL = Finish Later"); 
            
            //Very first thing to display. Need userInput

            Console.ReadLine();                     //Pulls userInput

            if (userInput == "A")                   //will analyze what the user input and call method based on their command (A, S, F, etc.)
            {
                AddString();
            }
            else if (userInput == "S")
            {
                Skip();
            }
            else if (userInput == "F")
            {
                Finish();
            }
            else if (userInput == "FL")
            {
                FinishLater();
            }
            else                                                //Catch for invalid command
            {
                Console.WriteLine("Command Not Recognized. Please Use One Of The Following Commands:\n " +
                                  "A = Add Task, S = Skip, F = Finish / Complete, FL = Finish Later");
            }
            
            Remove();
        }

        private static void Remove()
        {
            throw new NotImplementedException();
        }

        private static void FinishLater()
        {
            throw new NotImplementedException();
        }

        private static void Finish()
        {
            throw new NotImplementedException();
        }

        private static void Skip()
        {
            throw new NotImplementedException();
        }

        private static void AddString()
        {
            List<string> ToDoList = new List<string>();
            string userInput = Console.ReadLine();

            ToDoList.Add(userInput + "\n");


        }
    }
}
