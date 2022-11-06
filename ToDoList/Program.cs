using System;
using System.Runtime.CompilerServices;

namespace ToDoList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToDoApp app = new ToDoApp();

            Console.WriteLine("Type help to show options");

            //Write a command line terminal symbol
            Console.Write(">");

            string? inputLine = Console.ReadLine();
            while(!inputLine.Equals("") && !inputLine.ToLower().Equals("exit"))
            {
                if(inputLine.StartsWith("Add "))
                {
                    //if user want to add item
                    string text = inputLine.Split
                    (new[] {"Add "}, StringSplitOptions.None)[1];
                    app.Add(text);
                }
                else if(inputLine.StartsWith("Do #"))
                {
                    //If user wants to set a item to done
                    try
                    {
                        int doNumber = int.Parse(inputLine.Split
                        (new[] {"Do #"}, StringSplitOptions.None)[1]);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("A number must be specified to set item to done");
                    }
                }
                else if(inputLine.ToLower().Equals("print"))
                {
                    //If user wants to print all items
                    app.Print();
                }
                else if(inputLine.ToLower().Equals("help"))
                {
                    //If user wants to see which command to use
                    app.Help();
                }
                else
                {
                    Console.WriteLine("Command didn't recognize,type **help** to see all options");
                }

                 // Write a command line terminal symbol
                Console.Write(">");

                //Read new input
                inputLine = Console.ReadLine();
            }
        }
    }
}
