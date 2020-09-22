using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.Moq;
using Autofac;
using WeatherStationAPI.Library.Internal.DataAccess;
using WeatherStationAPI.Library.Models;
using Xunit;
using WeatherStationAPI.Library.DataAccess;
using WeatherStationAPI.Controllers;
using Moq;

namespace WeatherStationAPI.UnitTest
{
    public class TemperatureSensorDataTests
    {
        [Fact]
        public void GetData_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<ISqlDataAccess>()
                    .Setup(x => x.LoadData<TemperatureSensorModel, dynamic>("dbo.spTemperatureSensor_GetData", new { }, "WeatherStationDB"))
                    .Returns(GetSampleTemps());

                var controller = mock.Create<TemperatureSensorData>();
                var expected = GetSampleTemps();
                var actual = controller.GetData();

                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);

                for(int i = 0; i< expected.Count; i++)
                {
                    Assert.Equal(expected[i].Temperature, actual[i].Temperature);
                }

            }
           
        }

        [Fact]
        public void SaveSensorData_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var temp = GetSampleDBTemps()[0];
                mock.Mock<ISqlDataAccess>()
                    .Setup(x => x.SaveData("dbo.spTemperatureSensor_UploadData", temp, "WeatherStationDB"));

                var cls = mock.Create<TemperatureSensorController>();
               

                cls.Post(temp);

                mock.Mock<ISqlDataAccess>()
                   .Verify(x => x.SaveData("dbo.spTemperatureSensor_GetData", temp, "WeatherStationDB"), Times.Exactly(1));







            }
        }
        private List<TemperatureSensorDBModel> GetSampleDBTemps()
        {
            List<TemperatureSensorDBModel> output = new List<TemperatureSensorDBModel>
            {
                new TemperatureSensorDBModel
                {
                    Temperature = 77,
                    Humidity = 0.22,
                    TimeCaptured = DateTime.Parse("2020-09-21T20:00:00")
                },
                new TemperatureSensorDBModel
                {
                    Temperature = 77,
                    Humidity = 0.22,
                    TimeCaptured = DateTime.Parse("2020-09-21T20:00:00")
                },
                new TemperatureSensorDBModel
                {
                    Temperature = 77,
                    Humidity = 0.22,
                    TimeCaptured = DateTime.Parse("2020-09-21T20:00:00")
                }
            };
            return output;
        }
        private List<TemperatureSensorModel> GetSampleTemps()
        {
            List<TemperatureSensorModel> output = new List<TemperatureSensorModel>
            {
                new TemperatureSensorModel
                {
                    Temperature = 77,
                    Humidity = 0.22,
                    TimeCaptured = DateTime.Parse("2020-09-21T20:00:00")
                },
                new TemperatureSensorModel
                {
                    Temperature = 77,
                    Humidity = 0.22,
                    TimeCaptured = DateTime.Parse("2020-09-21T20:00:00")
                },
                new TemperatureSensorModel
                {
                    Temperature = 77,
                    Humidity = 0.22,
                    TimeCaptured = DateTime.Parse("2020-09-21T20:00:00")
                }
            };
            return output;
        }
    }

}