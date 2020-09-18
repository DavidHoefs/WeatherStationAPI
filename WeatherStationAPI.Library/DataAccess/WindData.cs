using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using WeatherStationAPI.Library.Internal.DataAccess;
using WeatherStationAPI.Library.Models;

namespace WeatherStationAPI.Library.DataAccess
{
    public class WindData : IWindData
    {
        private readonly IConfiguration _configuration;
        private readonly ISqlDataAccess _sql;

        public WindData(IConfiguration configuration, ISqlDataAccess sql)
        {
            _configuration = configuration;
            _sql = sql;
        }

        public List<WindDataModel> GetAllData()
        {
            var output = _sql.LoadData<WindDataModel, dynamic>("dbo.spWindData_GetAllData", new { }, "WeatherStationDB");
            return output;
        }

        public void InsertData(WindDataDBModel data)
        {
            _sql.SaveData("dbo.spWindData_InsertData", data, "WeatherStationDB");
        }
    }
}
