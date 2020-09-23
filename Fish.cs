using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Fish : IMarineAnimal
    {
        int id { get; set}
        string name { get; set}
        int age { get; set}

        public void Move()
        {
            Console.WriteLine("Swim");
        }
        public override string ToString()
        {

            return $"Id: {ID}\nName: {Name} \nAge: {Age}";
        }
    }
}