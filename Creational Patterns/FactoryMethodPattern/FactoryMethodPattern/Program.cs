﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = AnimalFactory.CreateAnimalObject(Animals.Dog);
            animal.MakeSound();
            Console.ReadLine();
        }
    }
}
