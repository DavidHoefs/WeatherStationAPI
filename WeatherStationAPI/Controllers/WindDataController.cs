using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Library.DataAccess;
using WeatherStationAPI.Library.Models;

namespace WeatherStationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindDataController : ControllerBase
    {
        private readonly IWindData _windData;

       
        public WindDataController(IWindData windData)
        {
            _windData = windData;
        }

        [HttpGet]
        [Route("GetAllData")]
        public List<WindDataModel> GetAllData()
        {
            return _windData.GetAllData();
        }

        [HttpPost]
        [Route("InsertData")]
        public void InsertData(WindDataDBModel data)
        {
            _windData.InsertData(data);
        }
    }
}
