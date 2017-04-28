using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using RESTTestConsoleApp.Transports;
using RESTTestConsoleApp.DataServices;

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
			Console.WriteLine("Q) Quit");
			Console.WriteLine("Please enter a command");
		}

		private static void ProcessInput(char keyPressed)
		{
			switch (keyPressed)
			{
				case 'L':
					{
                        var ds = new JokeDataService();
                        var resultObject = ds.GetAllJokes();

						foreach (Joke j in resultObject)
						{
							Console.WriteLine($"ID: {j.JokeId}");
							Console.WriteLine($"Title: {j.Title}");
							Console.WriteLine($"Joke: {j.JokeText}");
						}
						break;
					}
				case 'N':
					{
                        Joke j = new Joke();
                        Console.WriteLine("Title....");
                        j.Title = Console.ReadLine();
                        Console.WriteLine("Joke Text....");
                        j . JokeText = Console.ReadLine();

                        var ds = new JokeDataService();
                        var response = ds.AddJoke(j);

                        Console.WriteLine("Joke Added:");
                        Console.WriteLine($"ID: {response.JokeId}");
                        Console.WriteLine($"Title: {response.Title}");
                        Console.WriteLine($"Joke: {response.JokeText}");

                        break;
					}
			}
		}
	}
}
