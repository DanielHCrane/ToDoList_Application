using System;
using System.Linq;
using System.Collections.Generic;



namespace ToDoList_Application
{
    class Program
    {
        public static List<string> toDoList = new List<string> { };
        static void Main(string[] args)
        {
            do
            {
                Menu();

                string userInput = Console.ReadLine();              //declares that userInput equals what the user types

                if (userInput == "A")                               //will analyze what the user input and call method based on their command (A, S, F, etc.)
                {
                    Console.WriteLine("Type New Task:");                //After "A" is input, asks this question. 

                    Add();
                    
                    Console.Clear();

                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Highlight();

                        Console.WriteLine(toDoList[i]);

                        StopHightlighting();
                    }
                }
                //else if (userInput == "S")
                //{
                //    Skip();
                //}
                //else if (userInput == "F")
                //{
                //    Finish();
                //}
                //else if (userInput == "FL")
                //{
                //    FinishLater();
                //}
                else                                                //Catch for invalid command
                {
                    Console.WriteLine("Command Not Recognized");
                }   
            } while (true);
            //Remove();
        
            
        }

        private static void StopHightlighting()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Highlight()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //Console.WriteLine('\n');
        }

        private static void Add()
        {
            toDoList.Add(Console.ReadLine());
        }

        private static void Menu()
        {

            Console.WriteLine("\nWhat would you like to do?\n" +
                                "A = Add Task, S = Skip, F = Finish / Complete, FL = Finish Later");
            
        }
        //private static void Remove()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void FinishLater()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Finish()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Skip()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
