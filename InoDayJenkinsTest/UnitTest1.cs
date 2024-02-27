using InoDayJenkins.Classes;

namespace InoDayJenkinsTest
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Assert.True(false);
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
			candidates.ForEach(t => results.Add(logic.isPrime(t)));

			// Assert
			Assert.True(truth.SequenceEqual(results));
		}
	}
}