using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Four
{
    class Program
    {
        static void Main(string[] args)
        {


            int Wave = 1;
            while (Wave == 1)
            {
                Console.WriteLine("Welcome mathematician! Enter Integer:");
                int i = 0;
                int X = int.Parse(Console.ReadLine());


                for (i = 1; i <= X; i++)
                {
                    int Y = Math.SquaredBoy(i);
                    int Z = Math.CubedUp(i);
                    Console.WriteLine($"Number{i}:   Squared:{Y}    Cubed:{Z}");

                }
                Console.WriteLine("Continue? Yes or No");
                Wave++;
                string answer = null;
                answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    Wave--;
                }
                if (answer == "No")
                {
                    Console.WriteLine("Hope You Have A Good Day!");
                }

            }

        }
    }
        
}
