﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Animal
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Leg { get; set; }
        public string Arm { get; set; }
        public string Tail { get; set; }


        //helper method for demo the Polymorphism, so we can 
        //easily tell what type object it is from client.
        public abstract void Eat();

        //helper method for demo the result from client
        public void ShowMe()
        {
            Console.WriteLine(Head);
            Console.WriteLine(Body);
            Console.WriteLine(Leg);
            Console.WriteLine(Arm);
            Console.WriteLine(Tail);
            Eat();

        }
    }
}
