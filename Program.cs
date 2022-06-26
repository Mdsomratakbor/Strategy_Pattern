using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.WriteLine("==== Mallar Duck Info ====");
            Duck duck = new MallarDuck();
            duck.Display();
            duck.Quack();
            duck.Swim();

            Console.ForegroundColor
            = ConsoleColor.Red;
            Console.WriteLine("\n==== Redhead Duck Info ====");
            Duck duck2 = new RedheadDuck();
            duck2.Display();
            duck2.Quack();
            duck2.Swim();
            Console.ForegroundColor
           = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== AB Duck Info ====");
            Duck duck3 = new ABDuck();
            duck3.Display();
            duck3.Quack();
            duck3.Swim();
            Console.ForegroundColor
           = ConsoleColor.Cyan;
            Console.WriteLine("\n==== AD Duck Info ====");
            Duck duck4 = new ADDuck();
            duck4.Display();
            duck4.Quack();
            duck4.Swim();
            Console.ForegroundColor
           = ConsoleColor.Black;
            Console.WriteLine("\n==== AC Duck Info ====");
            Duck duck5 = new ACDuck();
            duck5.Display();
            duck5.Quack();
            duck5.Swim();



        }
    }
}
