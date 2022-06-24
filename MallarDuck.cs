using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class MallarDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Mallar Duck");
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
