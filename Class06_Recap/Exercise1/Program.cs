using Exercise1.MyClasses;
using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Name,last name, age");
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int checkedAge;
            bool age = int.TryParse(Console.ReadLine(), out checkedAge);
            if (age)
            {
                Human human1 = new Human(name, lastName, checkedAge);

                Console.WriteLine(human1.GetPersonStats());
            }
            else
            {
                Console.WriteLine("Error");
            }



            

        }
    }
}
