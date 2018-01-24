using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, square,cubed; string answer;
            Console.WriteLine("learn your squares and cubes!\n");
            do
            {
                Console.Write("Enter an integer :     ");
            number = int.Parse(Console.ReadLine());


                Console.Write("Number".PadRight(30, ' ')); 
            Console.Write("square".PadRight(30, ' '));
                Console.Write("cubed \n");
                Console.Write("======".PadRight(30, ' '));
                Console.Write("======".PadRight(30, ' '));
                Console.WriteLine("======".PadRight(30, ' '));
                for (int i=1;i<=number;i++  )
            {
                square = i * i;
                cubed = i * i * i;
                    if(i >3)

                Console.WriteLine(i + "".PadRight(30, ' ') + square + "".PadRight(28, ' ') + cubed);
                    else
                        Console.WriteLine(i + "".PadRight(30, ' ') + square + "".PadRight(30, ' ') + cubed);
                }

            Console.WriteLine("Continue?(y/n)");
            answer = Console.ReadLine();
            if (answer == "n" || answer == "N")
            {
                Console.WriteLine($"Bye!");
                Console.ReadLine();
                break;



            }
        }
            while (answer == "Y" || answer == "y");
        }
    }
}
