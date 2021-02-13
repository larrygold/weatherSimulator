using System;

namespace WeatherSimulator
{
    public class WeatherEventArgs : EventArgs
    {
        public Weather Weather { get; set; }
    }
}