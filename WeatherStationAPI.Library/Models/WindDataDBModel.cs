using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationAPI.Library.Models
{
   public class WindDataDBModel
    {
        public double WindSpeed_Knots { get; set; }
        public double WindSpeed_MPH { get; set; }
        public string WindDirection { get; set; }
        public DateTime DateCaptured { get; set; }
    }
}
