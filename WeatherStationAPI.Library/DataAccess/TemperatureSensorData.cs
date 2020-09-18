using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using WeatherStationAPI.Library.Internal.DataAccess;
using WeatherStationAPI.Library.Models;

namespace WeatherStationAPI.Library.DataAccess
{
    public class TemperatureSensorData : ITemperatureSensorData
    {
        private readonly IConfiguration _config;
        private readonly ISqlDataAccess _sql;

        public TemperatureSensorData(IConfiguration config, ISqlDataAccess sql)
        {
            _config = config;
            _sql = sql;
        }

        public List<TemperatureSensorModel> GetData()
        {
            var output = _sql.LoadData<TemperatureSensorModel, dynamic>("dbo.spTemperatureSensor_GetData", new { }, "WeatherStationDB");
            return output;
        }

        public void SaveSensorData(TemperatureSensorDBModel temp)
        {
            _sql.SaveData("dbo.spTemperatureSensor_UploadData", temp, "WeatherStationDB");
        }
    }
}
