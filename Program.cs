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
            int hours = Int32.Parse(userHours);
            int totalHoursInMinutes = hours * 60;

            // Ask user for the total minutes 
            Console.Write("how many minutes: ");
            string userMinutes = Console.ReadLine();
            int minutes = Int32.Parse(userMinutes);


            // Ask user for the total Second
            Console.Write("how many second: ");
            string userSecond = Console.ReadLine();
            int second = Int32.Parse(userSecond);

            //total lenght in minutes 
            float totalMinutes = (totalHoursInMinutes + minutes) + (second / 100);

            // what is the playback Speed 
            Console.Write("What is the playback speed? ");
            string userPlaySpeed = Console.ReadLine();
            float PlaySpeed = float.Parse(userPlaySpeed);




            // Calculate the total playback Speed 
            float totalTimes = ((100 * totalMinutes) / (100 * PlaySpeed));


            Console.WriteLine(totalTimes.ToString());


            // Bugs: it does not show the length of speed if you input it for the total Second


        }
    }
}
