using System;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumerations Boyeee!");
            string weekDay = WeekDays.Friday.ToString();
            Console.WriteLine("The day (to string) is " + weekDay);

            WeekDays day = WeekDays.Saturday;
            Console.WriteLine("The day (property) is " + day);
            Console.WriteLine("The day (integer property) is " + (int)day);

        }
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
