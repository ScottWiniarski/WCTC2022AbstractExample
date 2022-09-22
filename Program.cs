using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?\n(1) Pig\n(2) Dog\n(3) Snake\n(4) Monkey");
            var choice = Console.ReadLine();

            Animal animal;

            if (choice == "1")
            {
                animal = new Pig();
                animal?.MakeNoise();
                animal?.Sleep();
            }
            else if (choice == "2")
            {
                animal = new Dog();
                animal?.MakeNoise();
                animal?.Sleep();
            }
            else if(choice == "3")
            {
                animal = new Snake();
                animal?.MakeNoise();
                animal?.Sleep();
            }
            else if( choice == "4")
            {
                animal = new Monkey();
                animal?.MakeNoise();
                animal?.Sleep();
            }

            //animal?.MakeNoise();
           // animal?.Sleep();
        }
    }
}
