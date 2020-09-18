using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherStationWebUI.Models
{
    public class DisplayTempModel
    {
        public int Id { get; set; }
        public string Temperature { get; set; }
        public DateTime DateCaptured { get; set; }
    }
}
