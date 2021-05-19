using System;
using Xunit;
using SimpleApi.Controllers;


namespace SimpleApi.test
{
    public class UnitTest1
    {
       WeatherForecastController controller = new WeatherForecastController();


[Fact]
public void Test()
{
  var returnValue = controller.Get();
  Assert.Equal("yacinee zighem", returnValue.Value);
}
     
     
        [Fact]
        public void Test1()
        {

        }
    }
}
