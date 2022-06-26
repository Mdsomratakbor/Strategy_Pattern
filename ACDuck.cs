﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class ACDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("ACDuck Display");
        }

        public override void Fly()
        {
            Console.WriteLine("AC Duck Flying");
        }

        public override void Swim()
        {
            Console.WriteLine("AC Duck Swiming");
        }
    }
}
