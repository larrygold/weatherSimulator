using System;
using System.Collections.Generic;

namespace WeatherSimulator
{
    public class Statistics
    {
        private List<Weather> _weatherOccurrences = new List<Weather>();

        private Simulator _simulator;

        public Statistics(Simulator mySimulator)
        {
            _simulator = mySimulator;
            _simulator.WeatherChanged += AddWeatherToStatistics;
        }

        private void AddWeatherToStatistics(Object sender, WeatherEventArgs weatherEventArgs)
        {
            _weatherOccurrences.Add(weatherEventArgs.Weather);
        }

        public WeatherReport GenerateReport()
        {
            var report = new WeatherReport();
            var numberOfWeatherChanges = 0;
            var numberOfSunnyDays = 0;
            foreach (Weather weather in _weatherOccurrences)
            {
                numberOfWeatherChanges += 1;
                if (weather == Weather.Sunny)
                {
                    numberOfSunnyDays += 1;
                }
            }
            report.NumberOfWeatherChanges = numberOfWeatherChanges;
            report.NumberOfSunnyDays = numberOfSunnyDays;

            return report;
        }
    }
}