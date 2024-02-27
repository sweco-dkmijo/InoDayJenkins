using InoDayJenkins.Classes;
using InoDayJenkins.Controllers;

namespace InoDayJenkinsTest
{
	public class UnitTest1
	{
        WeatherForecastController _weather = new WeatherForecastController(new BusinessLogic());

        [Fact]
		public void Test1()
		{
			Assert.True(true);
		}

        [Fact]
        public void GreaterThen0()
		{
			//WeatherForecastController weather = new WeatherForecastController(new BusinessLogic());
			var res = _weather.GetNumbers();
			Assert.True(res.Count() > 0);
		}

        [Fact]
        public void LessThen6()
        {
            WeatherForecastController weather = new WeatherForecastController(new BusinessLogic());
            var res = _weather.GetNumbers();
            Assert.True(res.Count() < 6);
        }

        [Fact]
        public void EqualsTo5()
        {
            var res = _weather.GetNumbers();
            Assert.True(res.Count() == 4);
        }


        [Fact]
		public void IsPrime_ReturnsCorrectResults()
		{
			// Arrange
			var logic = new BusinessLogic();

			var candidates = new List<int>() {
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		};
			var results = new List<bool>();
			var truth = new List<bool>() {
			false,
			true,
			true,
			false,
			true,
			false,
			true,
			false,
			false
//2, 3, 5, 7,
        };

			// Act
			for (int i = 0; i < candidates.Count(); i++)
				results.Add(logic.isPrime(candidates[i]));

			// Assert
			for (int i = 0; i < results.Count(); i++)
				Assert.Equal(truth[i], results[i]);
		}
	}
}