using System;
using Xunit;
using dotnet_api.Controllers;

namespace dotnet_test
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

            var weatherForecastController = new WeatherForecastController(null);
            var test = new Test{
                nombre="gabo",
                apellido="araujo",
            };
        }
    }

    public class Test
    {
        public string nombre { get; set; }
        public string apellido {get; set;}
    }
}
