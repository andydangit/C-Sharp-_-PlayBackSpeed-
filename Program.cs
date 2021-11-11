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
            string userHours = Console.ReadLine();
            double hours = Convert.ToDouble( (userHours));
            double totalHoursInMinutes = hours * 60;

            // Ask user for the total minutes 
            Console.Write("how many minutes: ");
            string userMinutes = Console.ReadLine();
            double minutes = Convert.ToDouble( (userMinutes));


            // Ask user for the total Second
            Console.Write("how many second: ");
            string userSecond = Console.ReadLine();
            double second = Convert.ToDouble( (userSecond));

            //total lenght in minutes 
            double totalMinutes = (totalHoursInMinutes + minutes) + (second / 100);

            // what is the playback Speed 
            Console.Write("What is the playback speed? ");
            string userPlaySpeed = Console.ReadLine();
            float PlaySpeed = float.Parse(userPlaySpeed);




            // Calculate the total playback Speed 
            double totalTimes = ((100 * totalMinutes) / (100 * PlaySpeed));


            Console.WriteLine(totalTimes.ToString());




        }
    }
}
