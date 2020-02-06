//hours: Tues(3) + Wed(3) + Thurs(3)

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
          
            var currentIndex = 0;

            do
            {
                Menu();

                string userInput = Console.ReadLine();              //declares that userInput equals what the user types

                if (userInput == "A")                               //will analyze what the user input and call method based on their command (A, S, F, etc.)
                {
                    Console.WriteLine("Type New Task:");                //After "A" is input, asks this question. 

                    Add();

                    ClearWriteHighlight(currentIndex);
                }

                else if (userInput == "S")
                {
                    currentIndex = Skip(currentIndex);

                    ClearWriteHighlight(currentIndex);

                }

                else if (userInput == "FL")
                {
                    toDoList.Add(toDoList[currentIndex]);

                    toDoList.RemoveAt(currentIndex);

                    ClearWriteHighlight(currentIndex);
                }

                else if (userInput == "F")
                {
                    if (currentIndex > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        toDoList.RemoveAt(currentIndex);
                    }
                    ClearWriteHighlight(currentIndex);
                }

                else                                                //Catch for invalid command
                {
                    Console.WriteLine("Command Not Recognized");
                }   

            } while (true);
        }

        private static void ClearWriteHighlight(int currentIndex)
        {
            Console.Clear();

            for (int i = 0; i < toDoList.Count; i++)
            {
                if (i == currentIndex)
                {
                    
                    Highlight();

                    Console.WriteLine(toDoList[i]);

                    StopHightlighting();
                }

                else
                {
                    Console.WriteLine(toDoList[i]);
                }

            }
        }

        private static int Skip(int currentIndex)
        {
            if (currentIndex == toDoList.Count - 1)
            {
                currentIndex = 0;
            }
            else
            {
                ++currentIndex;
            }
            return currentIndex;
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
    }
}
