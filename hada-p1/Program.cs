using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("From which unit do you want to start ('m' for minutes, 's' for seconds)? ");
            string answer=Console.ReadLine();
            if (answer == "m")
            {
                do
                {
                    Console.Write("Enter the amount of minutes: ");
                    double minutes = double.Parse(Console.ReadLine());
                    Console.WriteLine(minutes + "minutes are " + HadaP1.Minutes2Seconds(minutes) + "seconds.");
                    Console.Write("Do you want to perform more conversions (y/n)? ");
                } while (Console.ReadLine()=="y");
            }
        }
    }
}
