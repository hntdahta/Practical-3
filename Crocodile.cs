using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Crocodile : ITerrestrialAnimal ,IMarineAnimal
    {
        int id { get; set}
        string name { get; set}
        int age { get; set}

        void ITerrestrialAnimal.Move()
        {
            Console.WriteLine("Run");
        }
        void IMarineAnimal.Move()
        {
            Console.WriteLine("Swim");
        }
        public override string ToString()
        {
            return $"Id: {ID}\nName: {Name} \nAge: {Age}";
        }
    }
}
