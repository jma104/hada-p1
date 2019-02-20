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
            do
            {
                Console.Write("From which unit do you want to start ('m' for minutes, 's' for seconds, 'h' for hours)? ");
                string answer=Console.ReadLine();
                if (answer == "m")
                {
                    Console.Write("Enter the amount of minutes: ");
                    double minutes = double.Parse(Console.ReadLine());
                    Console.WriteLine(minutes + " minutes are " + HadaP1.Minutes2Seconds(minutes) + " seconds.");
                }
                else if (answer=="h")
                {
                    Console.Write("Enter the amount of hours: ");
                    double hours = double.Parse(Console.ReadLine());
                    Console.WriteLine(hours + " hours are " + HadaP1.Hours2Minutes(hours) + " minutes.");
                }
                else
                {
                    Console.Write("Enter the amount of seconds: ");
                    double seconds = double.Parse(Console.ReadLine());
                    Console.WriteLine(seconds + " seconds are " + HadaP1.Seconds2Minutes(seconds) + " minutes.");
                }
                Console.Write("Do you want to perform more conversions (y/n)? ");
            } while (Console.ReadLine()=="y");
        }
    }
}
