using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherStationWebUI.Data
{
    public class TemperatureSensor
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public DateTime TimeCaptured { get; set; }
    }
}
