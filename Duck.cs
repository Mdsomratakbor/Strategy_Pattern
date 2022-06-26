using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public abstract class Duck
    {
        public virtual void Quack() {

            Console.WriteLine("Duck Sound : Quack, Quack");
        }
        public abstract void Swim();
        public abstract void Fly();
        public abstract void Display();
      
    }
}
