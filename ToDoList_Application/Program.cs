using System;
using System.Collections.Generic;

namespace ToDoList_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What would you like to do?\n" +
                                "A = Add Task, S = Skip, F = Finish / Complete, FL = Finish Later");

                                                                //Very first thing to display. Need userInput

            string userInput = Console.ReadLine();              //declares that userInput equals what the user types
            List<string> toDoList = new List<string>();

            if (userInput == "A")                               //will analyze what the user input and call method based on their command (A, S, F, etc.)
            {
                toDoList = AddString(toDoList);
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

        private static List<string> AddString(List<string> toDoList)
        {
            Console.WriteLine("Type New Task:");                //After "A" is input, asks this question. 
            
            string userInput = Console.ReadLine();              //declares userInput as whatever the user types in
                     //declares ToDoList as a "List"

            toDoList.Add(userInput + "\n");                     //declares that ToDoList must add userInput to list and move to new line

            Console.WriteLine(toDoList);                        //display ToDoList
            return toDoList;
    

        }
    }
}
