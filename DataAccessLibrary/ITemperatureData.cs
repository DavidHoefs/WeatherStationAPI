using System.Collections.Generic;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
    public interface ITemperatureData
    {
        List<TemperatureSensorModel> GetData();

        void SaveSensorData(TemperatureSensorModel temp);
    }
}