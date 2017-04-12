using System;
using System.Collections.Generic;
using WCFTestConsoleApplication.DataServices;
using WCFTestConsoleApplication.JokeServiceWCF;

namespace WCFTestConsoleApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {

            char keyPressed;
            do
            {
                Menu();
                keyPressed = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                ProcessInput(keyPressed);
            }
            while (keyPressed != 'Q');


        }

        private static void Menu()
        {
            Console.WriteLine("________________________");
            Console.WriteLine("L) List All Jokes");
            Console.WriteLine("#) Show Joke by ID");
            Console.WriteLine("N) Enter a New Joke");
            Console.WriteLine("Q) Quite");
            Console.WriteLine("Please enter a command");
        }

        private static void ProcessInput(char keyPressed)
        {
            switch(keyPressed)
            {
                case 'L':
                {
                    JokeDataService jds = new JokeDataService();
                    List<Joke> l = jds.GetAllJokes();

                    foreach (Joke j in l)
                    {
                            Console.WriteLine($"ID: {j.jokeId}");
                            Console.WriteLine($"Title: {j.title}");
                            Console.WriteLine($"Joke: {j.jokeText}");
                    }
                    break;
                }
            }
        }
    }
}
