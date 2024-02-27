using InoDayJenkins;

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
		public void Test2()
		{
			float c = 20;
			float f = 68;

			float cConvertedToF = TemperatureConverter.ConvertToFerenhite(c);

			Assert.Equal(f, cConvertedToF);
		}
	}
}