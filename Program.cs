using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayBackSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate total length 

            //  Ask user for the input in length 
            Console.Write("how many hours: ");
            double Hours = Convert.ToDouble (Console.ReadLine());
            double totalHoursInMinutes = Hours * 60;

            // Ask user for the total minutes 
            Console.Write("how many minutes: ");
            double  minutes = Convert.ToDouble( Console.ReadLine());

            // Ask user for the total Second
            Console.Write("how many second: ");
            double second = Convert.ToDouble( Console.ReadLine());

            //total lenght in minutes 
            double totalMinutes = (totalHoursInMinutes + minutes) + (second / 100);

            // what is the playback Speed 
            Console.Write("What is the playback speed? ");
            double PlaySpeed = Convert.ToDouble( Console.ReadLine());


            // Calculate the total playback Speed 
            double totalTimes = ((100 * totalMinutes) / (100 * PlaySpeed));


            Console.WriteLine("If you increase your audio speed by {0}, it will reduce your playback length to {1} minutes", PlaySpeed, Math.Round(totalTimes, 2));




        }
    }
}
