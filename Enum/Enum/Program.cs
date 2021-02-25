using System;

namespace Enum
{
    class Program
    {
        enum Muscle 
        { 
        Biceps=1,
        Pecs=2,
        Calves=3,
        Core=4,
        Forearms=5
        }
        static void Main(string[] args)
        {
            Muscle complex;
            complex = Muscle.Biceps;
            Console.Write(complex);
        }
    }
}
