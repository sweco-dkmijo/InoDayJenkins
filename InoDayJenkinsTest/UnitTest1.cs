using InoDayJenkins.Classes;
using InoDayJenkins.Controllers;

namespace InoDayJenkinsTest
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Assert.True(true);
		}

		[Fact]
		public void IsPrime_ReturnsCorrectResults()
		{
			// Arrange
			var controller = new WeatherForecastController();
            // Act
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
            foreach (var candidate in candidates)
             results.Add(controller.IsPrimeNumber(candidate));
            
			
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

			// Assert
			for (int i = 0; i < results.Count(); i++)
				Assert.Equal(truth[i], results[i]);
		}
	}
}