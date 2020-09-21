using System.Collections.Generic;
using WeatherStationAPI.Library.Models;

namespace WeatherStationAPI.Library.DataAccess
{
    public interface ITemperatureSensorData
    {
        List<TemperatureSensorModel> GetData();
        void SaveSensorData(TemperatureSensorDBModel temp);

        void BulkSaveData(List<TemperatureSensorDBModel> temps);
    }
}