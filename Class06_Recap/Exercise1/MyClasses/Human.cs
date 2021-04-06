using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1.MyClasses
{
    public class Human
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Age{ get; set; }

        public Human(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
        }

        public string GetPersonStats()
        {

            return $"{FirstName}: {LastName}: {Age}:";
        }
    }
}
