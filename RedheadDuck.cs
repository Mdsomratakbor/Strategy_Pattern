using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Red head Duck");
        }

        public override void Quack()
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
