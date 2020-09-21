using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit;

namespace WeatherStationAPI.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DateTime start;
            DateTime end;
            using (var client = new HttpClient())
            {
                start = DateTime.Now;
                var response = client.GetAsync("https://localhost:44383/api/WindData/GetAllData");
                end = DateTime.Now;
            }
            var expected = 1;
            var actual = (int)(end - start).TotalMilliseconds;
            Assert.True(actual <= expected, $"Expected total milliseconds of less than or equal to {expected} but was {actual}.");
        }

        [Fact]
        public void AverageResponseTime_100Requests()
        {
            var allResponseTimes = new List<(DateTime Start, DateTime End)>();

            for (var i = 0; i < 100; i++)
            {
                using (var client = new HttpClient())
                {
                    var start = DateTime.Now;
                    var response = client.GetAsync("https://localhost:44383/api/WindData/GetAllData").Result;
                    var end = DateTime.Now;

                    allResponseTimes.Add((start, end));
                }
            }

            var expected = 1;
            var actual = (int)allResponseTimes.Select(r => (r.End - r.Start).TotalMilliseconds).Average();
            Assert.True(actual <= expected, $"Expected average response time of less than or equal to {expected} ms but was {actual} ms.");
        }
    }
}
