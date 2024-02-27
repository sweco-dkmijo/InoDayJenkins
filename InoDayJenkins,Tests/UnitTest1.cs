using Xunit;
using InoDayJenkins.Controllers;

namespace InoDayJenkins_Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var cont = new WeatherForecastController(null);
        Assert.NotEmpty(cont.Get());
    }
}