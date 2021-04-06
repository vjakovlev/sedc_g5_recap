using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Classes
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public string Eat()
        {
            string message = $"{Name} the dog from the breed {Race} whose fur is {Color} is now eating. Nummyy nummy :)";
            return message;
        }
        public string Play()
        {
            string message = $"{Name} the dog from the breed {Race} whose fur is {Color} is now playing with his toys \nand {Name} is making \"ROAR ROAR\"!";
            return message;
        }
        public string ChaseTail()
        {
            string message = $"{Name} the dog from the breed {Race} whose fur is {Color} is now spinning around and chasing it's tail!";
            return message;
        }
    }
}
