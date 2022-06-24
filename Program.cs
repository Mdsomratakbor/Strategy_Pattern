using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallarDuck();
            duck.Display();
        }
    }
}
