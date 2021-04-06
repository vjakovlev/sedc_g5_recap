using System;
using Exercise2.Classes;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dog's name: ");
            string dogName = Console.ReadLine();

            Console.Write("Enter dog's race: ");
            string dogRace = Console.ReadLine();

            Console.Write("Enter dog's color: ");
            string dogColor = Console.ReadLine();

            Dog dog01 = new Dog()
            {
                Name = dogName,
                Race = dogRace,
                Color = dogColor
            };

            while (true)
            {
                Console.WriteLine("Choose one of the actions, you want your dog to do:" +
                                "\nIf you want the dog to eat enter - eat" +
                                "\nIf you want the dog to play enter - play" +
                                "\nIf you want the dog to chase it's tail write - chase tail" +
                                "\nIf you want to quit enter - quit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "eat":
                        Console.WriteLine(dog01.Eat());
                        break;
                    case "play":
                        Console.WriteLine(dog01.Play());
                        break;
                    case "chase tail":
                        Console.WriteLine(dog01.ChaseTail());
                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Please enter one of the options written below!!!");
                        break;
                }
            }
        }
    }
}
