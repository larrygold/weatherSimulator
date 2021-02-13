using System;
using System.Collections.Generic;

namespace WeatherSimulator
{
    public class Simulator
    {
        public List<int> Numbers { get; } = new List<int>();

        public event EventHandler<WeatherEventArgs> WeatherChanged;

        private int _numberOfNumbers;

        public Simulator(int numberOfNumbers)
        {
            _numberOfNumbers = numberOfNumbers;
        }

        public void GenerateNumbers()
        {
            var r = new Random();

            for (var i = 0; i < _numberOfNumbers; i++)
            {
                var currentNumber = r.Next(0, 100);
                var currentWeather = GetWeatherFromNumber(currentNumber);
                var data = new WeatherEventArgs();
                data.Weather = currentWeather;
                if (WeatherChanged != null)
                {
                    WeatherChanged(this, data);
                }
                Numbers.Add(currentNumber);
            }
        }

        private Weather GetWeatherFromNumber(int number)
        {
            if (number < 5)
            {
                return Weather.Sunny;
            }
            else if (number < 50)
            {
                return Weather.Cloudy;
            }
            else if (number < 90)
            {
                return Weather.Rainy;
            }
            else
            {
                return Weather.Stormy;
            }
        }
    }
}