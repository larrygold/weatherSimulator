using System;

namespace WeatherSimulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mySimulator = new Simulator(20);
            var myStatistics = new Statistics(mySimulator);
            mySimulator.GenerateNumbers();
            var weatherReport = myStatistics.GenerateReport();

            Console.WriteLine($"# of weather changes: {weatherReport.NumberOfWeatherChanges}");
            Console.WriteLine($"# of sunny days: {weatherReport.NumberOfSunnyDays}");
        }
    }
}