using System.Collections.Generic;
using WeatherStationAPI.Library.Models;

namespace WeatherStationAPI.Library.DataAccess
{
    public interface IWindData
    {
        List<WindDataModel> GetAllData();
        void InsertData(WindDataDBModel data);
    }
}