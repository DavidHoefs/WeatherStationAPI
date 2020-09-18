using System.Collections.Generic;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
    public class TemperatureData : ITemperatureData
    {
        private readonly ISqlDataAccess _sql;

        public TemperatureData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<TemperatureSensorModel> GetData()
        {
            return _sql.LoadData<TemperatureSensorModel, dynamic>("dbo.spTemperatureSensor_GetData", new { }, "WeatherStationDB");
        }

        public void SaveSensorData(TemperatureSensorModel temp)
        {
            _sql.SaveData("dbo.spTemperatureSensor_UploadData", temp, "WeatherStationDB");
        }
    }
}