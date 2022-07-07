using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_MERCEDES
{
    public class Dog
    {
        public string name;
        public string color;
        public byte age;
        
        public Dog(string n, string c, byte a)
        {
            this.name = n;
            this.color = c;
            this.age = a;

            Console.WriteLine("Custom construktor worked");


        }
            public string GetDetalis()
            {
                return $"{name} {color} {age}";
            }
    }
}
