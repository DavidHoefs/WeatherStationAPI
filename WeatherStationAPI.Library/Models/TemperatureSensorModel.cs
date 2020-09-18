using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationAPI.Library.Models
{
   public class TemperatureSensorModel
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public DateTime TimeCaptured { get; set; }
    }
}
