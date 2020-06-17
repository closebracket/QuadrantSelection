using System;

namespace KattisApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int FinalValue = 0;
            int X = int.Parse(Console.ReadLine());
            int Y =  int.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                FinalValue = 1;
            }
            else if (X < 0 && Y > 0)
            {
                FinalValue = 2;
            }
           else if (X < 0 && Y < 0)
            {
                FinalValue = 3;
            }
           else if (X > 0 && Y < 0)
            {
                FinalValue = 4;
            }

            Console.WriteLine(FinalValue);
            
        }
    }
}
