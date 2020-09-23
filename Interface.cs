using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
    interface ITerrestrialAnimal : IAnimal
    {
        void Move();
    }
    interface IMarineAnimal : IAnimal
    {
        void Move();
    }
}
