using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSimulator
{
    public class WeatherEventArgs : EventArgs
    {
        public Weather Weather { get; set; }
    }
}
