using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Library.DataAccess;
using WeatherStationAPI.Library.Models;

namespace WeatherStationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureSensorController : ControllerBase
    {
        private readonly ITemperatureSensorData _temperatureSensorData;

        public TemperatureSensorController(ITemperatureSensorData temperatureSensorData)
        {
            _temperatureSensorData = temperatureSensorData;
        }

        [HttpGet]
        [Route("GetData")]
        public List<TemperatureSensorModel> Get()
        {
            return _temperatureSensorData.GetData();
        }

        [HttpPost]
        [Route("PostData")]
        public void Post(TemperatureSensorDBModel temp)
        {
            _temperatureSensorData.SaveSensorData(temp);
        }
    }
}