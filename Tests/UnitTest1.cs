namespace Tests;

using InoDayJenkins.Classes;

public class UnitTest1
{
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
        for(int i = 0; i < candidates.Count(); i++)
            results.Add(logic.isPrime(candidates[i]));

        // Assert
        for(int i = 0; i < results.Count(); i++)
            Assert.Equal(truth[i], results[i]);
    }
}