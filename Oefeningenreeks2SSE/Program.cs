using System;
using System.Collections.Generic;

namespace Oefeningenreeks2SSE
{
    [Flags]
    enum WeekDays
    {
        Monday= 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64
        //,Week = Monday ^ Tuesday ^ Wednesday ^ Thursday ^ Friday
    }
    class Program
    {
        /*
        enum Cities: byte
        {
            London = 1,
            Paris = 2,
            Brussels = 4,
            Romantic = London | Paris,
            Hellhole = Brussels,
        }
        */

        

        static void Main(string[] args)
        {
            Calender c = new Calender();
            WeekDays Week = WeekDays.Monday ^ WeekDays.Tuesday ^ WeekDays.Wednesday ^ WeekDays.Thursday ^ WeekDays.Friday;
            c.ShowDays(Week);
            //c.ShowAllDays();
            //c.ShowWorkDays();
            //c.ShowWeekend();
        }
        }
    }











//var selectedLanguages = ("Dutch", "Francais", "Deutsch");
//Console.WriteLine($"Chose language is {selectedLanguages.Item2}");

//var selectedLanguages2 = (Native: "Dutch", Foreign1: "Francais", Foreign2: "Deutsch");
//Console.WriteLine($"Chosen language is: {selectedLanguages2.Native}");

//var deviation = Deviation(5, 3);
//Console.WriteLine($"Values are: {deviation.belowBase}, {deviation.devValue}, {deviation.aboveBase}");

//(int belowBase, int devValue, int aboveBase) Deviation(int baseValue, int difference) {
//    return (baseValue - difference, baseValue, baseValue+ difference);

//List<Tuple<string, int, int>> lijst = new List<Tuple<string, int, int>>
//{
//    new Tuple<string, int, int>("één", 1, 2),
//    new Tuple<string, int, int>("twee", 2, 3)
//};

//lijst.ForEach(item =>
//{
//    (string woord, int getal1, int getal2) = item;
//    Console.WriteLine($"{woord}:  {getal1} -> {getal2}");
//});
